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
    }
}