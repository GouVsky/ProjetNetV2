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

            Initialiser_Liste();
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

        public void Initialiser_Liste()
        {
            int Nombre_Colonnes = 6;
            int Taille_Liste = Affichage_Articles.Width;
            int Taille_Colonne = Taille_Liste / Nombre_Colonnes;

            // On définit la taille de la dernière colonne.
            // La taille de la ListeView n'est pas forcément un multiple du nombre de colonnes.

            int Taille_Derniere_Colonne = Taille_Liste - (Nombre_Colonnes - 1) * Taille_Colonne;

            Affichage_Articles.Columns.Add("RefArticle", Taille_Colonne, HorizontalAlignment.Left);
            Affichage_Articles.Columns.Add("Description", Taille_Colonne, HorizontalAlignment.Left);
            Affichage_Articles.Columns.Add("RefSousFamille", Taille_Colonne, HorizontalAlignment.Left);
            Affichage_Articles.Columns.Add("RefMarque", Taille_Colonne, HorizontalAlignment.Left);
            Affichage_Articles.Columns.Add("PrixHT", Taille_Colonne, HorizontalAlignment.Left);
            Affichage_Articles.Columns.Add("Quantite", Taille_Derniere_Colonne, HorizontalAlignment.Left);
        }

        public void Remplir_Liste_Avec_Articles()
        {
            SQLiteConnection Connection = new SQLiteConnection("Data Source=Mercure.SQLite; Version=3");
            Connection.Open();

            SQLiteCommand Requete = new SQLiteCommand("SELECT * FROM Articles;", Connection);
            SQLiteDataReader Lecture_Base_De_Donnees = Requete.ExecuteReader();

            while (Lecture_Base_De_Donnees.Read())
            {
                string[] Donnees = { Convert.ToString(Lecture_Base_De_Donnees[0]), // RefArticle.
                                     Convert.ToString(Lecture_Base_De_Donnees[1]), // Description.
                                     Convert.ToString(Lecture_Base_De_Donnees[2]), // RefSousFamille.
                                     Convert.ToString(Lecture_Base_De_Donnees[3]), // RefMarque
                                     Convert.ToString(Lecture_Base_De_Donnees[4]), // PrixHT
                                     Convert.ToString(Lecture_Base_De_Donnees[5])  // Quantite
                                    };

                ListViewItem Article = new ListViewItem(Donnees);

                Affichage_Articles.Items.Add(Article);
            }

            Connection.Close();
        }
    }
}