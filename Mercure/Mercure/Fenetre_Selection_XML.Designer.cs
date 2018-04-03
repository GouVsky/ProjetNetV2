namespace Mercure
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
            this.Affichage_Chemin_Fichier_XML = new System.Windows.Forms.TextBox();
            this.Bouton_Integrer = new System.Windows.Forms.Button();
            this.Buton_MAJ = new System.Windows.Forms.Button();
            this.Bar_chargement_XML = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Bouton_Parcourir
            // 
            this.Bouton_Parcourir.Location = new System.Drawing.Point(347, 30);
            this.Bouton_Parcourir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bouton_Parcourir.Name = "Bouton_Parcourir";
            this.Bouton_Parcourir.Size = new System.Drawing.Size(100, 28);
            this.Bouton_Parcourir.TabIndex = 0;
            this.Bouton_Parcourir.Text = "Parcourir";
            this.Bouton_Parcourir.UseVisualStyleBackColor = true;
            this.Bouton_Parcourir.Click += new System.EventHandler(this.Parcourir_Click);
            // 
            // Affichage_Chemin_Fichier_XML
            // 
            this.Affichage_Chemin_Fichier_XML.Location = new System.Drawing.Point(29, 32);
            this.Affichage_Chemin_Fichier_XML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Affichage_Chemin_Fichier_XML.Name = "Affichage_Chemin_Fichier_XML";
            this.Affichage_Chemin_Fichier_XML.Size = new System.Drawing.Size(289, 22);
            this.Affichage_Chemin_Fichier_XML.TabIndex = 3;
            // 
            // Bouton_Integrer
            // 
            this.Bouton_Integrer.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Bouton_Integrer.Location = new System.Drawing.Point(29, 86);
            this.Bouton_Integrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bouton_Integrer.Name = "Bouton_Integrer";
            this.Bouton_Integrer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Bouton_Integrer.Size = new System.Drawing.Size(100, 28);
            this.Bouton_Integrer.TabIndex = 1;
            this.Bouton_Integrer.Text = "Integrer";
            this.Bouton_Integrer.UseVisualStyleBackColor = true;
            this.Bouton_Integrer.Click += new System.EventHandler(this.Bouton_Integrer_Click);
            // 
            // Buton_MAJ
            // 
            this.Buton_MAJ.Location = new System.Drawing.Point(218, 86);
            this.Buton_MAJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Buton_MAJ.Name = "Buton_MAJ";
            this.Buton_MAJ.Size = new System.Drawing.Size(100, 28);
            this.Buton_MAJ.TabIndex = 2;
            this.Buton_MAJ.Text = "Mise à jour";
            this.Buton_MAJ.UseVisualStyleBackColor = true;
            this.Buton_MAJ.Click += new System.EventHandler(this.Buton_MAJ_Click);
            // 
            // Bar_chargement_XML
            // 
            this.Bar_chargement_XML.ForeColor = System.Drawing.Color.Lime;
            this.Bar_chargement_XML.Location = new System.Drawing.Point(0, 129);
            this.Bar_chargement_XML.Name = "Bar_chargement_XML";
            this.Bar_chargement_XML.Size = new System.Drawing.Size(477, 23);
            this.Bar_chargement_XML.TabIndex = 4;
            // 
            // Fenetre_Selection_XML
            // 
            this.AcceptButton = this.Bouton_Integrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 151);
            this.Controls.Add(this.Bar_chargement_XML);
            this.Controls.Add(this.Affichage_Chemin_Fichier_XML);
            this.Controls.Add(this.Buton_MAJ);
            this.Controls.Add(this.Bouton_Integrer);
            this.Controls.Add(this.Bouton_Parcourir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fenetre_Selection_XML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fenetre_Selection_XML";
            this.Load += new System.EventHandler(this.Fenetre_Selection_XML_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bouton_Parcourir;
        private System.Windows.Forms.TextBox Affichage_Chemin_Fichier_XML;
        private System.Windows.Forms.Button Buton_MAJ;
        private System.Windows.Forms.Button Bouton_Integrer;
        private System.Windows.Forms.ProgressBar Bar_chargement_XML;
    }
}