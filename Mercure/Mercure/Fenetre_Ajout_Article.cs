using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Mercure
{
    public partial class Fenetre_Ajout_Article : Form
    {
        public Fenetre_Ajout_Article()
        {
            InitializeComponent();

            Charger_Marques();
            Charger_Familles();
            Charger_Sous_Familles();
        }

        public Fenetre_Ajout_Article(ListViewItem Article)
        {
            InitializeComponent();

            Charger_Marques(Article.SubItems[4].Text);
            Charger_Familles(Article.SubItems[2].Text);
            Charger_Sous_Familles(Article.SubItems[3].Text);

            Reference_Article_Edition.Text = Article.SubItems[0].Text;
            Description_Article_Edition.Text = Article.SubItems[1].Text;

            Prix_Unitaire_Article_Edition.Value = Decimal.Parse(Article.SubItems[5].Text);

            Quantite_Article_Edition.Value = Int32.Parse(Article.SubItems[6].Text);
        }

        private void Bouton_Validation_Click(object sender, EventArgs e)
        {
            foreach (Control Control in Controls)
            {
                Control.Focus();

                // Validate lance l'évènement 'Validating'.

                if (!Validate())
                {
                    DialogResult = DialogResult.None;

                    return;
                }
            }
        }

        private void Reference_Article_Edition_Validating(object sender, CancelEventArgs e)
        {
            if (Reference_Article_Edition.Text.Length < 6)
            {
                MessageBox.Show("La référence de l'article n'a pas ou mal été renseignée.", "Erreur", MessageBoxButtons.OK);
            }
        }

        private void Reference_Article_Edition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (String.IsNullOrEmpty(Reference_Article_Edition.Text))
                e.Handled = !(e.KeyChar == (char) Keys.F);

            else if (Reference_Article_Edition.Text.Length <= 7)
                e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8);

            else if (Reference_Article_Edition.Text.Length <= 8)
                e.Handled = !(e.KeyChar == (char)8);
        }

        private void Charger_Marques()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List <Marque> Marques = Data_Reader.Recuperer_Marques();

            foreach (Marque Marque in Marques)
            {
                Choix_Marque_Article.Items.Add(Marque);
            }

            Data_Reader.Terminer_Connection();
        }

        private void Charger_Marques(string Nom)
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List <Marque> Marques = Data_Reader.Recuperer_Marques();

            foreach (Marque Marque in Marques)
            {
                Choix_Marque_Article.Items.Add(Marque);

                if (Nom.Equals(Marque.Recuperer_Nom()))
                {
                    Choix_Marque_Article.SelectedItem = Marque;
                }
            }

            Data_Reader.Terminer_Connection();
        }

        private void Charger_Familles()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List <Famille> Familles = Data_Reader.Recuperer_Familles();

            foreach (Famille Famille in Familles)
            {
                Choix_Famille_Article.Items.Add(Famille);
            }

            Data_Reader.Terminer_Connection();
        }

        private void Charger_Familles(string Nom)
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List <Famille> Familles = Data_Reader.Recuperer_Familles();

            foreach (Famille Famille in Familles)
            {
                Choix_Famille_Article.Items.Add(Famille);

                if (Nom.Equals(Famille.Recuperer_Nom()))
                {
                    Choix_Famille_Article.SelectedItem = Famille;
                }
            }

            Data_Reader.Terminer_Connection();
        }

        private void Charger_Sous_Familles()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List <SousFamille> Sous_Familles = Data_Reader.Recuperer_Sous_Familles();

            foreach (SousFamille Sous_Famille in Sous_Familles)
            {
                Choix_Sous_Famille_Article.Items.Add(Sous_Famille);
            }

            Data_Reader.Terminer_Connection();
        }

        private void Charger_Sous_Familles(string Nom)
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<SousFamille> Sous_Familles = Data_Reader.Recuperer_Sous_Familles();

            foreach (SousFamille Sous_Famille in Sous_Familles)
            {
                Choix_Sous_Famille_Article.Items.Add(Sous_Famille);

                if (Nom.Equals(Sous_Famille.Recuperer_Nom()))
                {
                    Choix_Sous_Famille_Article.SelectedItem = Sous_Famille;
                }
            }

            Data_Reader.Terminer_Connection();
        }
    }
}