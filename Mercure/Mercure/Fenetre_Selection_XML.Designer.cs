﻿namespace Mercure
{
    partial class Fenetre_Selection_XML
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
            this.Bouton_Parcourir = new System.Windows.Forms.Button();
            this.Bouton_Integrer = new System.Windows.Forms.Button();
            this.Buton_MAJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bouton_Parcourir
            // 
            this.Bouton_Parcourir.Location = new System.Drawing.Point(16, 48);
            this.Bouton_Parcourir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bouton_Parcourir.Name = "Bouton_Parcourir";
            this.Bouton_Parcourir.Size = new System.Drawing.Size(100, 54);
            this.Bouton_Parcourir.TabIndex = 0;
            this.Bouton_Parcourir.Text = "Parcourir";
            this.Bouton_Parcourir.UseVisualStyleBackColor = true;
            this.Bouton_Parcourir.Click += new System.EventHandler(this.Parcourir_Click);
            // 
            // Bouton_Integrer
            // 
            this.Bouton_Integrer.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Bouton_Integrer.Location = new System.Drawing.Point(271, 11);
            this.Bouton_Integrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bouton_Integrer.Name = "Bouton_Integrer";
            this.Bouton_Integrer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Bouton_Integrer.Size = new System.Drawing.Size(100, 60);
            this.Bouton_Integrer.TabIndex = 1;
            this.Bouton_Integrer.Text = "Integrer";
            this.Bouton_Integrer.UseVisualStyleBackColor = true;
            this.Bouton_Integrer.Click += new System.EventHandler(this.Bouton_Integrer_Click);
            // 
            // Buton_MAJ
            // 
            this.Buton_MAJ.Location = new System.Drawing.Point(271, 84);
            this.Buton_MAJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Buton_MAJ.Name = "Buton_MAJ";
            this.Buton_MAJ.Size = new System.Drawing.Size(100, 60);
            this.Buton_MAJ.TabIndex = 2;
            this.Buton_MAJ.Text = "Mise à jour";
            this.Buton_MAJ.UseVisualStyleBackColor = true;
            this.Buton_MAJ.Click += new System.EventHandler(this.Buton_MAJ_Click);
            // 
            // Fenetre_Selection_XML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 159);
            this.Controls.Add(this.Buton_MAJ);
            this.Controls.Add(this.Bouton_Integrer);
            this.Controls.Add(this.Bouton_Parcourir);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fenetre_Selection_XML";
            this.Text = "Fenetre_Selection_XML";
            this.Load += new System.EventHandler(this.Fenetre_Selection_XML_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bouton_Parcourir;
        private System.Windows.Forms.Button Bouton_Integrer;
        private System.Windows.Forms.Button Buton_MAJ;

    }
}