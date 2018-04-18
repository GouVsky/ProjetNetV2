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

                ((Fenetre_Principale) Owner).Mise_A_Jour_Barre_De_Statut("Vous avez ajouté une nouvelle famille avec succès.");
            }
        }

        private void Bouton_Modifier_Click(object sender, EventArgs e)
        {
            // On affiche la même fenêtre que celle pour l'ajout d'une famille,
            // mais avec les champs remplis avec les informations de l'objet.

            Fenetre_Ajout_Famille Fenetre_Ajout = new Fenetre_Ajout_Famille(Familles_Liste.SelectedItems[0]);

            DialogResult Resultat = Fenetre_Ajout.ShowDialog();

            if (Resultat == DialogResult.OK)
            {
                Famille Famille = Fenetre_Ajout.Ajouter_Famille();

                Familles_Liste.Items[Familles_Liste.SelectedIndices[0]] = new ListViewItem(Famille.ToString());

                ((Fenetre_Principale) Owner).Mise_A_Jour_Barre_De_Statut("Vous avez modifié une famille avec succès.");
            }
        }

        private void Bouton_Supprimer_Click(object sender, EventArgs e)
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            DialogResult Resultat_Suppression = MessageBox.Show("La famille sélectionnée va être supprimée. Il sera impossible de revenir en arrière. Continuer ?",
                                                                "Suppression",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Question);

            if (Resultat_Suppression == DialogResult.Yes)
            {
                Data_Reader.Supprimer_Famille(Familles_Liste.SelectedItems[0].SubItems[0].Text);

                Familles_Liste.SelectedItems[0].Remove();
            }

            Data_Reader.Terminer_Connection();

            ((Fenetre_Principale) Owner).Mise_A_Jour_Barre_De_Statut("Une famille supprimée.");
        }
    }
}
