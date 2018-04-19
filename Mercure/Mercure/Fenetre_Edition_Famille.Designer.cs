﻿namespace Mercure
{
    partial class Fenetre_Edition_Famille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bouton_Quitter = new System.Windows.Forms.Button();
            this.Bouton_Supprimer = new System.Windows.Forms.Button();
            this.Bouton_Modifier = new System.Windows.Forms.Button();
            this.Bouton_Ajouter = new System.Windows.Forms.Button();
            this.Familles_Liste = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Bouton_Quitter
            // 
            this.Bouton_Quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bouton_Quitter.Location = new System.Drawing.Point(296, 337);
            this.Bouton_Quitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bouton_Quitter.Name = "Bouton_Quitter";
            this.Bouton_Quitter.Size = new System.Drawing.Size(100, 28);
            this.Bouton_Quitter.TabIndex = 4;
            this.Bouton_Quitter.Text = "Quitter";
            this.Bouton_Quitter.UseVisualStyleBackColor = true;
            this.Bouton_Quitter.Click += new System.EventHandler(this.Bouton_Quitter_Click);
            // 
            // Bouton_Supprimer
            // 
            this.Bouton_Supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bouton_Supprimer.Location = new System.Drawing.Point(296, 111);
            this.Bouton_Supprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bouton_Supprimer.Name = "Bouton_Supprimer";
            this.Bouton_Supprimer.Size = new System.Drawing.Size(100, 28);
            this.Bouton_Supprimer.TabIndex = 3;
            this.Bouton_Supprimer.Text = "Supprimer";
            this.Bouton_Supprimer.UseVisualStyleBackColor = true;
            this.Bouton_Supprimer.Click += new System.EventHandler(this.Bouton_Supprimer_Click);
            // 
            // Bouton_Modifier
            // 
            this.Bouton_Modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bouton_Modifier.Location = new System.Drawing.Point(296, 63);
            this.Bouton_Modifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bouton_Modifier.Name = "Bouton_Modifier";
            this.Bouton_Modifier.Size = new System.Drawing.Size(100, 28);
            this.Bouton_Modifier.TabIndex = 2;
            this.Bouton_Modifier.Text = "Modifier";
            this.Bouton_Modifier.UseVisualStyleBackColor = true;
            this.Bouton_Modifier.Click += new System.EventHandler(this.Bouton_Modifier_Click);
            // 
            // Bouton_Ajouter
            // 
            this.Bouton_Ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bouton_Ajouter.Location = new System.Drawing.Point(296, 16);
            this.Bouton_Ajouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bouton_Ajouter.Name = "Bouton_Ajouter";
            this.Bouton_Ajouter.Size = new System.Drawing.Size(100, 28);
            this.Bouton_Ajouter.TabIndex = 1;
            this.Bouton_Ajouter.Text = "Ajouter";
            this.Bouton_Ajouter.UseVisualStyleBackColor = true;
            this.Bouton_Ajouter.Click += new System.EventHandler(this.Bouton_Ajouter_Click);
            // 
            // Familles_Liste
            // 
            this.Familles_Liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Familles_Liste.FullRowSelect = true;
            this.Familles_Liste.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.Familles_Liste.Location = new System.Drawing.Point(17, 16);
            this.Familles_Liste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Familles_Liste.MultiSelect = false;
            this.Familles_Liste.Name = "Familles_Liste";
            this.Familles_Liste.Size = new System.Drawing.Size(255, 349);
            this.Familles_Liste.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Familles_Liste.TabIndex = 0;
            this.Familles_Liste.UseCompatibleStateImageBehavior = false;
            this.Familles_Liste.View = System.Windows.Forms.View.Details;
            // 
            // Fenetre_Edition_Famille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 378);
            this.Controls.Add(this.Bouton_Quitter);
            this.Controls.Add(this.Bouton_Supprimer);
            this.Controls.Add(this.Bouton_Modifier);
            this.Controls.Add(this.Bouton_Ajouter);
            this.Controls.Add(this.Familles_Liste);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fenetre_Edition_Famille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edition des familes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bouton_Quitter;
        private System.Windows.Forms.Button Bouton_Supprimer;
        private System.Windows.Forms.Button Bouton_Modifier;
        private System.Windows.Forms.Button Bouton_Ajouter;
        private System.Windows.Forms.ListView Familles_Liste;
    }
}