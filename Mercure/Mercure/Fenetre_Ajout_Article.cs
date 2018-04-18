using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Mercure
{

    public partial class Fenetre_Ajout_Article : Form
    {
        private ListViewItem Article;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Fenetre_Ajout_Article"/>.
        /// </summary>
        public Fenetre_Ajout_Article()
        {
            InitializeComponent();

            Charger_Marques();
            Charger_Familles();

            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Fenetre_Ajout_Article"/> avec un objet <see cref="ListViewItem"/> de type <see cref="Article"/>.
        /// </summary>
        /// <param name="Article">Un objet <see cref="ListViewItem"/> de type <see cref="Article"/></param>
        public Fenetre_Ajout_Article(ListViewItem Article)
        {
            InitializeComponent();

            this.Article = Article;

            // On remplit les champs avec les données de l'article.

            Charger_Marques(Article.SubItems[4].Text);
            Charger_Familles(Article.SubItems[2].Text);

            Reference_Article_Edition.Text = Article.SubItems[0].Text;
            Description_Article_Edition.Text = Article.SubItems[1].Text;

            Prix_Unitaire_Article_Edition.Value = Decimal.Parse(Article.SubItems[5].Text);

            Quantite_Article_Edition.Value = Int32.Parse(Article.SubItems[6].Text);

            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

            Bouton_Validation.Text = "Modifier";
        }

        /// <summary>
        /// Lance la vérification des données entrées avant la validation.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Validation_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                DialogResult = DialogResult.None;

            else
                DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Lance la vérification de la validité du champ associé à la référence de l'article. Affiche une erreur si le champ n'est pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement d'annulation </param>
        private void Reference_Article_Edition_Validating(object sender, CancelEventArgs e)
        {
            if (Reference_Article_Edition.Text.Length < 8)
            {
                e.Cancel = true;

                Erreur.SetError(Reference_Article_Edition, "La référence de l'article n'a pas ou a mal été renseignée.\nElle doit contenir 8 caractères.");
            }
        }

        /// <summary>
        /// Efface l'erreur affichée si le champ associé à la référence de l'article n'était pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Reference_Article_Edition_Validated(object sender, EventArgs e)
        {
            Erreur.SetError(Reference_Article_Edition, "");
        }

        /// <summary>
        /// Lance une vérification sur le champ de texte associé à la référence de l'article.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Reference_Article_Edition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            // On interdit l'utilisation des caractères spéciaux.

            Regex Regex = new Regex(@"[^a-zA-Z0-9]");

            if (Reference_Article_Edition.Text.Length < 8)
                e.Handled = !(!Regex.IsMatch(e.KeyChar.ToString()) || e.KeyChar == (char)8);

            else if (Reference_Article_Edition.Text.Length == 8)
                e.Handled = !(e.KeyChar == (char)8);
        }

        /// <summary>
        /// Lance une vérification sur le champ associé au choix de la marque de l'article. Affiche une erreur si le champ n'est pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Choix_Marque_Article_Validating(object sender, CancelEventArgs e)
        {
            if (Choix_Marque_Article.SelectedIndex == -1)
            {
                e.Cancel = true;

                Erreur.SetError(Choix_Marque_Article, "Une marque doit être sélectionnée.");
            }
        }

        /// <summary>
        /// Efface l'erreur affichée si le champ associé à la marque de l'article n'était pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Choix_Marque_Article_Validated(object sender, EventArgs e)
        {
            Erreur.SetError(Choix_Marque_Article, "");
        }

        /// <summary>
        /// Lance une vérification sur le champ associé au choix de la famille de l'article. Affiche une erreur si le champ n'est pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Choix_Famille_Article_Validating(object sender, CancelEventArgs e)
        {
            if (Choix_Famille_Article.SelectedIndex == -1)
            {
                e.Cancel = true;

                Erreur.SetError(Choix_Famille_Article, "Une famille d'articles doit être sélectionnée.");
            }
        }

        /// <summary>
        /// Efface l'erreur affichée si le champ associé à la famille de l'article n'était pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Choix_Famille_Article_Validated(object sender, EventArgs e)
        {
            Erreur.SetError(Choix_Famille_Article, "");
        }

        /// <summary>
        /// Lance une vérification sur le champ associé au choix de la sous-famille de l'article. Affiche une erreur si le champ n'est pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Choix_Sous_Famille_Article_Validating(object sender, CancelEventArgs e)
        {
            if (Choix_Sous_Famille_Article.SelectedIndex == -1)
            {
                e.Cancel = true;

                Erreur.SetError(Choix_Sous_Famille_Article, "Une sous-famille d'articles doit être sélectionnée.");
            }
        }

        /// <summary>
        /// Efface l'erreur affichée si le champ associé à la sous-famille de l'article n'était pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Choix_Sous_Famille_Article_Validated(object sender, EventArgs e)
        {
            Erreur.SetError(Choix_Sous_Famille_Article, "");
        }

        /// <summary>
        /// Lance une vérification sur le champ associé à la description de l'article. Affiche une erreur si le champ n'est pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Description_Article_Edition_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Description_Article_Edition.Text))
            {
                e.Cancel = true;

                Erreur.SetError(Description_Article_Edition, "Une description de l'article doit être renseignée.");
            }
        }

        /// <summary>
        /// Efface l'erreur affichée si le champ associé à la description de l'article n'était pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Description_Article_Edition_Validated(object sender, EventArgs e)
        {
            Erreur.SetError(Description_Article_Edition, "");
        }

        /// <summary>
        /// Lance une vérification sur le champ associé au prix unitaire de l'article. Affiche une erreur si le champ n'est pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Prix_Unitaire_Article_Edition_Validating(object sender, CancelEventArgs e)
        {
            if (Prix_Unitaire_Article_Edition.Value == 0)
            {
                e.Cancel = true;

                Erreur.SetError(Prix_Unitaire_Article_Edition, "Le prix unitaire de l'article ne peut pas être nul.");
            }
        }

        /// <summary>
        /// Efface l'erreur affichée si le champ associé au prix unitaire de l'article n'était pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Prix_Unitaire_Article_Edition_Validated(object sender, EventArgs e)
        {
            Erreur.SetError(Prix_Unitaire_Article_Edition, "");
        }

        /// <summary>
        /// Lance une vérification sur le champ associé à la quantité de l'article. Affiche une erreur si le champ n'est pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Quantite_Article_Edition_Validating(object sender, CancelEventArgs e)
        {
            if (Quantite_Article_Edition.Value == 0)
            {
                e.Cancel = true;

                Erreur.SetError(Quantite_Article_Edition, "La quantité prévue d'articles ne peut pas être nulle.");
            }
        }

        /// <summary>
        /// Efface l'erreur affichée si le champ associé à la quantité de l'article n'était pas valide.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Quantite_Article_Edition_Validated(object sender, EventArgs e)
        {
            Erreur.SetError(Quantite_Article_Edition, "");
        }

        /// <summary>
        /// Affiche l'intégralité des marques disponibles dans un <see cref="ComboBox"/>.
        /// </summary>
        private void Charger_Marques()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<Marque> Marques = Data_Reader.Recuperer_Marques();

            foreach (Marque Marque in Marques)
            {
                Choix_Marque_Article.Items.Add(Marque);
            }

            Data_Reader.Terminer_Connection();
        }

        /// <summary>
        /// Affiche l'intégralité des marques disponibles dans un <see cref="ComboBox"/> et sélectionne celle correspondant à celle de l'article à modifier.
        /// </summary>
        /// <param name="Nom"> le nom de la marque de l'article à modifier </param>
        private void Charger_Marques(string Nom)
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<Marque> Marques = Data_Reader.Recuperer_Marques();

            foreach (Marque Marque in Marques)
            {
                Choix_Marque_Article.Items.Add(Marque);

                if (Nom.Equals(Marque.Recuperer_Nom()))
                {
                    Choix_Marque_Article.SelectedItem = Marque;
                }
            }

            Data_Reader.Terminer_Connection();
        }

        /// <summary>
        /// Affiche l'intégralité des familles disponibles dans un <see cref="ComboBox"/>.
        /// </summary>
        private void Charger_Familles()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<Famille> Familles = Data_Reader.Recuperer_Familles();

            foreach (Famille Famille in Familles)
            {
                Choix_Famille_Article.Items.Add(Famille);
            }

            Data_Reader.Terminer_Connection();
        }

        /// <summary>
        /// Affiche l'intégralité des familles disponibles dans un <see cref="ComboBox"/> et sélectionne celle correspondant à celle de l'article à modifier.
        /// </summary>
        /// <param name="Nom"> le nom de la famille de l'article à modifier </param>
        private void Charger_Familles(string Nom)
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<Famille> Familles = Data_Reader.Recuperer_Familles();

            foreach (Famille Famille in Familles)
            {
                Choix_Famille_Article.Items.Add(Famille);

                if (Nom.Equals(Famille.Recuperer_Nom()))
                {
                    Choix_Famille_Article.SelectedItem = Famille;
                }
            }

            Data_Reader.Terminer_Connection();
        }

        /// <summary>
        /// Ajoute un article dans la base de données.
        /// </summary>
        /// <returns>L'article ajouté</returns>
        public Article Ajouter_Article()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();


            Famille Famille = (Famille)Choix_Famille_Article.SelectedItem;

            SousFamille Sous_Famille = (SousFamille)Choix_Sous_Famille_Article.SelectedItem;
            Sous_Famille.Definir_Famille(Famille);

            Marque Marque = (Marque)Choix_Marque_Article.SelectedItem;

            string Reference = Reference_Article_Edition.Text;
            string Description = Description_Article_Edition.Text;
            string Prix = Prix_Unitaire_Article_Edition.Text;
            string Quantite = Quantite_Article_Edition.Text;

            double Prix_Converti = Convert.ToDouble(Prix);

            Data_Reader.Inserer_Sous_Famille(Sous_Famille.Recuperer_Nom(), Famille.Recuperer_Reference());

            Data_Reader.Inserer_Article(Reference,
                                        Description,
                                        Sous_Famille.Recuperer_Reference(),
                                        Marque.Recuperer_Reference(),
                                        Prix_Converti,
                                        Int32.Parse(Quantite));

            Article Article = new Article(Reference, Description, Sous_Famille, Marque, Prix_Converti, Int32.Parse(Quantite));

            Data_Reader.Terminer_Connection();

            return Article;
        }

        /// <summary>
        /// Affiche les différentes sous_familles associées à la famille choisie.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Choix_Famille_Article_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Choix_Famille_Article.SelectedIndex > -1)
            {
                // On efface le contenu actuel du combobox.

                Choix_Sous_Famille_Article.Items.Clear();
                Choix_Sous_Famille_Article.Text = "Sélectionnez une sous-famille";

                // On remplit le combobox en fonction de la famille.

                SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

                List<SousFamille> Sous_Familles = Data_Reader.Recuperer_Sous_Familles(((Famille)Choix_Famille_Article.SelectedItem).Recuperer_Reference());

                foreach (SousFamille Sous_Famille in Sous_Familles)
                {
                    Choix_Sous_Famille_Article.Items.Add(Sous_Famille);

                    // On sélectionne la sous-famille correspondant à la l'article.

                    if (Article != null && Article.SubItems[3].Text.Equals(Sous_Famille.Recuperer_Nom()))
                    {
                        Choix_Sous_Famille_Article.SelectedItem = Sous_Famille;
                    }
                }

                Data_Reader.Terminer_Connection();
            }
        }
    }
}