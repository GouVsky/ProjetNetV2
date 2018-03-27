using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    public partial class Fenetre_Principale : Form
    {
        public Fenetre_Principale()
        {
            InitializeComponent();
        }

        private void Mercure_Load(object sender, EventArgs e)
        {

        }

        private void Menu_Fichier_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Fichier_Import_XML_Click(object sender, EventArgs e)
        {
            Fenetre_Selection_XML fen = new Fenetre_Selection_XML();
            fen.ShowDialog();

            Remplir_Liste_Avec_Articles();

        }

        private void Menu_Fichier_Quitter_Click(object sender, EventArgs e)
        {

        }

        private void Barre_De_Statut_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Affichage_Articles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Remplir_Liste_Avec_Articles()
        {

            SQLiteConnection Connection = new SQLiteConnection("Data Source=Mercure.SQLite; Version=3");
            Connection.Open();

            SQLiteCommand Requete = new SQLiteCommand("SELECT * FROM Articles;", Connection);
            SQLiteDataReader Lecture_Base_De_Donnees = Requete.ExecuteReader();

            while (Lecture_Base_De_Donnees.Read())
            {
                ListViewItem RefArticle = new ListViewItem(Convert.ToString(Lecture_Base_De_Donnees[0]));
                ListViewItem Description = new ListViewItem(Convert.ToString(Lecture_Base_De_Donnees[1]));
                ListViewItem RefSousFamille = new ListViewItem(Convert.ToString(Lecture_Base_De_Donnees[2]));
                ListViewItem RefMarque = new ListViewItem(Convert.ToString(Lecture_Base_De_Donnees[3]));
                ListViewItem PrixHT = new ListViewItem(Convert.ToString(Lecture_Base_De_Donnees[4]));
                ListViewItem Quantite = new ListViewItem(Convert.ToString(Lecture_Base_De_Donnees[5]));

                Affichage_Articles.Items.Add(RefArticle);
            }

            Connection.Close();
        }
    }
}