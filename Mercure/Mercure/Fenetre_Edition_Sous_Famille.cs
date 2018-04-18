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
    public partial class Fenetre_Edition_Sous_Famille : Form
    {
        public Fenetre_Edition_Sous_Famille()
        {
            InitializeComponent();

            Sous_Familles_Liste.Columns.Add("ReferenceNonVisible", 0, HorizontalAlignment.Left);
            Sous_Familles_Liste.Columns.Add("NomNonVisible", Sous_Familles_Liste.Width, HorizontalAlignment.Left);
            Sous_Familles_Liste.Columns.Add("FamilleNonVisible", 0, HorizontalAlignment.Left);

            Charger_Sous_Familles();
        }

        private void Charger_Sous_Familles()
        {
            Sous_Familles_Liste.Items.Clear();

            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<SousFamille> Sous_Familles = Data_Reader.Recuperer_Sous_Familles();

            foreach (SousFamille Sous_Famille in Sous_Familles)
            {
                ListViewItem Sous_Famille_Item = new ListViewItem(Sous_Famille.Recuperer_Donnees());

                Sous_Familles_Liste.Items.Add(Sous_Famille_Item);
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

                ListViewItem Famille_Dans_Liste = new ListViewItem(Famille.Recuperer_Donnees());

                Sous_Familles_Liste.Items.Add(Famille_Dans_Liste);

                ((Fenetre_Principale)Owner).Mise_A_Jour_Barre_De_Statut("Vous avez ajouté une nouvelle sous-famille avec succès.");
            }
        }

        private void Bouton_Modifier_Click(object sender, EventArgs e)
        {
            // On affiche la même fenêtre que celle pour l'ajout d'une sous-famille,
            // mais avec les champs remplis avec les informations de l'objet.

            if (Sous_Familles_Liste.SelectedItems.Count > 0)
            {
                Fenetre_Ajout_Sous_Famille Fenetre_Ajout = new Fenetre_Ajout_Sous_Famille(Sous_Familles_Liste.SelectedItems[0]);

                DialogResult Resultat = Fenetre_Ajout.ShowDialog();

                if (Resultat == DialogResult.OK)
                {
                    SousFamille Sous_Famille = Fenetre_Ajout.Mettre_A_Jour_Sous_Famille();

                    Sous_Familles_Liste.Items[Sous_Familles_Liste.SelectedIndices[0]] = new ListViewItem(Sous_Famille.Recuperer_Donnees());

                    ((Fenetre_Principale)Owner).Mise_A_Jour_Barre_De_Statut("Vous avez modifié une sous-famille avec succès.");
                }
            }
        }

        private void Bouton_Supprimer_Click(object sender, EventArgs e)
        {
            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            DialogResult Resultat_Suppression = MessageBox.Show("La sous-famille sélectionnée va être supprimée. Il sera impossible de revenir en arrière. Continuer ?",
                                                                "Suppression",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Question);

            if (Resultat_Suppression == DialogResult.Yes)
            {
                Data_Reader.Supprimer_Famille(Sous_Familles_Liste.SelectedItems[0].SubItems[0].Text);

                Sous_Familles_Liste.SelectedItems[0].Remove();
            }

            Data_Reader.Terminer_Connection();

            ((Fenetre_Principale)Owner).Mise_A_Jour_Barre_De_Statut("Une sous-famille supprimée.");
        }

        private void Bouton_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
