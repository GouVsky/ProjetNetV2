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
    public class SqlDataReader
    {
        private static SqlDataReader Data_Reader;
        private static SQLiteConnection Connection;

        private SqlDataReader()
        {
            Connection = new SQLiteConnection("Data Source=Resources\\Mercure.SQLite; Version=3");
        }

        public static SqlDataReader Ouvrir_Connection()
        {
            if (Data_Reader == null)
                Data_Reader = new SqlDataReader();

            Connection.Open();

            return Data_Reader;
        }

        public void Terminer_Connection()
        {
            Connection.Close();
        }

        public List <Article> Recuperer_Articles()
        {
            List <Article> Articles = new List <Article> ();

            SQLiteCommand Requete_Article = new SQLiteCommand("SELECT * FROM Articles;", Connection);

            SQLiteDataReader Lecture_Table_Article = Requete_Article.ExecuteReader();

            while (Lecture_Table_Article.Read())
            {
                SousFamille Sous_Famille = Recuperer_Sous_Famille(Convert.ToInt16(Lecture_Table_Article[2]));

                Marque Marque = Recuperer_Marque(Convert.ToInt16(Lecture_Table_Article[3]));


                Articles.Add(new Article(Convert.ToString(Lecture_Table_Article[0]),
                                         Convert.ToString(Lecture_Table_Article[1]),
                                         Sous_Famille,
                                         Marque,
                                         Convert.ToDouble(Lecture_Table_Article.GetString(4)),
                                         Convert.ToInt32(Lecture_Table_Article[5])
                                         ));
            }

            Lecture_Table_Article.Close();

            return Articles;
        }

        public Famille Recuperer_Famille(int Id_Famille)
        {
            SQLiteCommand Requete_Famille = new SQLiteCommand("SELECT * FROM Familles WHERE @Id_Famille == RefFamille;", Connection);

            Requete_Famille.Parameters.AddWithValue("@Id_Famille", Id_Famille);

            SQLiteDataReader Lecture_Table_Famille = Requete_Famille.ExecuteReader();

            Lecture_Table_Famille.Read();

            Famille Famille = new Famille(Convert.ToString(Lecture_Table_Famille[0]), Convert.ToString(Lecture_Table_Famille[1]));

            Lecture_Table_Famille.Close();

            return Famille;
        }

        public SousFamille Recuperer_Sous_Famille(int Id_Sous_Famille)
        {
            SQLiteCommand Requete_Sous_Famille = new SQLiteCommand("SELECT * FROM SousFamilles WHERE @Id_Sous_Famille == RefSousFamille;", Connection);

            Requete_Sous_Famille.Parameters.AddWithValue("@Id_Sous_Famille", Id_Sous_Famille);

            SQLiteDataReader Lecture_Table_Sous_Famille = Requete_Sous_Famille.ExecuteReader();

            Lecture_Table_Sous_Famille.Read();

            SousFamille Sous_Famille = new SousFamille(Convert.ToInt32(Lecture_Table_Sous_Famille[0]),
                                                       Convert.ToString(Lecture_Table_Sous_Famille[2]),
                                                       Recuperer_Famille(Convert.ToInt32(Lecture_Table_Sous_Famille[1])));

            return Sous_Famille;
        }

        public Marque Recuperer_Marque(int Id_Marque)
        {
            SQLiteCommand Requete_Marque = new SQLiteCommand("SELECT * FROM Marques WHERE @Id_Marque == RefMarque;", Connection);

            Requete_Marque.Parameters.AddWithValue("@Id_Marque", Id_Marque);

            SQLiteDataReader Lecture_Table_Marque = Requete_Marque.ExecuteReader();

            Lecture_Table_Marque.Read();

            Marque Marque = new Marque(Convert.ToInt32(Lecture_Table_Marque[0]), Convert.ToString(Lecture_Table_Marque[1]));

            Lecture_Table_Marque.Close();

            return Marque;
        }

        public List <Marque> Recuperer_Marques()
        {
            List <Marque> Marques = new List <Marque> ();

            SQLiteCommand Requete_Marques = new SQLiteCommand("SELECT * FROM Marques;", Connection);

            SQLiteDataReader Lecture_Table_Marque = Requete_Marques.ExecuteReader();

            while (Lecture_Table_Marque.Read())
            {
                Marques.Add(new Marque(Convert.ToInt32(Lecture_Table_Marque[0]), Convert.ToString(Lecture_Table_Marque[1])));
            }

            Lecture_Table_Marque.Close();

            return Marques;
        }

        public int InsertIntoFamille(string Famille)
        {

            SQLiteDataReader Lecture;
            int Id_Max_Famille = 0;

            SQLiteCommand Verif_famille = new SQLiteCommand("SELECT * FROM Familles WHERE Nom LIKE @nomParam", Connection);
            Verif_famille.Parameters.AddWithValue("@nomParam", Famille);

            if (Verif_famille.ExecuteScalar() == null)
            {
                SQLiteCommand Recuperer_Id_Max = new SQLiteCommand("SELECT * FROM Familles ORDER BY RefFamille DESC;", Connection);
                Lecture = Recuperer_Id_Max.ExecuteReader();
                Lecture.Read();
                if (!Lecture.HasRows)
                {
                    Id_Max_Famille = 0;
                }
                else
                {
                    Id_Max_Famille = Lecture.GetInt32(0);
                }

                Lecture.Close();

                SQLiteCommand Inserer_Famille = new SQLiteCommand("INSERT INTO Familles (RefFamille, Nom) VALUES (@IdParam , @nomParam);", Connection);
                Inserer_Famille.Parameters.AddWithValue("@nomParam", Famille);
                Inserer_Famille.Parameters.AddWithValue("@IdParam", Id_Max_Famille + 1);
                Inserer_Famille.ExecuteNonQuery();
            }
            Lecture = Verif_famille.ExecuteReader();
            Lecture.Read();
            int Id_Familles;
            Id_Familles = Lecture.GetInt32(0);
            return Id_Familles;
        }

        public int Inserer_Marque(string Marque)
        {
            SQLiteDataReader Lecture;
            int Id_Max_Marque;
            SQLiteCommand Verif_Marque = new SQLiteCommand("SELECT * FROM Marques WHERE Nom LIKE @nomParam", Connection);
            Verif_Marque.Parameters.AddWithValue("@nomParam", Marque);

            if (Verif_Marque.ExecuteScalar() == null)
            {
                SQLiteCommand Recuperer_IdMax = new SQLiteCommand("SELECT * FROM Marques ORDER BY RefMarque DESC;", Connection);
                Lecture = Recuperer_IdMax.ExecuteReader();
                Lecture.Read();
                if (!Lecture.HasRows)
                {
                    Id_Max_Marque = 0;
                }
                else
                {
                    Id_Max_Marque = Lecture.GetInt32(0);
                }

                Lecture.Close();

                SQLiteCommand Inserer_Marque = new SQLiteCommand("INSERT INTO Marques (RefMarque, Nom) VALUES (@IdParam , @nomParam);", Connection);
                Inserer_Marque.Parameters.AddWithValue("@nomParam", Marque);
                Inserer_Marque.Parameters.AddWithValue("@IdParam", Id_Max_Marque + 1);
                Inserer_Marque.ExecuteNonQuery();
            }
            Lecture = Verif_Marque.ExecuteReader();
            Lecture.Read();
            int Id_Marque;
            Id_Marque = Lecture.GetInt32(0);
            return Id_Marque;
        }

        public int Inserer_Sous_Famille(string Sous_Famille, int Id_Famille)
        {
            SQLiteDataReader Lecture;
            int Id_Max_Sous_Famille;
            SQLiteCommand Verif_Sous_Famille = new SQLiteCommand("SELECT * FROM SousFamilles WHERE Nom LIKE @nomParam", Connection);
            Verif_Sous_Famille.Parameters.AddWithValue("@nomParam", Sous_Famille);

            if (Verif_Sous_Famille.ExecuteScalar() == null)
            {
                SQLiteCommand Recuperer_IdMax = new SQLiteCommand("SELECT * FROM SousFamilles ORDER BY RefSousFamille DESC;", Connection);
                Lecture = Recuperer_IdMax.ExecuteReader();
                Lecture.Read();
                if (!Lecture.HasRows)
                {
                    Id_Max_Sous_Famille = 0;
                }
                else
                {
                    Id_Max_Sous_Famille = Lecture.GetInt32(0);
                }

                Lecture.Close();

                SQLiteCommand Inserer_Sous_Famille = new SQLiteCommand("INSERT INTO SousFamilles (RefSousFamille, RefFamille, Nom) VALUES (@IdParam , @familleParam, @nomParam);", Connection);
                Inserer_Sous_Famille.Parameters.AddWithValue("@nomParam", Sous_Famille);
                Inserer_Sous_Famille.Parameters.AddWithValue("@familleParam", Id_Famille);
                Inserer_Sous_Famille.Parameters.AddWithValue("@IdParam", Id_Max_Sous_Famille + 1);
                Inserer_Sous_Famille.ExecuteNonQuery();
            }
            Lecture = Verif_Sous_Famille.ExecuteReader();
            Lecture.Read();
            int Id_Sous_Famille;
            Id_Sous_Famille = Lecture.GetInt32(0);
            return Id_Sous_Famille;
        }

        public int Inserer_Article(string Ref_Article, string Description, int Id_Sous_Famille, int Id_Marque, string Prix)
        {
            int Valeur=-1;
            SQLiteCommand Verif_Article = new SQLiteCommand("SELECT * FROM Articles WHERE RefArticle LIKE @refArticle", Connection);
            Verif_Article.Parameters.AddWithValue("@refArticle", Ref_Article);

            if (Verif_Article.ExecuteScalar() == null)
            {
                SQLiteCommand insert_Article = new SQLiteCommand("INSERT INTO Articles (RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite) VALUES (@refArticle, @desc, @refSF, @refMarq, @prixHT, @Quantite); ", Connection);
                insert_Article.Parameters.AddWithValue("@refArticle", Ref_Article);
                insert_Article.Parameters.AddWithValue("@desc", Description);
                insert_Article.Parameters.AddWithValue("@refSF", Id_Sous_Famille);
                insert_Article.Parameters.AddWithValue("@refMarq", Id_Marque);
                insert_Article.Parameters.AddWithValue("@prixHT", Prix);
                insert_Article.Parameters.AddWithValue("@Quantite", 1);
                Valeur = insert_Article.ExecuteNonQuery();
            }
            else
            {
                SQLiteCommand Mise_A_Jour_Article = new SQLiteCommand("UPDATE Articles SET Quantite = Quantite+1 WHERE RefArticle LIKE @RefArticle", Connection);
                Mise_A_Jour_Article.Parameters.AddWithValue("@RefArticle", Ref_Article);
                Valeur = Mise_A_Jour_Article.ExecuteNonQuery();
            }
            
            return Valeur;
        }

        public void Purger_BDD()
        {
            SQLiteCommand Purger_Tables = new SQLiteCommand("DELETE FROM Familles; " +
                                                            "DELETE FROM Marques; " +
                                                            "DELETE FROM SousFamilles;" +
                                                            "DELETE FROM Articles;" +
                                                            "VACUUM", Connection);
            Purger_Tables.ExecuteNonQuery();
        }
    }
}