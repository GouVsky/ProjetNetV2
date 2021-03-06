﻿namespace Mercure
{
    partial class Fenetre_Ajout_Article
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
            this.Description_Titre = new System.Windows.Forms.Label();
            this.Reference_Article_Edition = new System.Windows.Forms.TextBox();
            this.Reference_Article_Titre = new System.Windows.Forms.Label();
            this.Marque_Article_Edition = new System.Windows.Forms.Label();
            this.Famille_Article_Titre = new System.Windows.Forms.Label();
            this.Sous_Famille_Article_Titre = new System.Windows.Forms.Label();
            this.Description_Article_Titre = new System.Windows.Forms.Label();
            this.Prix_Article_Titre = new System.Windows.Forms.Label();
            this.Quantite_Article_Titre = new System.Windows.Forms.Label();
            this.Choix_Marque_Article = new System.Windows.Forms.ComboBox();
            this.Choix_Famille_Article = new System.Windows.Forms.ComboBox();
            this.Choix_Sous_Famille_Article = new System.Windows.Forms.ComboBox();
            this.Description_Article_Edition = new System.Windows.Forms.TextBox();
            this.Informations_Titre = new System.Windows.Forms.Label();
            this.Prix_Unitaire_Article_Edition = new System.Windows.Forms.NumericUpDown();
            this.Quantite_Article_Edition = new System.Windows.Forms.NumericUpDown();
            this.Bouton_Validation = new System.Windows.Forms.Button();
            this.Bouton_Annulation = new System.Windows.Forms.Button();
            this.Erreur = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Prix_Unitaire_Article_Edition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantite_Article_Edition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).BeginInit();
            this.SuspendLayout();
            // 
            // Description_Titre
            // 
            this.Description_Titre.AutoSize = true;
            this.Description_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_Titre.Location = new System.Drawing.Point(31, 23);
            this.Description_Titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description_Titre.Name = "Description_Titre";
            this.Description_Titre.Size = new System.Drawing.Size(171, 17);
            this.Description_Titre.TabIndex = 0;
            this.Description_Titre.Text = "Description de l\'article";
            // 
            // Reference_Article_Edition
            // 
            this.Reference_Article_Edition.Location = new System.Drawing.Point(35, 81);
            this.Reference_Article_Edition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reference_Article_Edition.Name = "Reference_Article_Edition";
            this.Reference_Article_Edition.Size = new System.Drawing.Size(224, 22);
            this.Reference_Article_Edition.TabIndex = 1;
            this.Reference_Article_Edition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Reference_Article_Edition_KeyPress);
            this.Reference_Article_Edition.Validating += new System.ComponentModel.CancelEventHandler(this.Reference_Article_Edition_Validating);
            this.Reference_Article_Edition.Validated += new System.EventHandler(this.Reference_Article_Edition_Validated);
            // 
            // Reference_Article_Titre
            // 
            this.Reference_Article_Titre.AutoSize = true;
            this.Reference_Article_Titre.Location = new System.Drawing.Point(31, 62);
            this.Reference_Article_Titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Reference_Article_Titre.Name = "Reference_Article_Titre";
            this.Reference_Article_Titre.Size = new System.Drawing.Size(74, 17);
            this.Reference_Article_Titre.TabIndex = 2;
            this.Reference_Article_Titre.Text = "Reference";
            // 
            // Marque_Article_Edition
            // 
            this.Marque_Article_Edition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Marque_Article_Edition.AutoSize = true;
            this.Marque_Article_Edition.Location = new System.Drawing.Point(300, 62);
            this.Marque_Article_Edition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Marque_Article_Edition.Name = "Marque_Article_Edition";
            this.Marque_Article_Edition.Size = new System.Drawing.Size(56, 17);
            this.Marque_Article_Edition.TabIndex = 3;
            this.Marque_Article_Edition.Text = "Marque";
            // 
            // Famille_Article_Titre
            // 
            this.Famille_Article_Titre.AutoSize = true;
            this.Famille_Article_Titre.Location = new System.Drawing.Point(31, 137);
            this.Famille_Article_Titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Famille_Article_Titre.Name = "Famille_Article_Titre";
            this.Famille_Article_Titre.Size = new System.Drawing.Size(52, 17);
            this.Famille_Article_Titre.TabIndex = 4;
            this.Famille_Article_Titre.Text = "Famille";
            // 
            // Sous_Famille_Article_Titre
            // 
            this.Sous_Famille_Article_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sous_Famille_Article_Titre.AutoSize = true;
            this.Sous_Famille_Article_Titre.Location = new System.Drawing.Point(300, 135);
            this.Sous_Famille_Article_Titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sous_Famille_Article_Titre.Name = "Sous_Famille_Article_Titre";
            this.Sous_Famille_Article_Titre.Size = new System.Drawing.Size(89, 17);
            this.Sous_Famille_Article_Titre.TabIndex = 5;
            this.Sous_Famille_Article_Titre.Text = "Sous-Famille";
            // 
            // Description_Article_Titre
            // 
            this.Description_Article_Titre.AutoSize = true;
            this.Description_Article_Titre.Location = new System.Drawing.Point(31, 214);
            this.Description_Article_Titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description_Article_Titre.Name = "Description_Article_Titre";
            this.Description_Article_Titre.Size = new System.Drawing.Size(79, 17);
            this.Description_Article_Titre.TabIndex = 6;
            this.Description_Article_Titre.Text = "Description";
            // 
            // Prix_Article_Titre
            // 
            this.Prix_Article_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Prix_Article_Titre.AutoSize = true;
            this.Prix_Article_Titre.Location = new System.Drawing.Point(35, 414);
            this.Prix_Article_Titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prix_Article_Titre.Name = "Prix_Article_Titre";
            this.Prix_Article_Titre.Size = new System.Drawing.Size(161, 17);
            this.Prix_Article_Titre.TabIndex = 7;
            this.Prix_Article_Titre.Text = "Prix unitaire (hors taxes)";
            // 
            // Quantite_Article_Titre
            // 
            this.Quantite_Article_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Quantite_Article_Titre.AutoSize = true;
            this.Quantite_Article_Titre.Location = new System.Drawing.Point(300, 414);
            this.Quantite_Article_Titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quantite_Article_Titre.Name = "Quantite_Article_Titre";
            this.Quantite_Article_Titre.Size = new System.Drawing.Size(62, 17);
            this.Quantite_Article_Titre.TabIndex = 8;
            this.Quantite_Article_Titre.Text = "Quantité";
            // 
            // Choix_Marque_Article
            // 
            this.Choix_Marque_Article.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Choix_Marque_Article.FormattingEnabled = true;
            this.Choix_Marque_Article.Location = new System.Drawing.Point(304, 81);
            this.Choix_Marque_Article.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Choix_Marque_Article.Name = "Choix_Marque_Article";
            this.Choix_Marque_Article.Size = new System.Drawing.Size(224, 24);
            this.Choix_Marque_Article.TabIndex = 9;
            this.Choix_Marque_Article.Validating += new System.ComponentModel.CancelEventHandler(this.Choix_Marque_Article_Validating);
            this.Choix_Marque_Article.Validated += new System.EventHandler(this.Choix_Marque_Article_Validated);
            // 
            // Choix_Famille_Article
            // 
            this.Choix_Famille_Article.FormattingEnabled = true;
            this.Choix_Famille_Article.Location = new System.Drawing.Point(35, 156);
            this.Choix_Famille_Article.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Choix_Famille_Article.Name = "Choix_Famille_Article";
            this.Choix_Famille_Article.Size = new System.Drawing.Size(224, 24);
            this.Choix_Famille_Article.TabIndex = 10;
            this.Choix_Famille_Article.SelectedIndexChanged += new System.EventHandler(this.Choix_Famille_Article_SelectedIndexChanged);
            this.Choix_Famille_Article.Validating += new System.ComponentModel.CancelEventHandler(this.Choix_Famille_Article_Validating);
            this.Choix_Famille_Article.Validated += new System.EventHandler(this.Choix_Famille_Article_Validated);
            // 
            // Choix_Sous_Famille_Article
            // 
            this.Choix_Sous_Famille_Article.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Choix_Sous_Famille_Article.FormattingEnabled = true;
            this.Choix_Sous_Famille_Article.Location = new System.Drawing.Point(304, 155);
            this.Choix_Sous_Famille_Article.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Choix_Sous_Famille_Article.Name = "Choix_Sous_Famille_Article";
            this.Choix_Sous_Famille_Article.Size = new System.Drawing.Size(224, 24);
            this.Choix_Sous_Famille_Article.TabIndex = 11;
            this.Choix_Sous_Famille_Article.Validating += new System.ComponentModel.CancelEventHandler(this.Choix_Sous_Famille_Article_Validating);
            this.Choix_Sous_Famille_Article.Validated += new System.EventHandler(this.Choix_Sous_Famille_Article_Validated);
            // 
            // Description_Article_Edition
            // 
            this.Description_Article_Edition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description_Article_Edition.Location = new System.Drawing.Point(35, 234);
            this.Description_Article_Edition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Description_Article_Edition.Multiline = true;
            this.Description_Article_Edition.Name = "Description_Article_Edition";
            this.Description_Article_Edition.Size = new System.Drawing.Size(493, 104);
            this.Description_Article_Edition.TabIndex = 12;
            this.Description_Article_Edition.Validating += new System.ComponentModel.CancelEventHandler(this.Description_Article_Edition_Validating);
            this.Description_Article_Edition.Validated += new System.EventHandler(this.Description_Article_Edition_Validated);
            // 
            // Informations_Titre
            // 
            this.Informations_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Informations_Titre.AutoSize = true;
            this.Informations_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informations_Titre.Location = new System.Drawing.Point(35, 377);
            this.Informations_Titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Informations_Titre.Name = "Informations_Titre";
            this.Informations_Titre.Size = new System.Drawing.Size(149, 17);
            this.Informations_Titre.TabIndex = 13;
            this.Informations_Titre.Text = "Autres informations";
            // 
            // Prix_Unitaire_Article_Edition
            // 
            this.Prix_Unitaire_Article_Edition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Prix_Unitaire_Article_Edition.DecimalPlaces = 2;
            this.Prix_Unitaire_Article_Edition.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Prix_Unitaire_Article_Edition.Location = new System.Drawing.Point(39, 434);
            this.Prix_Unitaire_Article_Edition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Prix_Unitaire_Article_Edition.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Prix_Unitaire_Article_Edition.Name = "Prix_Unitaire_Article_Edition";
            this.Prix_Unitaire_Article_Edition.Size = new System.Drawing.Size(97, 22);
            this.Prix_Unitaire_Article_Edition.TabIndex = 14;
            this.Prix_Unitaire_Article_Edition.Validating += new System.ComponentModel.CancelEventHandler(this.Prix_Unitaire_Article_Edition_Validating);
            this.Prix_Unitaire_Article_Edition.Validated += new System.EventHandler(this.Prix_Unitaire_Article_Edition_Validated);
            // 
            // Quantite_Article_Edition
            // 
            this.Quantite_Article_Edition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Quantite_Article_Edition.Location = new System.Drawing.Point(304, 434);
            this.Quantite_Article_Edition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Quantite_Article_Edition.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Quantite_Article_Edition.Name = "Quantite_Article_Edition";
            this.Quantite_Article_Edition.Size = new System.Drawing.Size(97, 22);
            this.Quantite_Article_Edition.TabIndex = 15;
            this.Quantite_Article_Edition.Validating += new System.ComponentModel.CancelEventHandler(this.Quantite_Article_Edition_Validating);
            this.Quantite_Article_Edition.Validated += new System.EventHandler(this.Quantite_Article_Edition_Validated);
            // 
            // Bouton_Validation
            // 
            this.Bouton_Validation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bouton_Validation.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Bouton_Validation.Location = new System.Drawing.Point(321, 501);
            this.Bouton_Validation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bouton_Validation.Name = "Bouton_Validation";
            this.Bouton_Validation.Size = new System.Drawing.Size(100, 28);
            this.Bouton_Validation.TabIndex = 16;
            this.Bouton_Validation.Text = "Ajouter";
            this.Bouton_Validation.UseVisualStyleBackColor = true;
            this.Bouton_Validation.Click += new System.EventHandler(this.Bouton_Validation_Click);
            // 
            // Bouton_Annulation
            // 
            this.Bouton_Annulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bouton_Annulation.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bouton_Annulation.Location = new System.Drawing.Point(429, 501);
            this.Bouton_Annulation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bouton_Annulation.Name = "Bouton_Annulation";
            this.Bouton_Annulation.Size = new System.Drawing.Size(100, 28);
            this.Bouton_Annulation.TabIndex = 17;
            this.Bouton_Annulation.Text = "Annuler";
            this.Bouton_Annulation.UseVisualStyleBackColor = true;
            this.Bouton_Annulation.Click += new System.EventHandler(this.Bouton_Annulation_Click);
            // 
            // Erreur
            // 
            this.Erreur.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Erreur.ContainerControl = this;
            // 
            // Fenetre_Ajout_Article
            // 
            this.AcceptButton = this.Bouton_Validation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.Bouton_Annulation;
            this.ClientSize = new System.Drawing.Size(563, 544);
            this.Controls.Add(this.Bouton_Annulation);
            this.Controls.Add(this.Bouton_Validation);
            this.Controls.Add(this.Quantite_Article_Edition);
            this.Controls.Add(this.Prix_Unitaire_Article_Edition);
            this.Controls.Add(this.Informations_Titre);
            this.Controls.Add(this.Description_Article_Edition);
            this.Controls.Add(this.Choix_Sous_Famille_Article);
            this.Controls.Add(this.Choix_Famille_Article);
            this.Controls.Add(this.Choix_Marque_Article);
            this.Controls.Add(this.Quantite_Article_Titre);
            this.Controls.Add(this.Prix_Article_Titre);
            this.Controls.Add(this.Description_Article_Titre);
            this.Controls.Add(this.Sous_Famille_Article_Titre);
            this.Controls.Add(this.Famille_Article_Titre);
            this.Controls.Add(this.Marque_Article_Edition);
            this.Controls.Add(this.Reference_Article_Titre);
            this.Controls.Add(this.Reference_Article_Edition);
            this.Controls.Add(this.Description_Titre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(540, 510);
            this.Name = "Fenetre_Ajout_Article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.Prix_Unitaire_Article_Edition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantite_Article_Edition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Description_Titre;
        private System.Windows.Forms.TextBox Reference_Article_Edition;
        private System.Windows.Forms.Label Reference_Article_Titre;
        private System.Windows.Forms.Label Marque_Article_Edition;
        private System.Windows.Forms.Label Famille_Article_Titre;
        private System.Windows.Forms.Label Sous_Famille_Article_Titre;
        private System.Windows.Forms.Label Description_Article_Titre;
        private System.Windows.Forms.Label Prix_Article_Titre;
        private System.Windows.Forms.Label Quantite_Article_Titre;
        private System.Windows.Forms.ComboBox Choix_Marque_Article;
        private System.Windows.Forms.ComboBox Choix_Famille_Article;
        private System.Windows.Forms.ComboBox Choix_Sous_Famille_Article;
        private System.Windows.Forms.TextBox Description_Article_Edition;
        private System.Windows.Forms.Label Informations_Titre;
        private System.Windows.Forms.NumericUpDown Prix_Unitaire_Article_Edition;
        private System.Windows.Forms.NumericUpDown Quantite_Article_Edition;
        private System.Windows.Forms.Button Bouton_Validation;
        private System.Windows.Forms.Button Bouton_Annulation;
        private System.Windows.Forms.ErrorProvider Erreur;
    }
}