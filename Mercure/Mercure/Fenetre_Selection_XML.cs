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
using System.Globalization;

namespace Mercure
{
    public partial class Fenetre_Selection_XML : Form
    {
        bool Importation = false;
        public static string separateurRegion = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        String Chemin_Fichier = "";

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Fenetre_Selection_XML"/>.
        /// </summary>
        public Fenetre_Selection_XML()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialise le chemin du fichier à importer.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Fenetre_Selection_XML_Load(object sender, EventArgs e)
        {
            Chemin_Fichier = "";
        }

        /// <summary>
        /// Lance une instance de <see cref="OpenFileDialog"/>.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fenetre_Parcours = new OpenFileDialog();
            Fenetre_Parcours.ShowDialog();
            Chemin_Fichier = Fenetre_Parcours.FileName.ToString();

            Affichage_Chemin_Fichier_XML.Text = Chemin_Fichier;
        }

        /// <summary>
        /// Lance l'intégration des données du fichier XML.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Integrer_Click(object sender, EventArgs e)
        {
            Importation = true;

            bool Effacer_BDD = true;
            DialogResult result = MessageBox.Show("Attention, vous êtes sur le point d'écraser la base de donnée existante.", "Attention", MessageBoxButtons.OKCancel);
           
            if(result == DialogResult.OK)
            {
                Fonction_Lecture_XML(Effacer_BDD);
            }
            
        }

        /// <summary>
        /// Lance une intégrationdu fichier XML avec purge des données précédentes.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_MAJ_Click(object sender, EventArgs e)
        {
            Importation = true;

            bool Effacer_BDD = false;
            Fonction_Lecture_XML(Effacer_BDD);
        }

        /// <summary>
        /// Lit le fichier XML et insère les données dans la base de données.
        /// </summary>
        /// <param name="Effacer_BDD"> <see cref="true"/> si la base de données doit être effacée, <see cref="false"/> sinon </param>
        private void Fonction_Lecture_XML(bool Effacer_BDD)
        {
            Bar_Chargement_XML.Visible = true;
            Bar_Chargement_XML.Minimum = 0;
            Bar_Chargement_XML.Value = 0;
            Bar_Chargement_XML.Step = 1;
            int Nbre_Donnees = 0;

            XmlDocument Mon_XML_Doc = new XmlDocument();

            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            try
            {
                if (Effacer_BDD)
                    Data_Reader.Purger_BDD();

                Mon_XML_Doc.Load(Chemin_Fichier);
                XmlNodeList Article = Mon_XML_Doc.GetElementsByTagName("article");
                
                Bar_Chargement_XML.Maximum = Article.Count;
                foreach (XmlNode selectNode in Article)
                {
                    // On récupère les balises du fichier.
                    
                    string Description = selectNode.SelectSingleNode("description").InnerText;
                    string Ref_Article = selectNode.SelectSingleNode("refArticle").InnerText;
                    string Marque = selectNode.SelectSingleNode("marque").InnerText;
                    string Famille = selectNode.SelectSingleNode("famille").InnerText;
                    string Sous_Famille = selectNode.SelectSingleNode("sousFamille").InnerText;
                    string Prix = selectNode.SelectSingleNode("prixHT").InnerText;
                    Prix.Replace(',', separateurRegion[0]);
                    Prix.Replace('.', separateurRegion[0]);

                    // On insère la famille.

                    int Id_Famille = Data_Reader.Inserer_Famille(Famille);

                    // On insère la marque.

                    int Id_Marque = Data_Reader.Inserer_Marque(Marque);

                    // On insère la sous-famille.
                    int Id_Sous_Famille = Data_Reader.Inserer_Sous_Famille(Sous_Famille, Id_Famille);

                    // ON insère l'article.
                    double tmpPrix = Convert.ToDouble(Prix);
                    int Valeur = Data_Reader.Inserer_Article(Ref_Article, Description, Id_Sous_Famille, Id_Marque, tmpPrix, 1);

                    Nbre_Donnees++;
                    Bar_Chargement_XML.PerformStep();
                }
            
                // On affiche un message pour avertir que le fichier a bien été chargé.

                MessageBox.Show("Le fichier XML à été chargé avec succès dans la base de données. " + Nbre_Donnees + " données ont été chargées." , "Insertion réussie", MessageBoxButtons.OK);

                Bouton_Annuler.Text = "Quitter";
            }
            catch (Exception)
            {
                // On affiche un message dans le cas où il y a eu des erreurs.

                MessageBox.Show("Erreur de lecture du fichier XML.", "Erreur XML", MessageBoxButtons.OK);
            }

            Data_Reader.Terminer_Connection();
        }

        /// <summary>
        /// Retourne la valeur de l'importation.
        /// </summary>
        /// <returns> <see cref="true"/> si l'importation a réussi, <see cref="false"/> sinon </returns>
        public bool Get_Importation_Value()
        {
            return Importation;
        }

        /// <summary>
        /// Annule l'importation.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Annuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
