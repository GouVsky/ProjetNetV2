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
