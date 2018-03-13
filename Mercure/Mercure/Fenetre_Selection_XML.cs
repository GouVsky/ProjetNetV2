using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        }

        private void Buton_MAJ_Click(object sender, EventArgs e)
        {
            
        }
    }
}
