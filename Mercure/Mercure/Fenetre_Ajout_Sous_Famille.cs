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

        public Fenetre_Ajout_Sous_Famille()
        {
            InitializeComponent();

            Charger_Famille();
        }

        public Fenetre_Ajout_Sous_Famille(ListViewItem Sous_Famille)
        {
            InitializeComponent();

            this.Sous_Famille = Sous_Famille;

            Nom_Sous_Famille_Edition.Text = Sous_Famille.SubItems[1].Text;

            Bouton_Validation.Text = "Modifier";

            Charger_Famille();
        }

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

        public SousFamille Ajouter_Famille()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            int Reference = Data_Reader.Inserer_Sous_Famille(Nom_Sous_Famille_Edition.Text, Choix_Famille_Selection.SelectedIndex);

            SousFamille Sous_Famille = new SousFamille(Reference, Nom_Sous_Famille_Edition.Text, (Famille)Choix_Famille_Selection.SelectedItem);

            Data_Reader.Terminer_Connection();

            return Sous_Famille;
        }

        public SousFamille Mettre_A_Jour_Sous_Famille()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            int Reference = Convert.ToInt32(this.Sous_Famille.SubItems[0].Text);

            Data_Reader.Mise_A_Jour_Sous_Famille(Reference, Nom_Sous_Famille_Edition.Text, ((Famille)Choix_Famille_Selection.SelectedItem).Recuperer_Reference());

            SousFamille Sous_Famille = new SousFamille(Reference, Nom_Sous_Famille_Edition.Text, (Famille)Choix_Famille_Selection.SelectedItem);

            Data_Reader.Terminer_Connection();

            return Sous_Famille;
        }

        private void Bouton_Validation_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                DialogResult = DialogResult.None;

            else
                DialogResult = DialogResult.OK;
        }

        private void Bouton_Annuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
        }

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

        private void Choix_Famille_Selection_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Choix_Famille_Selection.SelectedIndex == -1)
            {
                e.Cancel = true;

                Erreur.SetError(Choix_Famille_Selection, "Une famille doit être sélectionnée.");
            }
        }
    }
}