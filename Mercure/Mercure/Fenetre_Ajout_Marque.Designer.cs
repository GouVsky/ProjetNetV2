namespace Mercure
{
    partial class Fenetre_Ajout_Marque
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
            this.Bouton_Annuler = new System.Windows.Forms.Button();
            this.Nom_Marque_Edition = new System.Windows.Forms.TextBox();
            this.Nom_Marque_Titre = new System.Windows.Forms.Label();
            this.Bouton_Validation = new System.Windows.Forms.Button();
            this.Erreur = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).BeginInit();
            this.SuspendLayout();
            // 
            // Bouton_Annuler
            // 
            this.Bouton_Annuler.Location = new System.Drawing.Point(182, 71);
            this.Bouton_Annuler.Name = "Bouton_Annuler";
            this.Bouton_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Annuler.TabIndex = 7;
            this.Bouton_Annuler.Text = "Annuler";
            this.Bouton_Annuler.UseVisualStyleBackColor = true;
            this.Bouton_Annuler.Click += new System.EventHandler(this.Bouton_Annuler_Click);
            // 
            // Nom_Marque_Edition
            // 
            this.Nom_Marque_Edition.Location = new System.Drawing.Point(26, 29);
            this.Nom_Marque_Edition.Name = "Nom_Marque_Edition";
            this.Nom_Marque_Edition.Size = new System.Drawing.Size(231, 20);
            this.Nom_Marque_Edition.TabIndex = 4;
            this.Nom_Marque_Edition.Validating += new System.ComponentModel.CancelEventHandler(this.Nom_Marque_Edition_Validating);
            this.Nom_Marque_Edition.Validated += new System.EventHandler(this.Nom_Marque_Edition_Validated);
            // 
            // Nom_Marque_Titre
            // 
            this.Nom_Marque_Titre.AutoSize = true;
            this.Nom_Marque_Titre.Location = new System.Drawing.Point(23, 13);
            this.Nom_Marque_Titre.Name = "Nom_Marque_Titre";
            this.Nom_Marque_Titre.Size = new System.Drawing.Size(29, 13);
            this.Nom_Marque_Titre.TabIndex = 6;
            this.Nom_Marque_Titre.Text = "Nom";
            // 
            // Bouton_Validation
            // 
            this.Bouton_Validation.Location = new System.Drawing.Point(93, 71);
            this.Bouton_Validation.Margin = new System.Windows.Forms.Padding(2);
            this.Bouton_Validation.Name = "Bouton_Validation";
            this.Bouton_Validation.Size = new System.Drawing.Size(75, 24);
            this.Bouton_Validation.TabIndex = 5;
            this.Bouton_Validation.Text = "Ajouter";
            this.Bouton_Validation.UseVisualStyleBackColor = true;
            this.Bouton_Validation.Click += new System.EventHandler(this.Bouton_Validation_Click);
            // 
            // Erreur
            // 
            this.Erreur.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Erreur.ContainerControl = this;
            // 
            // Fenetre_Ajout_Marque
            // 
            this.AcceptButton = this.Bouton_Validation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Bouton_Annuler;
            this.ClientSize = new System.Drawing.Size(285, 108);
            this.Controls.Add(this.Bouton_Annuler);
            this.Controls.Add(this.Nom_Marque_Edition);
            this.Controls.Add(this.Nom_Marque_Titre);
            this.Controls.Add(this.Bouton_Validation);
            this.Name = "Fenetre_Ajout_Marque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bouton_Annuler;
        private System.Windows.Forms.TextBox Nom_Marque_Edition;
        private System.Windows.Forms.Label Nom_Marque_Titre;
        private System.Windows.Forms.Button Bouton_Validation;
        private System.Windows.Forms.ErrorProvider Erreur;
    }
}