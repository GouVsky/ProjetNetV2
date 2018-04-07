using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    public partial class Fenetre_Ajout_Article : Form
    {
        public Fenetre_Ajout_Article()
        {
            InitializeComponent();
        }

        public Fenetre_Ajout_Article(ListViewItem Article)
        {
            InitializeComponent();

            Reference_Article_Edition.Text = Article.SubItems[0].Text;
            Description_Article_Edition.Text = Article.SubItems[1].Text;

            // On ajoute une indication sur la forme du nombre décimal.

            Prix_Unitaire_Article_Edition.Value = Decimal.Parse(Article.SubItems[5].Text, new NumberFormatInfo() { NumberDecimalSeparator = "," });

            Quantite_Article_Edition.Value = Int32.Parse(Article.SubItems[6].Text);
        }

        private void Bouton_Validation_Click(object sender, EventArgs e)
        {

        }
    }
}