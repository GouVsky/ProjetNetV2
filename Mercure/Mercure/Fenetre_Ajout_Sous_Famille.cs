using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    partial class Fenetre_Ajout_Sous_Famille : Form
    {
        ListViewItem Sous_Famille;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Fenetre_Ajout_Sous_Famille"/>.
        /// </summary>
        public Fenetre_Ajout_Sous_Famille()
        {
            InitializeComponent();

            Charger_Famille();
        }

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Fenetre_Ajout_Sous_Famille"/> avec un objet <see cref="ListViewItem"/> de type <see cref="SousFamille"/>.
        /// </summary>
        public Fenetre_Ajout_Sous_Famille(ListViewItem Sous_Famille)
        {
            InitializeComponent();

            this.Sous_Famille = Sous_Famille;

            // On remplit les champs avec les données de la sous-famille.

            Nom_Sous_Famille_Edition.Text = Sous_Famille.SubItems[1].Text;

            Bouton_Validation.Text = "Modifier";

            Charger_Famille();
        }

        /// <summary>
        /// Affiche l'intégralité des familles disponibles dans un <see cref="ComboBox"/> et sélectionne celle correspondant à celle de la sous-famille à modifier.
        /// </summary>
        private void Charger_Famille()
        {
            Choix_Famille_Selection.Items.Clear();

            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<Famille> Familles = Data_Reader.Recuperer_Familles();

            foreach (Famille Famille in Familles)
            {
                Choix_Famille_Selection.Items.Add(Famille);

                if (Famille.ToString().Equals(Sous_Famille.SubItems[2].Text))
                {
                    Choix_Famille_Selection.SelectedItem = Famille;
                }
            }

            Data_Reader.Terminer_Connection();
        }

        /// <summary>
        /// Ajoute la sous-famille dans la base de données.
        /// </summary>
        /// <returns> La sous-famille ajoutée </returns>
        public SousFamille Ajouter_Famille()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            int Reference = Data_Reader.Inserer_Sous_Famille(Nom_Sous_Famille_Edition.Text, ((Famille)Choix_Famille_Selection.SelectedItem).Recuperer_Reference());

            SousFamille Sous_Famille = new SousFamille(Reference, Nom_Sous_Famille_Edition.Text, ((Famille)Choix_Famille_Selection.SelectedItem));

            Data_Reader.Terminer_Connection();

            return Sous_Famille;
        }

        /// <summary>
        /// Met à jour la sous-famille sélectionnée avec le nouveau nom entré et/ou la nouvelle famille associée choisie.
        /// </summary>
        /// <returns> La sous-famille mise à jour </returns>
        public SousFamille Mettre_A_Jour_Sous_Famille()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            int Reference = Convert.ToInt32(this.Sous_Famille.SubItems[0].Text);

            Data_Reader.Mise_A_Jour_Sous_Famille(Reference, Nom_Sous_Famille_Edition.Text, ((Famille)Choix_Famille_Selection.SelectedItem).Recuperer_Reference());

            SousFamille Sous_Famille = new SousFamille(Reference, Nom_Sous_Famille_Edition.Text, (Famille)Choix_Famille_Selection.SelectedItem);

            Data_Reader.Terminer_Connection();

            return Sous_Famille;
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
            DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Lance la vérification de la validité du champ associé au nom de la sous-famille. Affiche une erreur si le champ n'est pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement d'annulation </param>
        private void Nom_Sous_Famille_Edition_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<SousFamille> Sous_Familles = Data_Reader.Recuperer_Sous_Familles();

            string Nom = Nom_Sous_Famille_Edition.Text;

            foreach (SousFamille Sous_Famille in Sous_Familles)
            {
                if (Sous_Famille.Recuperer_Nom().Equals(Nom))
                {
                    e.Cancel = true;

                    Erreur.SetError(Nom_Sous_Famille_Edition, "La sous-famille existe déjà. Veuillez en renseigner une nouvelle.");

                    break;
                }
            }

            Data_Reader.Terminer_Connection();
        }

        /// <summary>
        /// Efface l'erreur affichée si le champ associé au nom de la sous-famille n'était pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Nom_Sous_Famille_Edition_Validated(object sender, EventArgs e)
        {
            Erreur.SetError(Nom_Sous_Famille_Edition, "");
        }

        /// <summary>
        /// Lance la vérification de la validité du champ associé au choix de la famille. Affiche une erreur si le champ n'est pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement d'annulation </param>
        private void Choix_Famille_Selection_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Choix_Famille_Selection.SelectedIndex == -1)
            {
                e.Cancel = true;

                Erreur.SetError(Choix_Famille_Selection, "Une famille doit être sélectionnée.");
            }
        }

        /// <summary>
        /// Efface l'erreur affichée si le champ associé au choix de la famille n'était pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Choix_Famille_Selection_Validated(object sender, EventArgs e)
        {
            Erreur.SetError(Choix_Famille_Selection, "");
        }
    }
}