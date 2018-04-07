using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Mercure
{
    public partial class Fenetre_Principale : Form
    {
        private int Facteur_Tri = -1;

        public Fenetre_Principale()
        {
            InitializeComponent();

            Mise_A_Jour_Barre_De_Statut("Vous êtes connectés à l'application.");

            Initialiser_Liste();
        }

        public void Mise_A_Jour_Barre_De_Statut(string Message)
        {
            Barre_De_Statut_Texte.Text = Message;

            Barre_De_Statut.Refresh();
        }

        private void Menu_Fichier_Import_XML_Click(object sender, EventArgs e)
        {
            Fenetre_Selection_XML Fenetre_XML = new Fenetre_Selection_XML();

            Fenetre_XML.ShowDialog();

            // A chaque importation, on supprime ce qui existe déjà dans la liste,
            // afin d'afficher les nouvelles données.

            if (Fenetre_XML.Get_Importation_Value())
            {
                Affichage_Articles.Items.Clear();

                Remplir_Liste_Avec_Articles();
            }
        }

        private void Menu_Fichier_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ajouter_Article_Click(object sender, EventArgs e)
        {
            Fenetre_Ajout_Article Fenetre_Ajout = new Fenetre_Ajout_Article();

            DialogResult Resultat = Fenetre_Ajout.ShowDialog();

            if (Resultat == DialogResult.OK)
            {
                Mise_A_Jour_Barre_De_Statut("Vous avez ajouté un nouvel article avec succès.");
            }
        }

        private void Modifier_Article_Click(object sender, EventArgs e)
        {
            // On affiche la même fenêtre que celle pour l'ajout d'un article,
            // mais avec les champs remplis avec les informations de l'objet.

            Fenetre_Ajout_Article Fenetre_Ajout = new Fenetre_Ajout_Article(((ListView) sender).SelectedItems[0]);

            DialogResult Resultat = Fenetre_Ajout.ShowDialog();

            if (Resultat == DialogResult.OK)
            {
                Mise_A_Jour_Barre_De_Statut("Vous avez modifié un article avec succès.");
            }
        }

        private void Supprimer_Article_Click(object sender, EventArgs e)
        {
            DialogResult Resultat_Suppression = MessageBox.Show("L'article sélectionné va être supprimé. Il sera impossible de revenir en arrière. Continuer ?",
                                                                "Suppression",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Question);

            if (Resultat_Suppression == DialogResult.Yes)
            {
                for (int i = 0; i < Affichage_Articles.Items.Count; i++)
                {
                    if (Affichage_Articles.Items[i].Selected)
                        Affichage_Articles.Items[i].Remove();
                }
            }
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

        private void Affichage_Articles_KeyDown(object sender, KeyEventArgs e)
        {
            // La fenêtre de modification d'un article ne s'affiche que lorsque l'utilisateur presse la touche 'Entrée'.

            if (e.KeyCode == Keys.Enter && Affichage_Articles.SelectedItems.Count > 0)
            {
                Modifier_Article_Click(sender, e);
            }

            // Suppression d'un article.

            else if (e.KeyCode == Keys.Delete && Affichage_Articles.SelectedItems.Count > 0)
            {
                Supprimer_Article_Click(sender, e);
            }

            // Recharge de la liste des articles.

            else if (e.KeyCode == Keys.F5)
            {
                Affichage_Articles.Refresh();
            }
        }

        private void Affichage_Articles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Affichage_Articles.SelectedItems.Count > 0)
            {
                Modifier_Article_Click(sender, e);
            }
        }

        private void Affichage_Articles_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu Menu_Contextuel = new ContextMenu();

            // Affichage d'un menu contextuel lors du clic droit de la souris.
            // Si aucun article n'est sélectionné, l'utilisateur ne pourra que faire l'action "Ajouter".
            // Dans le cas contraire, les deux actions "Modifier" et "Supprimer" s'ajoutent.

            if (e.Button == MouseButtons.Right)
            {
                Menu_Contextuel.MenuItems.Add("Ajouter un article", new EventHandler(Ajouter_Article_Click));
                Menu_Contextuel.MenuItems.Add("Modifier l'article sélectionné", new EventHandler(Modifier_Article_Click));
                Menu_Contextuel.MenuItems.Add("Supprimer l'article sélectionné", new EventHandler(Supprimer_Article_Click));

                Affichage_Articles.ContextMenu = Menu_Contextuel;
            }
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
            SQLiteConnection Connection = new SQLiteConnection("Data Source=Resources\\Mercure.SQLite; Version=3");

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

                string[] Donnees = { Convert.ToString(Lecture_Table_Article[0]),                    // RefArticle.
                                     Convert.ToString(Lecture_Table_Article[1]),                    // Description.
                                     Nom_Sous_Famille,                                              // Sous-Famille.
                                     Nom_Famille,                                                   // Famille.
                                     Nom_Marque,                                                    // Marque.
                                     Lecture_Table_Article.GetString(4),                            // Prix HT.
                                     Convert.ToString(Lecture_Table_Article[5])                     // Quantite.
                                   };

                ListViewItem Article = new ListViewItem(Donnees);

                Affichage_Articles.Items.Add(Article);

                Lecture_Table_Sous_Famille.Close();

                Lecture_Table_Marque.Close();
            }

            Lecture_Table_Article.Close();

            Connection.Close();
        }
    }
}