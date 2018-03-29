﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            // Tri des colonnes.

            Affichage_Articles.ListViewItemSorter = new List_View_Comparateur_Items();
        }

        public void Remplir_Liste_Avec_Articles()
        {
            SQLiteConnection Connection = new SQLiteConnection("Data Source=Mercure.SQLite; Version=3");

            Connection.Open();


            SQLiteDataReader Lecture_Table_Article = SqlDataReader.Recuperer_Articles(Connection);

            while (Lecture_Table_Article.Read())
            {
                string Nom_Famille = "-";
                string Nom_Marque = "-";

                SQLiteDataReader Lecture_Table_Famille = SqlDataReader.Recuperer_Famille(Connection, Convert.ToInt16(Lecture_Table_Article[2]));

                SQLiteDataReader Lecture_Table_Marque = SqlDataReader.Recuperer_Marque(Connection, Convert.ToInt16(Lecture_Table_Article[3]));

                if (Lecture_Table_Famille.Read())
                {
                    Nom_Famille = Convert.ToString(Lecture_Table_Famille[1]);
                }

                if (Lecture_Table_Marque.Read())
                {
                    Nom_Marque = Convert.ToString(Lecture_Table_Marque[1]);
                }

                string[] Donnees = { Convert.ToString(Lecture_Table_Article[0]), // RefArticle.
                                     Convert.ToString(Lecture_Table_Article[1]), // Description.
                                     Nom_Famille,                                // RefSousFamille.
                                     Nom_Marque,                                 // RefMarque
                                     Convert.ToString(Lecture_Table_Article[4]), // PrixHT
                                     Convert.ToString(Lecture_Table_Article[5])  // Quantite
                                   };

                ListViewItem Article = new ListViewItem(Donnees);

                Affichage_Articles.Items.Add(Article);

                Lecture_Table_Famille.Close();

                Lecture_Table_Marque.Close();
            }

            Lecture_Table_Article.Close();

            Connection.Close();
        }

        private void Affichage_Articles_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            List_View_Comparateur_Items Comparaison = (List_View_Comparateur_Items) Affichage_Articles.ListViewItemSorter;

            if (e.Column == Comparaison.Colonne)
            {
                Comparaison.Tri = Swap(Comparaison.Tri);
            }
            else
            {
                Comparaison.Tri = SortOrder.Ascending;
            }

            Comparaison.Colonne = e.Column;
            Affichage_Articles.Sort();
        }

        private SortOrder Swap(SortOrder tri)
        {
            throw new NotImplementedException();
        }
    }
}