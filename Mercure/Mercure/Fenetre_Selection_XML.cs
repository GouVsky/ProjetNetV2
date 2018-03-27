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
     
             SQLiteDataReader reader;
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


                     SQLiteCommand verif_famille = new SQLiteCommand("SELECT * FROM Familles WHERE Nom LIKE @nomParam", my_database);
                     verif_famille.Parameters.AddWithValue("@nomParam", famille);
                     reader = verif_famille.ExecuteReader();
                     reader.Read();
                     if (reader == null)
                     {
                         SQLiteCommand insert_Famille = new SQLiteCommand("INSERT INTO Familles (Nom) VALUES @nomParam", my_database);
                         insert_Famille.Parameters.AddWithValue("@nomParam", famille);
                         insert_Famille.ExecuteNonQuery();
                     }
                     reader.Close();
                     reader = verif_famille.ExecuteReader();
                     reader.Read();
                     int idFamilles;
                     idFamilles = reader.GetInt32(0);


                     SQLiteCommand verif_Marque = new SQLiteCommand("SELECT * FROM Marques WHERE Nom LIKE @nomParam", my_database);
                     verif_Marque.Parameters.AddWithValue("@nomParam", marque);
                     reader = verif_Marque.ExecuteReader();
                     if (reader == null)
                     {
                         SQLiteCommand insert_marque = new SQLiteCommand("INSERT INTO Marques (Nom) VALUES @nomParam", my_database);
                         insert_marque.Parameters.AddWithValue("@nomParam", marque);
                         insert_marque.ExecuteNonQuery();
                     }
                     reader = verif_Marque.ExecuteReader();
                     int idMarque;
                     idMarque = reader.GetInt32(0);

                     SQLiteCommand verif_SousFamille = new SQLiteCommand("SELECT * FROM SousFamilles WHERE Nom LIKE @nomParam", my_database);
                     verif_SousFamille.Parameters.AddWithValue("@nomParam", sousFamille);
                     reader = verif_SousFamille.ExecuteReader();
                     if (reader == null)
                     {
                         SQLiteCommand insert_SousFamille = new SQLiteCommand("INSERT INTO SousFamilles (Nom) VALUES @nomParam", my_database);
                         insert_SousFamille.Parameters.AddWithValue("@nomParam", sousFamille);
                         insert_SousFamille.ExecuteNonQuery();
                     }
                     reader = verif_SousFamille.ExecuteReader();
                     int idSousFamille;
                     idSousFamille = reader.GetInt32(0);

                     SQLiteCommand insert_Article = new SQLiteCommand("INSERT INTO Articles (RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite) VALUES @refArticle @desc, @refSF, @refMarq, @prixHT, @Quantité ON DUPLICATE KEY UPDATE Quantite = Quantite+1");
                     insert_Article.Parameters.AddWithValue("@desc", description);
                     insert_Article.Parameters.AddWithValue("@refSF", idSousFamille);
                     insert_Article.Parameters.AddWithValue("@refMarq", idMarque);
                     insert_Article.Parameters.AddWithValue("@prixHT", prix);
                     insert_Article.Parameters.AddWithValue("@Quantite", 1);

                     insert_Article.ExecuteNonQuery();
                     
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
