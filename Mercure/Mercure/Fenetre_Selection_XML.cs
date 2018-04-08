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
        bool Importation = false;

        String Chemin_Fichier = "";

        public Fenetre_Selection_XML()
        {
            InitializeComponent();
        }

        private void Fenetre_Selection_XML_Load(object sender, EventArgs e)
        {
            Chemin_Fichier = "";
        }

        private void Parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fenetre_Parcours = new OpenFileDialog();
            Fenetre_Parcours.ShowDialog();

            Chemin_Fichier = Fenetre_Parcours.FileName.ToString();

            Affichage_Chemin_Fichier_XML.Text = Chemin_Fichier;
        }

        private void Bouton_Integrer_Click(object sender, EventArgs e)
        {
            Importation = true;

            bool Effacer_BDD = true;
            DialogResult result = MessageBox.Show("Attention, vous êtes sur le point d'écraser la base de donnée existante.", "Attention", MessageBoxButtons.OKCancel);
            if(result == DialogResult.Cancel)
            {
                    
            }
            if(result == DialogResult.OK)
            {
                Fonction_Lecture_XML(Effacer_BDD);
            }
            
        }

        private void Buton_MAJ_Click(object sender, EventArgs e)
        {
            Importation = true;

            bool Effacer_BDD = false;
            Fonction_Lecture_XML(Effacer_BDD);
        }

        private void Fonction_Lecture_XML(bool Effacer_BDD)
        {
            Bar_Chargement_XML.Visible = true;
            Bar_Chargement_XML.Minimum = 0;
            Bar_Chargement_XML.Value = 0;
            Bar_Chargement_XML.Step = 1;
            int nbre_donnee = 0;
            XmlDocument my_XML_doc = new XmlDocument();

            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            try
            {
                if (Effacer_BDD)
                {
                    Data_Reader.Purger_BDD();
                }

                my_XML_doc.Load(Chemin_Fichier);
                XmlNodeList article = my_XML_doc.GetElementsByTagName("article");
                
                Bar_Chargement_XML.Maximum = article.Count;
                foreach (XmlNode selectNode in article)
                {
                    string description = selectNode.SelectSingleNode("description").InnerText;
                    string refArticle = selectNode.SelectSingleNode("refArticle").InnerText;
                    string marque = selectNode.SelectSingleNode("marque").InnerText;
                    string famille = selectNode.SelectSingleNode("famille").InnerText;
                    string sousFamille = selectNode.SelectSingleNode("sousFamille").InnerText;
                    string prix = selectNode.SelectSingleNode("prixHT").InnerText;

                    //////////////////////////////////////////////////////////////////////////////////////////
                    int idFamille = Data_Reader.InsertIntoFamille(famille);
                    ///////////////////////////////////////////////////////////////////////
                    int idMarque = Data_Reader.Inserer_Marque(marque);
                    //////////////////////////////////////////////////////////////////////
                    int idSousFamille = Data_Reader.Inserer_Sous_Famille(sousFamille, idFamille);
                    //////////////////////////////////////////////////////////////////////
                    int value = Data_Reader.Inserer_Article(refArticle, description, idSousFamille, idMarque, prix);

                    nbre_donnee++;
                    Bar_Chargement_XML.PerformStep();
                }
                MessageBox.Show("Le fichier XML à été chargé avec succès dans la base de données. " + nbre_donnee + " données ont été chargées." , "Insertion réussie", MessageBoxButtons.OK);

            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de lecture du fichier XML", "Erreur XML", MessageBoxButtons.OK);
            }

            Data_Reader.Terminer_Connection();
        }

        public bool Get_Importation_Value()
        {
            return Importation;
        }
    }
}
