using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    public partial class Fenetre_Edition_Famille : Form
    {
        public Fenetre_Edition_Famille()
        {
            InitializeComponent();

            Familles_Liste.Columns.Add("NomNonVisible", Familles_Liste.Width, HorizontalAlignment.Left);

            Charger_Familles();
        }

        private void Charger_Familles()
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<Famille> Familles = Data_Reader.Recuperer_Familles();

            foreach (Famille Famille in Familles)
            {
                ListViewItem Famille_Item = new ListViewItem(Famille.ToString());

                Familles_Liste.Items.Add(Famille_Item);
            }

            Data_Reader.Terminer_Connection();
        }

        private void Bouton_Ajouter_Click(object sender, EventArgs e)
        {
            Fenetre_Ajout_Famille Fenetre_Ajout = new Fenetre_Ajout_Famille();

            DialogResult Resultat = Fenetre_Ajout.ShowDialog();

            if (Resultat == DialogResult.OK)
            {
                Famille Famille = Fenetre_Ajout.Ajouter_Famille();

                ListViewItem Famille_Dans_Liste = new ListViewItem(Famille.ToString());

                Familles_Liste.Items.Add(Famille_Dans_Liste);
            }
        }
    }
}
