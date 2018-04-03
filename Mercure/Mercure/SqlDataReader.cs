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
        public static SQLiteDataReader Recuperer_Articles(SQLiteConnection Connection)
        {
            SQLiteCommand Requete_Article = new SQLiteCommand("SELECT * FROM Articles;", Connection);

            SQLiteDataReader Lecture_Table_Article = Requete_Article.ExecuteReader();

            return Lecture_Table_Article;
        }

        public static SQLiteDataReader Recuperer_Sous_Famille(SQLiteConnection Connection, int Id_Sous_Famille)
        {
            SQLiteCommand Requete_Sous_Famille = new SQLiteCommand("SELECT * FROM SousFamilles WHERE @Id_Sous_Famille == RefSousFamille;", Connection);

            Requete_Sous_Famille.Parameters.AddWithValue("@Id_Sous_Famille", Id_Sous_Famille);

            SQLiteDataReader Lecture_Table_Sous_Famille = Requete_Sous_Famille.ExecuteReader();

            return Lecture_Table_Sous_Famille;
        }

        public static SQLiteDataReader Recuperer_Famille(SQLiteConnection Connection, int Id_Famille)
        {
            SQLiteCommand Requete_Famille = new SQLiteCommand("SELECT * FROM Familles WHERE @Id_Famille == RefFamille;", Connection);

            Requete_Famille.Parameters.AddWithValue("@Id_Famille", Id_Famille);

            SQLiteDataReader Lecture_Table_Famille = Requete_Famille.ExecuteReader();

            return Lecture_Table_Famille;
        }

        public static SQLiteDataReader Recuperer_Marque(SQLiteConnection Connection, int Id_Marque)
        {
            SQLiteCommand Requete_Marque = new SQLiteCommand("SELECT * FROM Marques WHERE @Id_Marque == RefMarque;", Connection);

            Requete_Marque.Parameters.AddWithValue("@Id_Marque", Id_Marque);

            SQLiteDataReader Lecture_Table_Marque = Requete_Marque.ExecuteReader();

            return Lecture_Table_Marque;
        }

        public static int InsertIntoFamille(SQLiteConnection Connection, string Famille)
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

        public static int Inserer_Marque(SQLiteConnection Connection, string Marque)
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

        public static int Inserer_Sous_Famille(SQLiteConnection Connection, string Sous_Famille, int Id_Famille)
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

        public static int Inserer_Article(SQLiteConnection Connection, string Ref_Article, string Description, int Id_Sous_Famille, int Id_Marque, string Prix)
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

        public static void Purger_BDD(SQLiteConnection Connection)
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