using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercure
{
    partial class Fenetre_Edition_Famille
    {
        private System.Windows.Forms.ListView Familles_Liste;

        private void InitializeComponent()
        {
            this.Familles_Liste = new System.Windows.Forms.ListView();
            this.Bouton_Ajouter = new System.Windows.Forms.Button();
            this.Bouton_Modifier = new System.Windows.Forms.Button();
            this.Bouton_Supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Familles_Liste
            // 
            this.Familles_Liste.FullRowSelect = true;
            this.Familles_Liste.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.Familles_Liste.Location = new System.Drawing.Point(12, 12);
            this.Familles_Liste.MultiSelect = false;
            this.Familles_Liste.Name = "Familles_Liste";
            this.Familles_Liste.Size = new System.Drawing.Size(196, 270);
            this.Familles_Liste.TabIndex = 0;
            this.Familles_Liste.UseCompatibleStateImageBehavior = false;
            this.Familles_Liste.View = System.Windows.Forms.View.Details;
            // 
            // Bouton_Ajouter
            // 
            this.Bouton_Ajouter.Location = new System.Drawing.Point(223, 12);
            this.Bouton_Ajouter.Name = "Bouton_Ajouter";
            this.Bouton_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Ajouter.TabIndex = 1;
            this.Bouton_Ajouter.Text = "Ajouter";
            this.Bouton_Ajouter.UseVisualStyleBackColor = true;
            this.Bouton_Ajouter.Click += new System.EventHandler(this.Bouton_Ajouter_Click);
            // 
            // Bouton_Modifier
            // 
            this.Bouton_Modifier.Location = new System.Drawing.Point(223, 50);
            this.Bouton_Modifier.Name = "Bouton_Modifier";
            this.Bouton_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Modifier.TabIndex = 2;
            this.Bouton_Modifier.Text = "Modifier";
            this.Bouton_Modifier.UseVisualStyleBackColor = true;
            this.Bouton_Modifier.Click += new System.EventHandler(this.Bouton_Modifier_Click);
            // 
            // Bouton_Supprimer
            // 
            this.Bouton_Supprimer.Location = new System.Drawing.Point(223, 88);
            this.Bouton_Supprimer.Name = "Bouton_Supprimer";
            this.Bouton_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Supprimer.TabIndex = 3;
            this.Bouton_Supprimer.Text = "Supprimer";
            this.Bouton_Supprimer.UseVisualStyleBackColor = true;
            this.Bouton_Supprimer.Click += new System.EventHandler(this.Bouton_Supprimer_Click);
            // 
            // Fenetre_Edition_Famille
            // 
            this.ClientSize = new System.Drawing.Size(310, 294);
            this.Controls.Add(this.Bouton_Supprimer);
            this.Controls.Add(this.Bouton_Modifier);
            this.Controls.Add(this.Bouton_Ajouter);
            this.Controls.Add(this.Familles_Liste);
            this.Name = "Fenetre_Edition_Famille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button Bouton_Ajouter;
        private System.Windows.Forms.Button Bouton_Modifier;
        private System.Windows.Forms.Button Bouton_Supprimer;
    }
}
