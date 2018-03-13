using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    public partial class Fenetre_Principale : Form
    {
        public Fenetre_Principale()
        {
            InitializeComponent();
        }

        private void Mercure_Load(object sender, EventArgs e)
        {

        }

        private void Menu_Fichier_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Fichier_Import_XML_Click(object sender, EventArgs e)
        {
            Fenetre_Selection_XML fen = new Fenetre_Selection_XML();
            fen.ShowDialog();
        }

        private void Menu_Fichier_Quitter_Click(object sender, EventArgs e)
        {

        }

        private void Barre_De_Statut_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Affichage_Articles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
