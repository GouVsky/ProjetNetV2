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
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Fenetre_Edition_Sous_Famille"/>.
        /// </summary>
        public Fenetre_Edition_Sous_Famille()
        {
            InitializeComponent();

            // On garde en mémoire la référence de la sous-famille et la famille, mais on ne les affiche pas.
            // On n'affiche pas non plus les headers, puisque seuls les noms sont affichés.

            Sous_Familles_Liste.Columns.Add("ReferenceNonVisible", 0, HorizontalAlignment.Left);
            Sous_Familles_Liste.Columns.Add("NomNonVisible", Sous_Familles_Liste.Width, HorizontalAlignment.Left);
            Sous_Familles_Liste.Columns.Add("FamilleNonVisible", 0, HorizontalAlignment.Left);

            Charger_Sous_Familles();
        }

        /// <summary>
        /// Affiche l'intégralité des sous-familles disponibles dans une <see cref="ListView"/>.
        /// </summary>
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

        /// <summary>
        /// Lance une nouvelle instance de <see cref="Fenetre_Ajout_Sous_Famille"/>.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Ajouter_Click(object sender, EventArgs e)
        {
            Fenetre_Ajout_Sous_Famille Fenetre_Ajout = new Fenetre_Ajout_Sous_Famille();

            DialogResult Resultat = Fenetre_Ajout.ShowDialog();

            // On affiche la nouvelle sous-famille dans la liste.

            if (Resultat == DialogResult.OK)
            {
                SousFamille Sous_Famille = Fenetre_Ajout.Ajouter_Sous_Famille();

                ListViewItem Sous_Famille_Dans_Liste = new ListViewItem(Sous_Famille.Recuperer_Donnees());

                Sous_Familles_Liste.Items.Add(Sous_Famille_Dans_Liste);

                ((Fenetre_Principale)Owner).Mise_A_Jour_Barre_De_Statut("Vous avez ajouté une nouvelle sous-famille avec succès.");
            }
        }

        /// <summary>
        /// Lance une nouvelle instance de <see cref="Fenetre_Ajout_Sous_Famille"/> avec un objet <see cref="ListViewItem"/> de type <see cref="SousFamille"/>.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Modifier_Click(object sender, EventArgs e)
        {
            // On affiche la même fenêtre que celle pour l'ajout d'une sous-famille,
            // mais avec les champs remplis avec les informations de l'objet.

            // On vérifie qu'un élément a bien été sélectionné.

            if (Sous_Familles_Liste.SelectedItems.Count > 0)
            {
                Fenetre_Ajout_Sous_Famille Fenetre_Ajout = new Fenetre_Ajout_Sous_Famille(Sous_Familles_Liste.SelectedItems[0]);

                DialogResult Resultat = Fenetre_Ajout.ShowDialog();

                // On modifie les données de la ligne correspondant à la sous-famille.

                if (Resultat == DialogResult.OK)
                {
                    SousFamille Sous_Famille = Fenetre_Ajout.Mettre_A_Jour_Sous_Famille();

                    Sous_Familles_Liste.Items[Sous_Familles_Liste.SelectedIndices[0]] = new ListViewItem(Sous_Famille.Recuperer_Donnees());

                    ((Fenetre_Principale)Owner).Mise_A_Jour_Barre_De_Statut("Vous avez modifié une sous-famille avec succès.");
                }
            }
        }

        /// <summary>
        /// Lance une instance de <see cref="MessageBox"/> demandant la confirmation de la suppression de la sous-famille.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Supprimer_Click(object sender, EventArgs e)
        {
            if (Sous_Familles_Liste.SelectedItems.Count > 0)
            {
                SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

                // On récupère les articles associés à la sous-famille.

                bool Existe = false;

                int Reference_Sous_Famille = Convert.ToInt32(Sous_Familles_Liste.SelectedItems[0].SubItems[0].Text);

                List<Article> Articles = Data_Reader.Recuperer_Articles();

                foreach(Article Article in Articles)
                {
                    if (Article.Recuperer_Sous_Famille().Recuperer_Reference() == Reference_Sous_Famille)
                        Existe = true;
                }

                if (!Existe)
                {
                    DialogResult Resultat_Suppression = MessageBox.Show("La sous-famille sélectionnée va être supprimée. Il sera impossible de revenir en arrière. Continuer ?",
                                                                        "Suppression",
                                                                        MessageBoxButtons.YesNo,
                                                                        MessageBoxIcon.Question);

                    if (Resultat_Suppression == DialogResult.Yes)
                    {
                        Data_Reader.Supprimer_Sous_Famille(Sous_Familles_Liste.SelectedItems[0].SubItems[1].Text);

                        Sous_Familles_Liste.SelectedItems[0].Remove();
                    }

                    Data_Reader.Terminer_Connection();

                    ((Fenetre_Principale)Owner).Mise_A_Jour_Barre_De_Statut("Une sous-famille supprimée.");
                }

                else
                {
                    DialogResult Resultat_Suppression = MessageBox.Show("Il est impossible de supprimer la sous-famille sélectionnée. Des articles y sont associés.",
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
