namespace Mercure
{
    partial class Fenetre_Ajout_Sous_Famille
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
            this.Nom_Sous_Famille_Edition = new System.Windows.Forms.TextBox();
            this.Nom_Sous_Famille_Titre = new System.Windows.Forms.Label();
            this.Bouton_Validation = new System.Windows.Forms.Button();
            this.Erreur = new System.Windows.Forms.ErrorProvider(this.components);
            this.Choix_Famille_Titre = new System.Windows.Forms.Label();
            this.Choix_Famille_Selection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).BeginInit();
            this.SuspendLayout();
            // 
            // Bouton_Annuler
            // 
            this.Bouton_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bouton_Annuler.Location = new System.Drawing.Point(181, 145);
            this.Bouton_Annuler.Name = "Bouton_Annuler";
            this.Bouton_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Annuler.TabIndex = 7;
            this.Bouton_Annuler.Text = "Annuler";
            this.Bouton_Annuler.UseVisualStyleBackColor = true;
            this.Bouton_Annuler.Click += new System.EventHandler(this.Bouton_Annuler_Click);
            // 
            // Nom_Sous_Famille_Edition
            // 
            this.Nom_Sous_Famille_Edition.Location = new System.Drawing.Point(25, 35);
            this.Nom_Sous_Famille_Edition.Name = "Nom_Sous_Famille_Edition";
            this.Nom_Sous_Famille_Edition.Size = new System.Drawing.Size(231, 20);
            this.Nom_Sous_Famille_Edition.TabIndex = 0;
            this.Nom_Sous_Famille_Edition.Validating += new System.ComponentModel.CancelEventHandler(this.Nom_Sous_Famille_Edition_Validating);
            this.Nom_Sous_Famille_Edition.Validated += new System.EventHandler(this.Nom_Sous_Famille_Edition_Validated);
            // 
            // Nom_Sous_Famille_Titre
            // 
            this.Nom_Sous_Famille_Titre.AutoSize = true;
            this.Nom_Sous_Famille_Titre.Location = new System.Drawing.Point(22, 19);
            this.Nom_Sous_Famille_Titre.Name = "Nom_Sous_Famille_Titre";
            this.Nom_Sous_Famille_Titre.Size = new System.Drawing.Size(29, 13);
            this.Nom_Sous_Famille_Titre.TabIndex = 5;
            this.Nom_Sous_Famille_Titre.Text = "Nom";
            // 
            // Bouton_Validation
            // 
            this.Bouton_Validation.Location = new System.Drawing.Point(89, 145);
            this.Bouton_Validation.Margin = new System.Windows.Forms.Padding(2);
            this.Bouton_Validation.Name = "Bouton_Validation";
            this.Bouton_Validation.Size = new System.Drawing.Size(75, 24);
            this.Bouton_Validation.TabIndex = 4;
            this.Bouton_Validation.Text = "Ajouter";
            this.Bouton_Validation.UseVisualStyleBackColor = true;
            this.Bouton_Validation.Click += new System.EventHandler(this.Bouton_Validation_Click);
            // 
            // Erreur
            // 
            this.Erreur.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Erreur.ContainerControl = this;
            // 
            // Choix_Famille_Titre
            // 
            this.Choix_Famille_Titre.AutoSize = true;
            this.Choix_Famille_Titre.Location = new System.Drawing.Point(22, 76);
            this.Choix_Famille_Titre.Name = "Choix_Famille_Titre";
            this.Choix_Famille_Titre.Size = new System.Drawing.Size(39, 13);
            this.Choix_Famille_Titre.TabIndex = 8;
            this.Choix_Famille_Titre.Text = "Famille";
            // 
            // Choix_Famille_Selection
            // 
            this.Choix_Famille_Selection.FormattingEnabled = true;
            this.Choix_Famille_Selection.Location = new System.Drawing.Point(25, 92);
            this.Choix_Famille_Selection.Name = "Choix_Famille_Selection";
            this.Choix_Famille_Selection.Size = new System.Drawing.Size(231, 21);
            this.Choix_Famille_Selection.TabIndex = 1;
            this.Choix_Famille_Selection.Text = "Veuillez sélectionner une famille";
            this.Choix_Famille_Selection.Validating += new System.ComponentModel.CancelEventHandler(this.Choix_Famille_Selection_Validating);
            this.Choix_Famille_Selection.Validated += new System.EventHandler(this.Choix_Famille_Selection_Validated);
            // 
            // Fenetre_Ajout_Sous_Famille
            // 
            this.AcceptButton = this.Bouton_Validation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Bouton_Annuler;
            this.ClientSize = new System.Drawing.Size(280, 180);
            this.Controls.Add(this.Choix_Famille_Selection);
            this.Controls.Add(this.Choix_Famille_Titre);
            this.Controls.Add(this.Bouton_Annuler);
            this.Controls.Add(this.Nom_Sous_Famille_Edition);
            this.Controls.Add(this.Nom_Sous_Famille_Titre);
            this.Controls.Add(this.Bouton_Validation);
            this.Name = "Fenetre_Ajout_Sous_Famille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fenetre_Ajout_Sous_Famille";
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bouton_Annuler;
        private System.Windows.Forms.TextBox Nom_Sous_Famille_Edition;
        private System.Windows.Forms.Label Nom_Sous_Famille_Titre;
        private System.Windows.Forms.Button Bouton_Validation;
        private System.Windows.Forms.ErrorProvider Erreur;
        private System.Windows.Forms.ComboBox Choix_Famille_Selection;
        private System.Windows.Forms.Label Choix_Famille_Titre;
    }
}