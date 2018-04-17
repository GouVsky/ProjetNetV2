using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercure
{
    partial class Fenetre_Ajout_Famille
    {
        private System.Windows.Forms.Label Nom_Famille_Titre;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Nom_Famille_Titre = new System.Windows.Forms.Label();
            this.Nom_Famille_Edition = new System.Windows.Forms.TextBox();
            this.Bouton_Annuler = new System.Windows.Forms.Button();
            this.Bouton_Accepter = new System.Windows.Forms.Button();
            this.Erreur = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).BeginInit();
            this.SuspendLayout();
            // 
            // Nom_Famille_Titre
            // 
            this.Nom_Famille_Titre.AutoSize = true;
            this.Nom_Famille_Titre.Location = new System.Drawing.Point(21, 18);
            this.Nom_Famille_Titre.Name = "Nom_Famille_Titre";
            this.Nom_Famille_Titre.Size = new System.Drawing.Size(29, 13);
            this.Nom_Famille_Titre.TabIndex = 0;
            this.Nom_Famille_Titre.Text = "Nom";
            // 
            // Nom_Famille_Edition
            // 
            this.Nom_Famille_Edition.Location = new System.Drawing.Point(24, 34);
            this.Nom_Famille_Edition.Name = "Nom_Famille_Edition";
            this.Nom_Famille_Edition.Size = new System.Drawing.Size(236, 20);
            this.Nom_Famille_Edition.TabIndex = 1;
            this.Nom_Famille_Edition.Validating += new System.ComponentModel.CancelEventHandler(this.Nom_Famille_Edition_Validating);
            // 
            // Bouton_Annuler
            // 
            this.Bouton_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bouton_Annuler.Location = new System.Drawing.Point(185, 87);
            this.Bouton_Annuler.Name = "Bouton_Annuler";
            this.Bouton_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Annuler.TabIndex = 2;
            this.Bouton_Annuler.Text = "Annuler";
            this.Bouton_Annuler.UseVisualStyleBackColor = true;
            // 
            // Bouton_Accepter
            // 
            this.Bouton_Accepter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Bouton_Accepter.Location = new System.Drawing.Point(104, 87);
            this.Bouton_Accepter.Name = "Bouton_Accepter";
            this.Bouton_Accepter.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Accepter.TabIndex = 3;
            this.Bouton_Accepter.Text = "Ajouter";
            this.Bouton_Accepter.UseVisualStyleBackColor = true;
            this.Bouton_Accepter.Click += new System.EventHandler(this.Bouton_Accepter_Click);
            // 
            // Erreur
            // 
            this.Erreur.BlinkRate = 0;
            this.Erreur.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Erreur.ContainerControl = this;
            // 
            // Fenetre_Ajout_Famille
            // 
            this.AcceptButton = this.Bouton_Accepter;
            this.CancelButton = this.Bouton_Annuler;
            this.ClientSize = new System.Drawing.Size(284, 122);
            this.Controls.Add(this.Bouton_Accepter);
            this.Controls.Add(this.Bouton_Annuler);
            this.Controls.Add(this.Nom_Famille_Edition);
            this.Controls.Add(this.Nom_Famille_Titre);
            this.Name = "Fenetre_Ajout_Famille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox Nom_Famille_Edition;
        private System.Windows.Forms.Button Bouton_Annuler;
        private System.Windows.Forms.Button Bouton_Accepter;
        private System.Windows.Forms.ErrorProvider Erreur;
        private System.ComponentModel.IContainer components;
    }
}
