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
            this.Bouton_MAJ = new System.Windows.Forms.Button();
            this.Bar_Chargement_XML = new System.Windows.Forms.ProgressBar();
            this.Bouton_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bouton_Parcourir
            // 
            this.Bouton_Parcourir.Location = new System.Drawing.Point(274, 24);
            this.Bouton_Parcourir.Name = "Bouton_Parcourir";
            this.Bouton_Parcourir.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Parcourir.TabIndex = 0;
            this.Bouton_Parcourir.Text = "Parcourir";
            this.Bouton_Parcourir.UseVisualStyleBackColor = true;
            this.Bouton_Parcourir.Click += new System.EventHandler(this.Parcourir_Click);
            // 
            // Affichage_Chemin_Fichier_XML
            // 
            this.Affichage_Chemin_Fichier_XML.Location = new System.Drawing.Point(22, 26);
            this.Affichage_Chemin_Fichier_XML.Name = "Affichage_Chemin_Fichier_XML";
            this.Affichage_Chemin_Fichier_XML.Size = new System.Drawing.Size(236, 20);
            this.Affichage_Chemin_Fichier_XML.TabIndex = 3;
            // 
            // Bouton_Integrer
            // 
            this.Bouton_Integrer.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Bouton_Integrer.Location = new System.Drawing.Point(22, 70);
            this.Bouton_Integrer.Margin = new System.Windows.Forms.Padding(2);
            this.Bouton_Integrer.Name = "Bouton_Integrer";
            this.Bouton_Integrer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Bouton_Integrer.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Integrer.TabIndex = 1;
            this.Bouton_Integrer.Text = "Integrer";
            this.Bouton_Integrer.UseVisualStyleBackColor = true;
            this.Bouton_Integrer.Click += new System.EventHandler(this.Bouton_Integrer_Click);
            // 
            // Bouton_MAJ
            // 
            this.Bouton_MAJ.Location = new System.Drawing.Point(150, 70);
            this.Bouton_MAJ.Name = "Bouton_MAJ";
            this.Bouton_MAJ.Size = new System.Drawing.Size(75, 23);
            this.Bouton_MAJ.TabIndex = 2;
            this.Bouton_MAJ.Text = "Mise à jour";
            this.Bouton_MAJ.UseVisualStyleBackColor = true;
            this.Bouton_MAJ.Click += new System.EventHandler(this.Bouton_MAJ_Click);
            // 
            // Bar_Chargement_XML
            // 
            this.Bar_Chargement_XML.ForeColor = System.Drawing.Color.Lime;
            this.Bar_Chargement_XML.Location = new System.Drawing.Point(0, 110);
            this.Bar_Chargement_XML.Margin = new System.Windows.Forms.Padding(2);
            this.Bar_Chargement_XML.Name = "Bar_Chargement_XML";
            this.Bar_Chargement_XML.Size = new System.Drawing.Size(370, 19);
            this.Bar_Chargement_XML.TabIndex = 4;
            // 
            // Bouton_Annuler
            // 
            this.Bouton_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bouton_Annuler.Location = new System.Drawing.Point(274, 70);
            this.Bouton_Annuler.Name = "Bouton_Annuler";
            this.Bouton_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Annuler.TabIndex = 5;
            this.Bouton_Annuler.Text = "Annuler";
            this.Bouton_Annuler.UseVisualStyleBackColor = true;
            this.Bouton_Annuler.Click += new System.EventHandler(this.Bouton_Annuler_Click);
            // 
            // Fenetre_Selection_XML
            // 
            this.AcceptButton = this.Bouton_Integrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Bouton_Annuler;
            this.ClientSize = new System.Drawing.Size(370, 129);
            this.Controls.Add(this.Bouton_Annuler);
            this.Controls.Add(this.Bar_Chargement_XML);
            this.Controls.Add(this.Affichage_Chemin_Fichier_XML);
            this.Controls.Add(this.Bouton_MAJ);
            this.Controls.Add(this.Bouton_Integrer);
            this.Controls.Add(this.Bouton_Parcourir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button Bouton_MAJ;
        private System.Windows.Forms.Button Bouton_Integrer;
        private System.Windows.Forms.ProgressBar Bar_Chargement_XML;
        private System.Windows.Forms.Button Bouton_Annuler;
    }
}