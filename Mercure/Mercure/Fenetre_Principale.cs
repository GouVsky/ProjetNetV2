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
        private int Facteur_Tri = -1;

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

        private void Affichage_Articles_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != Facteur_Tri)
            {
                Facteur_Tri = e.Column;

                // Par défaut, le tri se fait dans l'ordre croissant.

                Affichage_Articles.Sorting = SortOrder.Ascending;
            }

            else
            {
                // On change le type de tri un coup sur deux.

                if (Affichage_Articles.Sorting == SortOrder.Ascending)
                    Affichage_Articles.Sorting = SortOrder.Descending;

                else
                    Affichage_Articles.Sorting = SortOrder.Ascending;
            }

            Affichage_Articles.ListViewItemSorter = new List_View_Comparateur_Items(e.Column, Affichage_Articles.Sorting);

            Affichage_Articles.Sort();
        }

        public void Initialiser_Liste()
        {
            int Nombre_Colonnes = 7;
            int Taille_Liste = Affichage_Articles.Width;
            int Taille_Colonne = Taille_Liste / Nombre_Colonnes;

            Affichage_Articles.Items.RemoveAt(0);

            // On définit la taille de la dernière colonne.
            // La taille de la ListeView n'est pas forcément un multiple du nombre de colonnes.

            int Taille_Derniere_Colonne = Taille_Liste - (Nombre_Colonnes - 1) * Taille_Colonne;

            Affichage_Articles.Columns.Add("RefArticle", Taille_Colonne, HorizontalAlignment.Left);
            Affichage_Articles.Columns.Add("Description", Taille_Colonne, HorizontalAlignment.Left);
            Affichage_Articles.Columns.Add("Sous-Famille", Taille_Colonne, HorizontalAlignment.Left);
            Affichage_Articles.Columns.Add("Famille", Taille_Colonne, HorizontalAlignment.Left);
            Affichage_Articles.Columns.Add("Marque", Taille_Colonne, HorizontalAlignment.Left);
            Affichage_Articles.Columns.Add("Prix HT", Taille_Colonne, HorizontalAlignment.Left);
            Affichage_Articles.Columns.Add("Quantite", Taille_Derniere_Colonne, HorizontalAlignment.Left);

            // Tri des colonnes.

            Affichage_Articles.ColumnClick += new ColumnClickEventHandler(Affichage_Articles_ColumnClick);
        }

        public void Remplir_Liste_Avec_Articles()
        {
            SQLiteConnection Connection = new SQLiteConnection("Data Source=Mercure.SQLite; Version=3");

            Connection.Open();


            SQLiteDataReader Lecture_Table_Article = SqlDataReader.Recuperer_Articles(Connection);

            while (Lecture_Table_Article.Read())
            {
                string Nom_Sous_Famille = "-";
                string Nom_Famille = "-";
                string Nom_Marque = "-";

                SQLiteDataReader Lecture_Table_Sous_Famille = SqlDataReader.Recuperer_Sous_Famille(Connection, Convert.ToInt16(Lecture_Table_Article[2]));

                SQLiteDataReader Lecture_Table_Marque = SqlDataReader.Recuperer_Marque(Connection, Convert.ToInt16(Lecture_Table_Article[3]));

                // On récupère la sous-famille et la famille de l'article.

                if (Lecture_Table_Sous_Famille.Read())
                {
                    Nom_Sous_Famille = Convert.ToString(Lecture_Table_Sous_Famille[2]);

                    SQLiteDataReader Lecture_Table_Famille = SqlDataReader.Recuperer_Famille(Connection, Convert.ToInt16(Lecture_Table_Sous_Famille[1]));

                    if (Lecture_Table_Famille.Read())
                        Nom_Famille = Convert.ToString(Lecture_Table_Famille[1]);

                    Lecture_Table_Famille.Close();
                }

                // On récupère la marque de l'article.

                if (Lecture_Table_Marque.Read())
                    Nom_Marque = Convert.ToString(Lecture_Table_Marque[1]);

                string[] Donnees = { Convert.ToString(Lecture_Table_Article[0]), // RefArticle.
                                     Convert.ToString(Lecture_Table_Article[1]), // Description.
                                     Nom_Sous_Famille,                           // Sous-Famille.
                                     Nom_Famille,                                // Famille.
                                     Nom_Marque,                                 // Marque.
                                     Convert.ToString(Lecture_Table_Article[4]), // Prix HT.
                                     Convert.ToString(Lecture_Table_Article[5])  // Quantite.
                                   };

                ListViewItem Article = new ListViewItem(Donnees);

                Affichage_Articles.Items.Add(Article);

                Lecture_Table_Sous_Famille.Close();

                Lecture_Table_Marque.Close();
            }

            Lecture_Table_Article.Close();

            Connection.Close();
        }

        private SortOrder Swap(SortOrder tri)
        {
            throw new NotImplementedException();
        }
    }
}