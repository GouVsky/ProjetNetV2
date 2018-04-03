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

        public static int InsertIntoFamille(SQLiteConnection my_database, string famille)
        {

            SQLiteDataReader reader;
            int idMaxFamille = 0;

            SQLiteCommand verif_famille = new SQLiteCommand("SELECT * FROM Familles WHERE Nom LIKE @nomParam", my_database);
            verif_famille.Parameters.AddWithValue("@nomParam", famille);

            if (verif_famille.ExecuteScalar() == null)
            {
                SQLiteCommand Recuperer_IdMax = new SQLiteCommand("SELECT * FROM Familles ORDER BY RefFamille DESC;", my_database);
                reader = Recuperer_IdMax.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                    idMaxFamille = 0;
                }
                else
                {
                    idMaxFamille = reader.GetInt32(0);
                }

                reader.Close();

                SQLiteCommand insert_Famille = new SQLiteCommand("INSERT INTO Familles (RefFamille, Nom) VALUES (@IdParam , @nomParam);", my_database);
                insert_Famille.Parameters.AddWithValue("@nomParam", famille);
                insert_Famille.Parameters.AddWithValue("@IdParam", idMaxFamille + 1);
                insert_Famille.ExecuteNonQuery();
            }
            reader = verif_famille.ExecuteReader();
            reader.Read();
            int idFamilles;
            idFamilles = reader.GetInt32(0);
            return idFamilles;
        }

        public static int InsertIntoMarque(SQLiteConnection my_database, string marque)
        {
            SQLiteDataReader reader;
            int idMaxMarque;
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
            return idMarque;
        }

        public static int InsertIntoSousFamille(SQLiteConnection my_database, string sousFamille, int idFamille)
        {
            SQLiteDataReader reader;
            int idMaxSousFamille;
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
            return idSousFamille;
        }

        public static int InsertIntoArticle(SQLiteConnection my_database, string refArticle, string description, int idSousFamille, int idMarque, string prix)
        {
            int value=-1;
            SQLiteCommand verif_Article = new SQLiteCommand("SELECT * FROM Articles WHERE RefArticle LIKE @refArticle", my_database);
            verif_Article.Parameters.AddWithValue("@refArticle", refArticle);

            if (verif_Article.ExecuteScalar() == null)
            {
                SQLiteCommand insert_Article = new SQLiteCommand("INSERT INTO Articles (RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite) VALUES (@refArticle, @desc, @refSF, @refMarq, @prixHT, @Quantite); ", my_database);
                insert_Article.Parameters.AddWithValue("@refArticle", refArticle);
                insert_Article.Parameters.AddWithValue("@desc", description);
                insert_Article.Parameters.AddWithValue("@refSF", idSousFamille);
                insert_Article.Parameters.AddWithValue("@refMarq", idMarque);
                insert_Article.Parameters.AddWithValue("@prixHT", prix);
                insert_Article.Parameters.AddWithValue("@Quantite", 0);
                value = insert_Article.ExecuteNonQuery();
            }
            else
            {
                SQLiteCommand update_Article = new SQLiteCommand("UPDATE Articles SET Quantite = Quantite+1 WHERE RefArticle LIKE @RefArticle", my_database);
                update_Article.Parameters.AddWithValue("@RefArticle", refArticle);
                value = update_Article.ExecuteNonQuery();
            }
            
            return value;
        }
    }
}