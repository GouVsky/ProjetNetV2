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

            // On charge les donn�es de la famille.

            Nom_Famille_Edition.Text = Famille.SubItems[1].Text;

            Bouton_Validation.Text = "Modifier";
        }

        /// <summary>
        /// Ajoute la famille dans la base de donn�es.
        /// </summary>
        /// <returns> La famille ajout�e </returns>
        public Famille Ajouter_Famille()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            int Reference = Data_Reader.Inserer_Famille(Nom_Famille_Edition.Text);

            Data_Reader.Terminer_Connection();

            Famille Famille = new Famille(Reference, Nom_Famille_Edition.Text);

            return Famille;
        }

        /// <summary>
        /// Met � jour la famille s�lectionn�e avec le nouveau nom entr�.
        /// </summary>
        /// <returns> La famille mise � jour </returns>
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
        /// Lance la v�rification des donn�es entr�es avant la validation.
        /// </summary>
        /// <param name="sender"> l'objet envoy� </param>
        /// <param name="e"> l'�v�nement </param>
        private void Bouton_Validation_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                DialogResult = DialogResult.None;

            else
                DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Annule les actions r�alis�es.
        /// </summary>
        /// <param name="sender"> l'objet envoy� </param>
        /// <param name="e"> l'�v�nement </param>
        private void Bouton_Annuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Lance la v�rification de la validit� du champ associ� au nom de la famille. Affiche une erreur si le champ n'est pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoy� </param>
        /// <param name="e"> l'�v�nement d'annulation </param>
        private void Nom_Famille_Edition_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<Famille> Familles = Data_Reader.Recuperer_Familles();

            Data_Reader.Terminer_Connection();

            string Nom = Nom_Famille_Edition.Text;

            foreach (Famille Famille in Familles)
            {
                // Si on ajoute une nouvelle famille, on v�rifie que le nom indiqu� n'existe pas.

                if (Nom_Famille_Edition.Text.Equals(Famille.Recuperer_Nom()) && this.Famille == null)
                {
                    e.Cancel = true;

                    Erreur.SetError(Nom_Famille_Edition, "La famille existe d�j�.");
                }

                // Si on modifie une famille, on v�rifie que le nom indiqu� est diff�rent du nom actuel,
                // et qu'il n'est pas attribu� � une autre famille.

                else if (this.Famille != null && Nom_Famille_Edition.Text.Equals(Famille.Recuperer_Nom()) && !this.Famille.SubItems[1].Text.Equals(Nom_Famille_Edition.Text))
                {
                    e.Cancel = true;

                    Erreur.SetError(Nom_Famille_Edition, "La famille existe d�j�.");
                }
            }
        }

        /// <summary>
        /// Efface l'erreur affich�e si le champ associ� au nom de la famille n'�tait pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoy� </param>
        /// <param name="e"> l'�v�nement </param>
        private void Nom_Famille_Edition_Validated(object sender, EventArgs e)
        {
            Erreur.SetError(Nom_Famille_Edition, "");
        }
    }
}