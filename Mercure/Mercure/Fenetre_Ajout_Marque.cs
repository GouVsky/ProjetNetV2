using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    partial class Fenetre_Ajout_Marque : Form
    {
        ListViewItem Marque;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Fenetre_Ajout_Marque"/>.
        /// </summary>
        public Fenetre_Ajout_Marque()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Fenetre_Ajout_Marque"/> avec un objet <see cref="ListViewItem"/> de type <see cref="Marque"/>.
        /// </summary>
        /// <param name="Article">Un objet <see cref="ListViewItem"/> de type <see cref="Marque"/></param>
        public Fenetre_Ajout_Marque(ListViewItem Marque)
        {
            InitializeComponent();

            this.Marque = Marque;

            // On charge les données de la marque.

            Nom_Marque_Edition.Text = Marque.SubItems[1].Text;

            Bouton_Validation.Text = "Modifier";
        }

        /// <summary>
        /// Ajoute la marque dans la base de données.
        /// </summary>
        /// <returns> La marque ajoutée </returns>
        public Marque Ajouter_Marque()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            int Reference = Data_Reader.Inserer_Marque(Nom_Marque_Edition.Text);

            Data_Reader.Terminer_Connection();

            Marque Marque = new Marque(Reference, Nom_Marque_Edition.Text);

            return Marque;
        }

        /// <summary>
        /// Met à jour la marque sélectionnée avec le nouveau nom entré.
        /// </summary>
        /// <returns> La marque mise à jour </returns>
        public Marque Mettre_A_Jour_Marque()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            int Reference = Convert.ToInt32(this.Marque.SubItems[0].Text);

            Data_Reader.Mise_A_Jour_Marque(Reference, Nom_Marque_Edition.Text);

            Data_Reader.Terminer_Connection();

            Marque Marque = new Marque(Reference, Nom_Marque_Edition.Text);

            return Marque;
        }

        /// <summary>
        /// Lance la vérification des données entrées avant la validation.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Validation_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                DialogResult = DialogResult.None;

            else
                DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Annule les actions réalisées.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Annuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Lance la vérification de la validité du champ associé au nom de la marque. Affiche une erreur si le champ n'est pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement d'annulation </param>
        private void Nom_Marque_Edition_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<Marque> Marques = Data_Reader.Recuperer_Marques();

            Data_Reader.Terminer_Connection();

            string Nom = Nom_Marque_Edition.Text;

            foreach (Marque Marque in Marques)
            {
                if (Marque.Recuperer_Nom().Equals(Nom) || (this.Marque != null && this.Marque.SubItems[1].Text.Equals(Nom)))
                {
                    e.Cancel = true;

                    Erreur.SetError(Nom_Marque_Edition, "La marque existe déjà. Veuillez en renseigner une nouvelle.");

                    break;
                }
            }
        }

        /// <summary>
        /// Efface l'erreur affichée si le champ associé au nom de la marque n'était pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Nom_Marque_Edition_Validated(object sender, EventArgs e)
        {
            Erreur.SetError(Nom_Marque_Edition, "");
        }
    }
}