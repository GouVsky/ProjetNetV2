﻿using System;
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
    public class iSqlDataReader
    {
        public static int InsertIntoFamille(SQLiteConnection my_database, string famille)
        {
            SQLiteDataReader reader;
            int idMaxFamille = 0;

            SQLiteCommand verif_famille = new SQLiteCommand("SELECT * FROM Familles WHERE Nom LIKE @nomParam", my_database);
            verif_famille.Parameters.AddWithValue("nomParam", famille);

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