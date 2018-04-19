using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    partial class Fenetre_Ajout_Famille : Form
    {
        ListViewItem Famille;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Fenetre_Ajout_Famille"/>.
        /// </summary>
        public Fenetre_Ajout_Famille()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Fenetre_Ajout_Famille"/> avec un objet <see cref="ListViewItem"/> de type <see cref="Famille"/>.
        /// </summary>
        /// <param name="Article">Un objet <see cref="ListViewItem"/> de type <see cref="Famille"/></param>
        public Fenetre_Ajout_Famille(ListViewItem Famille)
        {
            InitializeComponent();

            this.Famille = Famille;

            // On charge les données de la famille.

            Nom_Famille_Edition.Text = Famille.SubItems[1].Text;

            Bouton_Validation.Text = "Modifier";
        }

        /// <summary>
        /// Ajoute la famille dans la base de données.
        /// </summary>
        /// <returns> La famille ajoutée </returns>
        public Famille Ajouter_Famille()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            int Reference = Data_Reader.Inserer_Famille(Nom_Famille_Edition.Text);

            Data_Reader.Terminer_Connection();

            Famille Famille = new Famille(Reference, Nom_Famille_Edition.Text);

            return Famille;
        }

        /// <summary>
        /// Met à jour la famille sélectionnée avec le nouveau nom entré.
        /// </summary>
        /// <returns> La famille mise à jour </returns>
        public Famille Mettre_A_Jour_Famille()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            int Reference = Convert.ToInt32(this.Famille.SubItems[0].Text);

            Data_Reader.Mise_A_Jour_Famille(Reference, Nom_Famille_Edition.Text);

            Data_Reader.Terminer_Connection();

            Famille Famille = new Famille(Reference, Nom_Famille_Edition.Text);

            return Famille;
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
        /// Lance la vérification de la validité du champ associé au nom de la famille. Affiche une erreur si le champ n'est pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement d'annulation </param>
        private void Nom_Famille_Edition_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<Famille> Familles = Data_Reader.Recuperer_Familles();

            Data_Reader.Terminer_Connection();

            string Nom = Nom_Famille_Edition.Text;

            foreach (Famille Famille in Familles)
            {
                // Si on ajoute une nouvelle famille, on vérifie que le nom indiqué n'existe pas.

                if (Nom_Famille_Edition.Text.Equals(Famille.Recuperer_Nom()) && this.Famille == null)
                {
                    e.Cancel = true;

                    Erreur.SetError(Nom_Famille_Edition, "La famille existe déjà.");
                }

                // Si on modifie une famille, on vérifie que le nom indiqué est différent du nom actuel,
                // et qu'il n'est pas attribué à une autre famille.

                else if (this.Famille != null && Nom_Famille_Edition.Text.Equals(Famille.Recuperer_Nom()) && !this.Famille.SubItems[1].Text.Equals(Nom_Famille_Edition.Text))
                {
                    e.Cancel = true;

                    Erreur.SetError(Nom_Famille_Edition, "La famille existe déjà.");
                }
            }
        }

        /// <summary>
        /// Efface l'erreur affichée si le champ associé au nom de la famille n'était pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Nom_Famille_Edition_Validated(object sender, EventArgs e)
        {
            Erreur.SetError(Nom_Famille_Edition, "");
        }
    }
}