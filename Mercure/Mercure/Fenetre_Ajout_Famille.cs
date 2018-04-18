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

        public Fenetre_Ajout_Famille()
        {
            InitializeComponent();
        }

        public Fenetre_Ajout_Famille(ListViewItem Famille)
        {
            InitializeComponent();

            this.Famille = Famille;

            Nom_Famille_Edition.Text = Famille.SubItems[1].Text;
        }

        public Famille Ajouter_Famille()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            int Reference = Data_Reader.Inserer_Famille(Nom_Famille_Edition.Text);

            Famille Famille = new Famille(Reference, Nom_Famille_Edition.Text);

            Data_Reader.Terminer_Connection();

            return Famille;
        }

        public Famille Mettre_A_Jour_Famille()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            int Reference = Convert.ToInt32(this.Famille.SubItems[0].Text);

            Data_Reader.Mise_A_Jour_Famille(Reference, Nom_Famille_Edition.Text);

            Famille Famille = new Famille(Reference, Nom_Famille_Edition.Text);

            Data_Reader.Terminer_Connection();

            return Famille;
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

        private void Nom_Famille_Edition_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<Famille> Familles = Data_Reader.Recuperer_Familles();

            string Nom = Nom_Famille_Edition.Text;

            foreach (Famille Famille in Familles)
            {
                if (Famille.Recuperer_Nom().Equals(Nom))
                {
                    e.Cancel = true;

                    Erreur.SetError(Nom_Famille_Edition, "La famille existe déjà. Veuillez en renseigner une nouvelle.");

                    break;
                }
            }

            Data_Reader.Terminer_Connection();
        }
    }
}