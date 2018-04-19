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
    public partial class Fenetre_Edition_Famille : Form
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Fenetre_Edition_Famille"/>.
        /// </summary>
        public Fenetre_Edition_Famille()
        {
            InitializeComponent();

            // On garde en mémoire la référence de la famille, mais on ne l'affiche pas.
            // On n'affiche pas non plus les headers, puisque seuls les noms sont affichés.

            Familles_Liste.Columns.Add("ReferenceNonVisible", 0, HorizontalAlignment.Left);
            Familles_Liste.Columns.Add("NomNonVisible", Familles_Liste.Width, HorizontalAlignment.Left);

            Charger_Familles();
        }

        /// <summary>
        /// Affiche l'intégralité des familles disponibles dans une <see cref="ListView"/>.
        /// </summary>
        private void Charger_Familles()
        {
            Familles_Liste.Items.Clear();

            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List<Famille> Familles = Data_Reader.Recuperer_Familles();

            foreach (Famille Famille in Familles)
            {
                ListViewItem Famille_Item = new ListViewItem(Famille.Recuperer_Donnees());

                Familles_Liste.Items.Add(Famille_Item);
            }

            Data_Reader.Terminer_Connection();
        }

        /// <summary>
        /// Lance une nouvelle instance de <see cref="Fenetre_Ajout_Famille"/>.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Ajouter_Click(object sender, EventArgs e)
        {
            Fenetre_Ajout_Famille Fenetre_Ajout = new Fenetre_Ajout_Famille();

            DialogResult Resultat = Fenetre_Ajout.ShowDialog();

            // On affiche la nouvelle famille dans la liste.

            if (Resultat == DialogResult.OK)
            {
                Famille Famille = Fenetre_Ajout.Ajouter_Famille();

                ListViewItem Famille_Dans_Liste = new ListViewItem(Famille.Recuperer_Donnees());

                Familles_Liste.Items.Add(Famille_Dans_Liste);

                ((Fenetre_Principale) Owner).Mise_A_Jour_Barre_De_Statut("Vous avez ajouté une nouvelle famille avec succès.");
            }
        }

        /// <summary>
        /// Lance une nouvelle instance de <see cref="Fenetre_Ajout_Famille"/> avec un objet <see cref="ListViewItem"/> de type <see cref="Famille"/>.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Modifier_Click(object sender, EventArgs e)
        {
            // On affiche la même fenêtre que celle pour l'ajout d'une famille,
            // mais avec les champs remplis avec les informations de l'objet.

            // On vérifie qu'un élément a bien été sélectionné.

            if (Familles_Liste.SelectedItems.Count > 0)
            {
                Fenetre_Ajout_Famille Fenetre_Ajout = new Fenetre_Ajout_Famille(Familles_Liste.SelectedItems[0]);

                DialogResult Resultat = Fenetre_Ajout.ShowDialog();

                // On modifie les données de la ligne correspondant à la famille.

                if (Resultat == DialogResult.OK)
                {
                    Famille Famille = Fenetre_Ajout.Mettre_A_Jour_Famille();

                    Familles_Liste.Items[Familles_Liste.SelectedIndices[0]] = new ListViewItem(Famille.Recuperer_Donnees());

                    ((Fenetre_Principale)Owner).Mise_A_Jour_Barre_De_Statut("Vous avez modifié une famille avec succès.");
                }
            } 
        }

        /// <summary>
        /// Lance une instance de <see cref="MessageBox"/> demandant la confirmation de la suppression de la famille.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Supprimer_Click(object sender, EventArgs e)
        {
            if (Familles_Liste.SelectedItems.Count > 0)
            {
                SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

                // On récupère les sous-familles de la famille.

                int Reference_Famille = Convert.ToInt32(Familles_Liste.SelectedItems[0].SubItems[0].Text);

                List <SousFamille> Sous_Familles = Data_Reader.Recuperer_Sous_Familles(Reference_Famille);

                // On ne supprime la famille que s'il n'y a aucune sous-famille associée.

                if (Sous_Familles.Count == 0)
                {
                    DialogResult Resultat_Suppression = MessageBox.Show("La famille sélectionnée va être supprimée. Il sera impossible de revenir en arrière. Continuer ?",
                                                                    "Suppression",
                                                                    MessageBoxButtons.YesNo,
                                                                    MessageBoxIcon.Question);

                    if (Resultat_Suppression == DialogResult.Yes)
                    {
                        Data_Reader.Supprimer_Famille(Familles_Liste.SelectedItems[0].SubItems[1].Text);

                        Familles_Liste.SelectedItems[0].Remove();

                        ((Fenetre_Principale)Owner).Mise_A_Jour_Barre_De_Statut("Une famille supprimée.");
                    }
                }

                else
                {
                    MessageBox.Show("Il est impossible de supprimer la famille sélectionnée. Des sous-familles et/ou des articles y sont associés.",
                                                                    "Erreur",
                                                                    MessageBoxButtons.OK);
                }

                Data_Reader.Terminer_Connection();
            }
        }

        /// <summary>
        /// Ferme la fenêtre.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
