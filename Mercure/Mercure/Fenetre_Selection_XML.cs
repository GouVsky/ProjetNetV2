using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Mercure
{
    public partial class Fenetre_Selection_XML : Form
    {
        String chemin_Fichier;

        public Fenetre_Selection_XML()
        {
            InitializeComponent();
        }

        private void Fenetre_Selection_XML_Load(object sender, EventArgs e)
        {

        }

        private void Parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fenetre_Parcours = new OpenFileDialog();
            Fenetre_Parcours.ShowDialog();
            chemin_Fichier=Fenetre_Parcours.FileName.ToString();
        }

        private void Bouton_Integrer_Click(object sender, EventArgs e)
        {
            int i;
            XmlDocument my_XML_doc = new XmlDocument();
            SQLiteConnection my_database = new SQLiteConnection("Data Source=Mercure.SQLite; Version=3");
            my_database.Open();
            try
            {
                my_XML_doc.Load(chemin_Fichier);
                XmlNodeList article = my_XML_doc.GetElementsByTagName("article");

                foreach (XmlNode selectNode in article)
                {
                    string description = selectNode.SelectSingleNode("description").InnerText;
                    string refArticle = selectNode.SelectSingleNode("refArticle").InnerText;
                    string marque = selectNode.SelectSingleNode("marque").InnerText;
                    string famille = selectNode.SelectSingleNode("famille").InnerText;
                    string sousFamille = selectNode.SelectSingleNode("sousFamille").InnerText;
                    string prix = selectNode.SelectSingleNode("prixHT").InnerText;
                    Console.WriteLine(famille.ToCharArray());

                    SQLiteCommand verif_famille = new SQLiteCommand("SELECT Nom FROM Familles WHERE Nom LIKE @nomParam", my_database);
                    verif_famille.Parameters.AddWithValue("@nomParam", famille);
                    i = verif_famille.ExecuteNonQuery();
                    if (i == 0)
                    {
                        SQLiteCommand insert_Famille = new SQLiteCommand("INSERT INTO Familles (Nom) VALUES @nomParam", my_database);
                        insert_Famille.Parameters.AddWithValue("@nomParam", famille);
                        insert_Famille.ExecuteNonQuery();
                    }

                    SQLiteCommand verif_Marque = new SQLiteCommand("SELECT Nom FROM Marques WHERE Nom LIKE @nomParam", my_database);
                    verif_Marque.Parameters.AddWithValue("@nomParam", marque);
                    i = verif_Marque.ExecuteNonQuery();
                    if (i == 0)
                    {
                        SQLiteCommand insert_marque = new SQLiteCommand("INSERT INTO Marques (Nom) VALUES @nomParam", my_database);
                        insert_marque.Parameters.AddWithValue("@nomParam", marque);
                        insert_marque.ExecuteNonQuery();
                    }

                    SQLiteCommand verif_SousFamille = new SQLiteCommand("SELECT Nom FROM SousFamilles WHERE Nom LIKE @nomParam", my_database);
                    verif_SousFamille.Parameters.AddWithValue("@nomParam", sousFamille);
                    i = verif_SousFamille.ExecuteNonQuery();
                    if (i == 0)
                    {
                        SQLiteCommand insert_SousFamille = new SQLiteCommand("INSERT INTO SousFamilles (Nom) VALUES @nomParam", my_database);
                        insert_SousFamille.Parameters.AddWithValue("@nomParam", sousFamille);
                        insert_SousFamille.ExecuteNonQuery();
                    }

                    SQLiteCommand insert_Article = new SQLiteCommand("INSERT INTO Articles (Description, RefSousFamille, RefMarque, PrixHT, Quantite) VALUES @desc, @refSF, @refMarq, @prixHT, @Quantité");
                    insert_Article.Parameters.AddWithValue("@desc", description);
                    insert_Article.Parameters.AddWithValue("@refSF", sousFamille);
                    insert_Article.Parameters.AddWithValue("@refMarq", marque);
                    insert_Article.Parameters.AddWithValue("@prixHT", prix);
                    insert_Article.Parameters.AddWithValue("@Quantité", 1);
                    /*
                    descCommande.ExecuteNonQuery();
                     * */
                }

            }
            catch (Exception except)
            {
                MessageBox.Show("Erreur de lecture du fichier XML", "Erreur XML", MessageBoxButtons.OK);
            }
        }

        private void Buton_MAJ_Click(object sender, EventArgs e)
        {
            
        }
    }
}
