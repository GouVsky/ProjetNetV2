using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    partial class Fenetre_Edition_Famille
    {
        private void InitializeComponent()
        {
            this.Liste_Familles = new System.Windows.Forms.ListView();
            this.Bouton_Ajouter = new System.Windows.Forms.Button();
            this.Bouton_Modifier = new System.Windows.Forms.Button();
            this.Bouton_Supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Liste_Familles
            // 
            this.Liste_Familles.Location = new System.Drawing.Point(12, 12);
            this.Liste_Familles.Name = "Liste_Familles";
            this.Liste_Familles.Size = new System.Drawing.Size(177, 237);
            this.Liste_Familles.TabIndex = 0;
            this.Liste_Familles.UseCompatibleStateImageBehavior = false;
            // 
            // Bouton_Ajouter
            // 
            this.Bouton_Ajouter.Location = new System.Drawing.Point(196, 13);
            this.Bouton_Ajouter.Name = "Bouton_Ajouter";
            this.Bouton_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Ajouter.TabIndex = 1;
            this.Bouton_Ajouter.Text = "Ajouter";
            this.Bouton_Ajouter.UseVisualStyleBackColor = true;
            // 
            // Bouton_Modifier
            // 
            this.Bouton_Modifier.Location = new System.Drawing.Point(196, 42);
            this.Bouton_Modifier.Name = "Bouton_Modifier";
            this.Bouton_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Modifier.TabIndex = 2;
            this.Bouton_Modifier.Text = "Modifier";
            this.Bouton_Modifier.UseVisualStyleBackColor = true;
            // 
            // Bouton_Supprimer
            // 
            this.Bouton_Supprimer.Location = new System.Drawing.Point(196, 71);
            this.Bouton_Supprimer.Name = "Bouton_Supprimer";
            this.Bouton_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Supprimer.TabIndex = 3;
            this.Bouton_Supprimer.Text = "Supprimer";
            this.Bouton_Supprimer.UseVisualStyleBackColor = true;
            // 
            // Fenetre_Edition_Famille
            // 
            this.ClientSize = new System.Drawing.Size(285, 261);
            this.Controls.Add(this.Bouton_Supprimer);
            this.Controls.Add(this.Bouton_Modifier);
            this.Controls.Add(this.Bouton_Ajouter);
            this.Controls.Add(this.Liste_Familles);
            this.Name = "Fenetre_Edition_Famille";
            this.ResumeLayout(false);

        }

        private ListView Liste_Familles;
        private Button Bouton_Ajouter;
        private Button Bouton_Modifier;
        private Button Bouton_Supprimer;
    }
}
