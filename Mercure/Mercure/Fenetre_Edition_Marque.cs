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
    public partial class Fenetre_Edition_Marque : Form
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Fenetre_Edition_Marque"/>.
        /// </summary>
        public Fenetre_Edition_Marque()
        {
            InitializeComponent();

            // On garde en mémoire la référence de la marque, mais on ne l'affiche pas.
            // On n'affiche pas non plus les headers, puisque seuls les noms sont affichés.

            Marques_Liste.Columns.Add("ReferenceNonVisible", 0, HorizontalAlignment.Left);
            Marques_Liste.Columns.Add("NomNonVisible", Marques_Liste.Width, HorizontalAlignment.Left);

            Charger_Marques();
        }

        /// <summary>
        /// Affiche l'intégralité des marques disponibles dans une <see cref="ListView"/>.
        /// </summary>
        private void Charger_Marques()
        {
            Marques_Liste.Items.Clear();

            SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

            List <Marque> Marques = Data_Reader.Recuperer_Marques();

            Data_Reader.Terminer_Connection();

            foreach (Marque Marque in Marques)
            {
                ListViewItem Marque_Item = new ListViewItem(Marque.Recuperer_Donnees());

                Marques_Liste.Items.Add(Marque_Item);
            }
        }

        /// <summary>
        /// Lance une nouvelle instance de <see cref="Fenetre_Ajout_Marque"/>.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Ajouter_Click(object sender, EventArgs e)
        {
            Fenetre_Ajout_Marque Fenetre_Ajout = new Fenetre_Ajout_Marque();

            DialogResult Resultat = Fenetre_Ajout.ShowDialog();

            // On affiche la nouvelle marque dans la liste.

            if (Resultat == DialogResult.OK)
            {
                Marque Marque = Fenetre_Ajout.Ajouter_Marque();

                ListViewItem Marque_Dans_Liste = new ListViewItem(Marque.Recuperer_Donnees());

                Marques_Liste.Items.Add(Marque_Dans_Liste);

                ((Fenetre_Principale)Owner).Mise_A_Jour_Barre_De_Statut("Vous avez ajouté une nouvelle marque avec succès.");
            }
        }

        /// <summary>
        /// Lance une nouvelle instance de <see cref="Fenetre_Ajout_Marque"/> avec un objet <see cref="ListViewItem"/> de type <see cref="Marque"/>.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Modifier_Click(object sender, EventArgs e)
        {
            // On affiche la même fenêtre que celle pour l'ajout d'une marque,
            // mais avec les champs remplis avec les informations de l'objet.

            // On vérifie qu'un élément a bien été sélectionné.

            if (Marques_Liste.SelectedItems.Count > 0)
            {
                Fenetre_Ajout_Marque Fenetre_Ajout = new Fenetre_Ajout_Marque(Marques_Liste.SelectedItems[0]);

                DialogResult Resultat = Fenetre_Ajout.ShowDialog();

                // On modifie les données de la ligne correspondant à la marque.

                if (Resultat == DialogResult.OK)
                {
                    Marque Marque = Fenetre_Ajout.Mettre_A_Jour_Marque();

                    Marques_Liste.Items[Marques_Liste.SelectedIndices[0]] = new ListViewItem(Marque.Recuperer_Donnees());

                    ((Fenetre_Principale)Owner).Mise_A_Jour_Barre_De_Statut("Vous avez modifié une marque avec succès.");
                }
            }
        }

        /// <summary>
        /// Lance une instance de <see cref="MessageBox"/> demandant la confirmation de la suppression de la marque.
        /// </summary>
        /// <param name="sender"> l'objet envoyé </param>
        /// <param name="e"> l'évènement </param>
        private void Bouton_Supprimer_Click(object sender, EventArgs e)
        {
            if (Marques_Liste.SelectedItems.Count > 0)
            {
                SqlDataReader Data_Reader = SqlDataReader.Ouvrir_Connection();

                // On récupère les articles associés à la marque.

                List<Article> Articles = Data_Reader.Recuperer_Articles();

                // On ne supprime la marque que s'il n'y a aucun article associé.

                if (Articles.Count == 0)
                {
                    DialogResult Resultat_Suppression = MessageBox.Show("La marque sélectionnée va être supprimée. Il sera impossible de revenir en arrière. Continuer ?",
                                                                    "Suppression",
                                                                    MessageBoxButtons.YesNo,
                                                                    MessageBoxIcon.Question);

                    if (Resultat_Suppression == DialogResult.Yes)
                    {
                        Data_Reader.Supprimer_Article(Marques_Liste.SelectedItems[0].SubItems[1].Text);

                        Marques_Liste.SelectedItems[0].Remove();

                        ((Fenetre_Principale)Owner).Mise_A_Jour_Barre_De_Statut("Une marque supprimée.");
                    }
                }

                else
                {
                    MessageBox.Show("Il est impossible de supprimer la marque sélectionnée. Des articles y sont associés.",
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
