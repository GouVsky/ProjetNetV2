namespace Mercure
{
    partial class Fenetre_Ajout_Famille
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
            this.components = new System.ComponentModel.Container();
            this.Bouton_Validation = new System.Windows.Forms.Button();
            this.Nom_Famille_Titre = new System.Windows.Forms.Label();
            this.Nom_Famille_Edition = new System.Windows.Forms.TextBox();
            this.Bouton_Annuler = new System.Windows.Forms.Button();
            this.Erreur = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).BeginInit();
            this.SuspendLayout();
            // 
            // Bouton_Validation
            // 
            this.Bouton_Validation.Location = new System.Drawing.Point(94, 84);
            this.Bouton_Validation.Margin = new System.Windows.Forms.Padding(2);
            this.Bouton_Validation.Name = "Bouton_Validation";
            this.Bouton_Validation.Size = new System.Drawing.Size(75, 24);
            this.Bouton_Validation.TabIndex = 0;
            this.Bouton_Validation.Text = "Ajouter";
            this.Bouton_Validation.UseVisualStyleBackColor = true;
            this.Bouton_Validation.Click += new System.EventHandler(this.Bouton_Validation_Click);
            // 
            // Nom_Famille_Titre
            // 
            this.Nom_Famille_Titre.AutoSize = true;
            this.Nom_Famille_Titre.Location = new System.Drawing.Point(24, 26);
            this.Nom_Famille_Titre.Name = "Nom_Famille_Titre";
            this.Nom_Famille_Titre.Size = new System.Drawing.Size(29, 13);
            this.Nom_Famille_Titre.TabIndex = 1;
            this.Nom_Famille_Titre.Text = "Nom";
            // 
            // Nom_Famille_Edition
            // 
            this.Nom_Famille_Edition.Location = new System.Drawing.Point(27, 42);
            this.Nom_Famille_Edition.Name = "Nom_Famille_Edition";
            this.Nom_Famille_Edition.Size = new System.Drawing.Size(231, 20);
            this.Nom_Famille_Edition.TabIndex = 2;
            // 
            // Bouton_Annuler
            // 
            this.Bouton_Annuler.Location = new System.Drawing.Point(183, 84);
            this.Bouton_Annuler.Name = "Bouton_Annuler";
            this.Bouton_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Annuler.TabIndex = 3;
            this.Bouton_Annuler.Text = "Annuler";
            this.Bouton_Annuler.UseVisualStyleBackColor = true;
            this.Bouton_Annuler.Click += new System.EventHandler(this.Bouton_Annuler_Click);
            // 
            // Erreur
            // 
            this.Erreur.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Erreur.ContainerControl = this;
            // 
            // Fenetre_Ajout_Famille
            // 
            this.AcceptButton = this.Bouton_Validation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 120);
            this.Controls.Add(this.Bouton_Annuler);
            this.Controls.Add(this.Nom_Famille_Edition);
            this.Controls.Add(this.Nom_Famille_Titre);
            this.Controls.Add(this.Bouton_Validation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Fenetre_Ajout_Famille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fenetre_Ajout_Famille";
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bouton_Validation;
        private System.Windows.Forms.Label Nom_Famille_Titre;
        private System.Windows.Forms.TextBox Nom_Famille_Edition;
        private System.Windows.Forms.Button Bouton_Annuler;
        private System.Windows.Forms.ErrorProvider Erreur;
    }
}