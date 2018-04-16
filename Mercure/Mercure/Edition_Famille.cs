using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    public partial class Edition_Famille : Form
    {
        private ListView Liste_Familles;
        private Button Bouton_Modifier_Famille;
        private Button Bouton_Supprimer_FAmille;
        private Button Bouton_Ajout_Famille;

        public Edition_Famille()
       {
       }

        private void InitializeComponent()
        {
            this.Liste_Familles = new System.Windows.Forms.ListView();
            this.Bouton_Ajout_Famille = new System.Windows.Forms.Button();
            this.Bouton_Modifier_Famille = new System.Windows.Forms.Button();
            this.Bouton_Supprimer_FAmille = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Liste_Familles
            // 
            this.Liste_Familles.Location = new System.Drawing.Point(12, 12);
            this.Liste_Familles.MultiSelect = false;
            this.Liste_Familles.Name = "Liste_Familles";
            this.Liste_Familles.Size = new System.Drawing.Size(201, 284);
            this.Liste_Familles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Liste_Familles.TabIndex = 0;
            this.Liste_Familles.UseCompatibleStateImageBehavior = false;
            // 
            // Bouton_Ajout_Famille
            // 
            this.Bouton_Ajout_Famille.Location = new System.Drawing.Point(232, 12);
            this.Bouton_Ajout_Famille.Name = "Bouton_Ajout_Famille";
            this.Bouton_Ajout_Famille.Size = new System.Drawing.Size(72, 22);
            this.Bouton_Ajout_Famille.TabIndex = 1;
            this.Bouton_Ajout_Famille.Text = "Ajouter";
            this.Bouton_Ajout_Famille.UseVisualStyleBackColor = true;
            // 
            // Bouton_Modifier_Famille
            // 
            this.Bouton_Modifier_Famille.Location = new System.Drawing.Point(232, 50);
            this.Bouton_Modifier_Famille.Name = "Bouton_Modifier_Famille";
            this.Bouton_Modifier_Famille.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Modifier_Famille.TabIndex = 2;
            this.Bouton_Modifier_Famille.Text = "Modifier";
            this.Bouton_Modifier_Famille.UseVisualStyleBackColor = true;
            // 
            // Bouton_Supprimer_FAmille
            // 
            this.Bouton_Supprimer_FAmille.Location = new System.Drawing.Point(232, 88);
            this.Bouton_Supprimer_FAmille.Name = "Bouton_Supprimer_FAmille";
            this.Bouton_Supprimer_FAmille.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Supprimer_FAmille.TabIndex = 3;
            this.Bouton_Supprimer_FAmille.Text = "Supprimer";
            this.Bouton_Supprimer_FAmille.UseVisualStyleBackColor = true;
            // 
            // Edition_Famille
            // 
            this.ClientSize = new System.Drawing.Size(326, 308);
            this.Controls.Add(this.Bouton_Supprimer_FAmille);
            this.Controls.Add(this.Bouton_Modifier_Famille);
            this.Controls.Add(this.Bouton_Ajout_Famille);
            this.Controls.Add(this.Liste_Familles);
            this.Name = "Edition_Famille";
            this.ResumeLayout(false);

        }
    }
}
