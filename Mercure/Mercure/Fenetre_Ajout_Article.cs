using System;
using System.Collections.Generic;
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

        private void Reference_Article_Edition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (String.IsNullOrEmpty(Reference_Article_Edition.Text))
                e.Handled = !(e.KeyChar == (char) Keys.F);

            else if (Reference_Article_Edition.Text.Length <= 7)
                e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8);

            else if (Reference_Article_Edition.Text.Length <= 8)
                e.Handled = !(e.KeyChar == (char)8);
        }
    }
}