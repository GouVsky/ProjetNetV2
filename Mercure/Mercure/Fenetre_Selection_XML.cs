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
            
            int idMaxMarque = 0;
            int idMaxSousFamille = 0;
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

                     //////////////////////////////////////////////////////////////////////////////////////////
                     int idFamille = SqlDataReader.InsertIntoFamille(my_database, famille);
                     ///////////////////////////////////////////////////////////////////////
                     SQLiteCommand verif_Marque = new SQLiteCommand("SELECT * FROM Marques WHERE Nom LIKE @nomParam", my_database);
                     verif_Marque.Parameters.AddWithValue("@nomParam", marque);

                     if (verif_Marque.ExecuteScalar() == null)
                     {
                         SQLiteCommand Recuperer_IdMax = new SQLiteCommand("SELECT * FROM Marques ORDER BY RefMarque DESC;", my_database);
                         reader = Recuperer_IdMax.ExecuteReader();
                         reader.Read();
                         if (!reader.HasRows)
                         {
                             idMaxMarque = 0;
                         }
                         else
                         {
                             idMaxMarque = reader.GetInt32(0);
                         }

                         reader.Close();

                         SQLiteCommand insert_marque = new SQLiteCommand("INSERT INTO Marques (RefMarque, Nom) VALUES (@IdParam , @nomParam);", my_database);
                         insert_marque.Parameters.AddWithValue("@nomParam", marque);
                         insert_marque.Parameters.AddWithValue("@IdParam", idMaxMarque + 1);
                         insert_marque.ExecuteNonQuery();
                     }
                     reader = verif_Marque.ExecuteReader();
                     reader.Read();
                     int idMarque;
                     idMarque = reader.GetInt32(0);
                     //////////////////////////////////////////////////////////////////////
                     SQLiteCommand verif_SousFamille = new SQLiteCommand("SELECT * FROM SousFamilles WHERE Nom LIKE @nomParam", my_database);
                     verif_SousFamille.Parameters.AddWithValue("@nomParam", sousFamille);

                     if (verif_SousFamille.ExecuteScalar() == null)
                     {
                         SQLiteCommand Recuperer_IdMax = new SQLiteCommand("SELECT * FROM SousFamilles ORDER BY RefSousFamille DESC;", my_database);
                         reader = Recuperer_IdMax.ExecuteReader();
                         reader.Read();
                         if (!reader.HasRows)
                         {
                             idMaxSousFamille = 0;
                         }
                         else
                         {
                             idMaxSousFamille = reader.GetInt32(0);
                         }

                         reader.Close();

                         SQLiteCommand insert_SousFamille = new SQLiteCommand("INSERT INTO SousFamilles (RefSousFamille, RefFamille, Nom) VALUES (@IdParam , @familleParam, @nomParam);", my_database);
                         insert_SousFamille.Parameters.AddWithValue("@nomParam", sousFamille);
                         insert_SousFamille.Parameters.AddWithValue("@familleParam", idFamille);
                         insert_SousFamille.Parameters.AddWithValue("@IdParam", idMaxSousFamille + 1);
                         insert_SousFamille.ExecuteNonQuery();
                     }
                     reader = verif_SousFamille.ExecuteReader();
                     reader.Read();
                     int idSousFamille;
                     idSousFamille = reader.GetInt32(0);
                     //////////////////////////////////////////////////////////////////////
                     SQLiteCommand insert_Article = new SQLiteCommand("INSERT OR IGNORE INTO Articles (RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite) VALUES (@refArticle, @desc, @refSF, @refMarq, @prixHT, @Quantite); " + " UPDATE Articles SET Quantite = Quantite+1 WHERE RefArticle LIKE @RefArticle", my_database);
                     insert_Article.Parameters.AddWithValue("@refArticle", refArticle);
                     insert_Article.Parameters.AddWithValue("@desc", description);
                     insert_Article.Parameters.AddWithValue("@refSF", idSousFamille);
                     insert_Article.Parameters.AddWithValue("@refMarq", idMarque);
                     insert_Article.Parameters.AddWithValue("@prixHT", prix);
                     insert_Article.Parameters.AddWithValue("@Quantite", 0);

                     int value =insert_Article.ExecuteNonQuery();
                     
                 }
                 MessageBox.Show("Le fichier XML à été chargé avec succès dans la base de données", "Insertion réussie", MessageBoxButtons.OK);

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
