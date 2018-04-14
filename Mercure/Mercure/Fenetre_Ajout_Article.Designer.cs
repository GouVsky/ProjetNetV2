using System.Drawing;

namespace Mercure
{
    partial class Fenetre_Ajout_Article
    {
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Description_Article_Edition = new System.Windows.Forms.TextBox();
            this.Reference_Article_Titre = new System.Windows.Forms.Label();
            this.Description_Article_Label = new System.Windows.Forms.Label();
            this.Famille_Article_Titre = new System.Windows.Forms.Label();
            this.Sous_Famille_Article_Titre = new System.Windows.Forms.Label();
            this.Marque_Article_Titre = new System.Windows.Forms.Label();
            this.Choix_Famille_Article = new System.Windows.Forms.ComboBox();
            this.Choix_Sous_Famille_Article = new System.Windows.Forms.ComboBox();
            this.Prix_Unitaire_Article_Titre = new System.Windows.Forms.Label();
            this.Quantite_Article_Titre = new System.Windows.Forms.Label();
            this.Zone_Autres_Informations_Titre = new System.Windows.Forms.Label();
            this.Zone_Description_Article_Titre = new System.Windows.Forms.Label();
            this.Quantite_Article_Edition = new System.Windows.Forms.NumericUpDown();
            this.Prix_Unitaire_Article_Edition = new System.Windows.Forms.NumericUpDown();
            this.Bouton_Validation = new System.Windows.Forms.Button();
            this.Bouton_Annulation = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Choix_Marque_Article = new System.Windows.Forms.ComboBox();
            this.Reference_Article_Edition = new System.Windows.Forms.TextBox();
            this.Erreur = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Quantite_Article_Edition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prix_Unitaire_Article_Edition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).BeginInit();
            this.SuspendLayout();
            // 
            // Description_Article_Edition
            // 
            this.Description_Article_Edition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description_Article_Edition.Location = new System.Drawing.Point(21, 182);
            this.Description_Article_Edition.Multiline = true;
            this.Description_Article_Edition.Name = "Description_Article_Edition";
            this.Description_Article_Edition.Size = new System.Drawing.Size(390, 62);
            this.Description_Article_Edition.TabIndex = 4;
            this.Description_Article_Edition.Validating += new System.ComponentModel.CancelEventHandler(this.Description_Article_Edition_Validating);
            this.Description_Article_Edition.Validated += new System.EventHandler(this.Description_Article_Edition_Validated);
            // 
            // Reference_Article_Titre
            // 
            this.Reference_Article_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Reference_Article_Titre.AutoSize = true;
            this.Reference_Article_Titre.Location = new System.Drawing.Point(18, 52);
            this.Reference_Article_Titre.Name = "Reference_Article_Titre";
            this.Reference_Article_Titre.Size = new System.Drawing.Size(57, 13);
            this.Reference_Article_Titre.TabIndex = 1;
            this.Reference_Article_Titre.Text = "Référence";
            // 
            // Description_Article_Label
            // 
            this.Description_Article_Label.AutoSize = true;
            this.Description_Article_Label.Location = new System.Drawing.Point(18, 166);
            this.Description_Article_Label.Name = "Description_Article_Label";
            this.Description_Article_Label.Size = new System.Drawing.Size(60, 13);
            this.Description_Article_Label.TabIndex = 2;
            this.Description_Article_Label.Text = "Description";
            // 
            // Famille_Article_Titre
            // 
            this.Famille_Article_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Famille_Article_Titre.AutoSize = true;
            this.Famille_Article_Titre.Location = new System.Drawing.Point(18, 107);
            this.Famille_Article_Titre.Name = "Famille_Article_Titre";
            this.Famille_Article_Titre.Size = new System.Drawing.Size(39, 13);
            this.Famille_Article_Titre.TabIndex = 4;
            this.Famille_Article_Titre.Text = "Famille";
            // 
            // Sous_Famille_Article_Titre
            // 
            this.Sous_Famille_Article_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sous_Famille_Article_Titre.AutoSize = true;
            this.Sous_Famille_Article_Titre.Location = new System.Drawing.Point(223, 107);
            this.Sous_Famille_Article_Titre.Name = "Sous_Famille_Article_Titre";
            this.Sous_Famille_Article_Titre.Size = new System.Drawing.Size(63, 13);
            this.Sous_Famille_Article_Titre.TabIndex = 5;
            this.Sous_Famille_Article_Titre.Text = "Sous famille";
            // 
            // Marque_Article_Titre
            // 
            this.Marque_Article_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Marque_Article_Titre.AutoSize = true;
            this.Marque_Article_Titre.Location = new System.Drawing.Point(223, 52);
            this.Marque_Article_Titre.Name = "Marque_Article_Titre";
            this.Marque_Article_Titre.Size = new System.Drawing.Size(43, 13);
            this.Marque_Article_Titre.TabIndex = 6;
            this.Marque_Article_Titre.Text = "Marque";
            // 
            // Choix_Famille_Article
            // 
            this.Choix_Famille_Article.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Choix_Famille_Article.FormattingEnabled = true;
            this.Choix_Famille_Article.Location = new System.Drawing.Point(21, 123);
            this.Choix_Famille_Article.Name = "Choix_Famille_Article";
            this.Choix_Famille_Article.Size = new System.Drawing.Size(185, 21);
            this.Choix_Famille_Article.Sorted = true;
            this.Choix_Famille_Article.TabIndex = 2;
            this.Choix_Famille_Article.Text = "Sélectionnez une famille";
            this.Choix_Famille_Article.Validating += new System.ComponentModel.CancelEventHandler(this.Choix_Famille_Article_Validating);
            this.Choix_Famille_Article.Validated += new System.EventHandler(this.Choix_Famille_Article_Validated);
            // 
            // Choix_Sous_Famille_Article
            // 
            this.Choix_Sous_Famille_Article.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Choix_Sous_Famille_Article.FormattingEnabled = true;
            this.Choix_Sous_Famille_Article.Location = new System.Drawing.Point(226, 123);
            this.Choix_Sous_Famille_Article.Name = "Choix_Sous_Famille_Article";
            this.Choix_Sous_Famille_Article.Size = new System.Drawing.Size(185, 21);
            this.Choix_Sous_Famille_Article.Sorted = true;
            this.Choix_Sous_Famille_Article.TabIndex = 3;
            this.Choix_Sous_Famille_Article.Text = "Sélectionnez une sous-famille";
            this.Choix_Sous_Famille_Article.Validating += new System.ComponentModel.CancelEventHandler(this.Choix_Sous_Famille_Article_Validating);
            this.Choix_Sous_Famille_Article.Validated += new System.EventHandler(this.Choix_Sous_Famille_Article_Validated);
            // 
            // Prix_Unitaire_Article_Titre
            // 
            this.Prix_Unitaire_Article_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prix_Unitaire_Article_Titre.AutoSize = true;
            this.Prix_Unitaire_Article_Titre.Location = new System.Drawing.Point(18, 301);
            this.Prix_Unitaire_Article_Titre.Name = "Prix_Unitaire_Article_Titre";
            this.Prix_Unitaire_Article_Titre.Size = new System.Drawing.Size(118, 13);
            this.Prix_Unitaire_Article_Titre.TabIndex = 11;
            this.Prix_Unitaire_Article_Titre.Text = "Prix unitaire (hors taxes)";
            // 
            // Quantite_Article_Titre
            // 
            this.Quantite_Article_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Quantite_Article_Titre.AutoSize = true;
            this.Quantite_Article_Titre.Location = new System.Drawing.Point(239, 301);
            this.Quantite_Article_Titre.Name = "Quantite_Article_Titre";
            this.Quantite_Article_Titre.Size = new System.Drawing.Size(47, 13);
            this.Quantite_Article_Titre.TabIndex = 12;
            this.Quantite_Article_Titre.Text = "Quantité";
            // 
            // Zone_Autres_Informations_Titre
            // 
            this.Zone_Autres_Informations_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Zone_Autres_Informations_Titre.AutoSize = true;
            this.Zone_Autres_Informations_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Zone_Autres_Informations_Titre.Location = new System.Drawing.Point(18, 275);
            this.Zone_Autres_Informations_Titre.Name = "Zone_Autres_Informations_Titre";
            this.Zone_Autres_Informations_Titre.Size = new System.Drawing.Size(115, 13);
            this.Zone_Autres_Informations_Titre.TabIndex = 15;
            this.Zone_Autres_Informations_Titre.Text = "Autres informations";
            // 
            // Zone_Description_Article_Titre
            // 
            this.Zone_Description_Article_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Zone_Description_Article_Titre.Location = new System.Drawing.Point(18, 22);
            this.Zone_Description_Article_Titre.Name = "Zone_Description_Article_Titre";
            this.Zone_Description_Article_Titre.Size = new System.Drawing.Size(171, 17);
            this.Zone_Description_Article_Titre.TabIndex = 16;
            this.Zone_Description_Article_Titre.Text = "Description de l\'article";
            // 
            // Quantite_Article_Edition
            // 
            this.Quantite_Article_Edition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Quantite_Article_Edition.Location = new System.Drawing.Point(242, 317);
            this.Quantite_Article_Edition.Name = "Quantite_Article_Edition";
            this.Quantite_Article_Edition.Size = new System.Drawing.Size(68, 20);
            this.Quantite_Article_Edition.TabIndex = 6;
            this.Quantite_Article_Edition.Validating += new System.ComponentModel.CancelEventHandler(this.Quantite_Article_Edition_Validating);
            this.Quantite_Article_Edition.Validated += new System.EventHandler(this.Quantite_Article_Edition_Validated);
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
            this.Prix_Unitaire_Article_Edition.Location = new System.Drawing.Point(21, 317);
            this.Prix_Unitaire_Article_Edition.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Prix_Unitaire_Article_Edition.Name = "Prix_Unitaire_Article_Edition";
            this.Prix_Unitaire_Article_Edition.Size = new System.Drawing.Size(70, 20);
            this.Prix_Unitaire_Article_Edition.TabIndex = 5;
            this.Prix_Unitaire_Article_Edition.Validating += new System.ComponentModel.CancelEventHandler(this.Prix_Unitaire_Article_Edition_Validating);
            this.Prix_Unitaire_Article_Edition.Validated += new System.EventHandler(this.Prix_Unitaire_Article_Edition_Validated);
            // 
            // Bouton_Validation
            // 
            this.Bouton_Validation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bouton_Validation.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Bouton_Validation.Location = new System.Drawing.Point(252, 371);
            this.Bouton_Validation.Name = "Bouton_Validation";
            this.Bouton_Validation.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Validation.TabIndex = 19;
            this.Bouton_Validation.Tag = "";
            this.Bouton_Validation.Text = "Ajouter";
            this.Bouton_Validation.UseVisualStyleBackColor = true;
            this.Bouton_Validation.Click += new System.EventHandler(this.Bouton_Validation_Click);
            // 
            // Bouton_Annulation
            // 
            this.Bouton_Annulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bouton_Annulation.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bouton_Annulation.Location = new System.Drawing.Point(336, 371);
            this.Bouton_Annulation.Name = "Bouton_Annulation";
            this.Bouton_Annulation.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Annulation.TabIndex = 20;
            this.Bouton_Annulation.Text = "Annuler";
            this.Bouton_Annulation.UseVisualStyleBackColor = true;
            // 
            // Choix_Marque_Article
            // 
            this.Choix_Marque_Article.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Choix_Marque_Article.FormattingEnabled = true;
            this.Choix_Marque_Article.Location = new System.Drawing.Point(226, 68);
            this.Choix_Marque_Article.Name = "Choix_Marque_Article";
            this.Choix_Marque_Article.Size = new System.Drawing.Size(185, 21);
            this.Choix_Marque_Article.Sorted = true;
            this.Choix_Marque_Article.TabIndex = 1;
            this.Choix_Marque_Article.Text = "Sélectionnez une marque";
            this.Choix_Marque_Article.Validating += new System.ComponentModel.CancelEventHandler(this.Choix_Marque_Article_Validating);
            this.Choix_Marque_Article.Validated += new System.EventHandler(this.Choix_Marque_Article_Validated);
            // 
            // Reference_Article_Edition
            // 
            this.Reference_Article_Edition.Location = new System.Drawing.Point(21, 68);
            this.Reference_Article_Edition.Name = "Reference_Article_Edition";
            this.Reference_Article_Edition.Size = new System.Drawing.Size(185, 20);
            this.Reference_Article_Edition.TabIndex = 0;
            this.Reference_Article_Edition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Reference_Article_Edition_KeyPress);
            this.Reference_Article_Edition.Validating += new System.ComponentModel.CancelEventHandler(this.Reference_Article_Edition_Validating);
            this.Reference_Article_Edition.Validated += new System.EventHandler(this.Reference_Article_Edition_Validated);
            // 
            // Erreur
            // 
            this.Erreur.BlinkRate = 0;
            this.Erreur.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Erreur.ContainerControl = this;
            this.Erreur.RightToLeftChanged += new System.EventHandler(this.Bouton_Validation_Click);
            // 
            // Fenetre_Ajout_Article
            // 
            this.AcceptButton = this.Bouton_Validation;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.Bouton_Annulation;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.Bouton_Annulation);
            this.Controls.Add(this.Bouton_Validation);
            this.Controls.Add(this.Prix_Unitaire_Article_Edition);
            this.Controls.Add(this.Quantite_Article_Edition);
            this.Controls.Add(this.Zone_Description_Article_Titre);
            this.Controls.Add(this.Zone_Autres_Informations_Titre);
            this.Controls.Add(this.Quantite_Article_Titre);
            this.Controls.Add(this.Prix_Unitaire_Article_Titre);
            this.Controls.Add(this.Choix_Marque_Article);
            this.Controls.Add(this.Choix_Sous_Famille_Article);
            this.Controls.Add(this.Choix_Famille_Article);
            this.Controls.Add(this.Marque_Article_Titre);
            this.Controls.Add(this.Sous_Famille_Article_Titre);
            this.Controls.Add(this.Famille_Article_Titre);
            this.Controls.Add(this.Reference_Article_Edition);
            this.Controls.Add(this.Description_Article_Label);
            this.Controls.Add(this.Reference_Article_Titre);
            this.Controls.Add(this.Description_Article_Edition);
            this.MaximumSize = new System.Drawing.Size(800, 1080);
            this.MinimumSize = new System.Drawing.Size(430, 400);
            this.Name = "Fenetre_Ajout_Article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.Quantite_Article_Edition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prix_Unitaire_Article_Edition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox Description_Article_Edition;
        private System.Windows.Forms.Label Reference_Article_Titre;
        private System.Windows.Forms.Label Description_Article_Label;
        private System.Windows.Forms.Label Famille_Article_Titre;
        private System.Windows.Forms.Label Sous_Famille_Article_Titre;
        private System.Windows.Forms.Label Marque_Article_Titre;
        private System.Windows.Forms.ComboBox Choix_Famille_Article;
        private System.Windows.Forms.ComboBox Choix_Sous_Famille_Article;
        private System.Windows.Forms.Label Prix_Unitaire_Article_Titre;
        private System.Windows.Forms.Label Quantite_Article_Titre;
        private System.Windows.Forms.Label Zone_Autres_Informations_Titre;
        private System.Windows.Forms.Label Zone_Description_Article_Titre;
        private System.Windows.Forms.NumericUpDown Quantite_Article_Edition;
        private System.Windows.Forms.NumericUpDown Prix_Unitaire_Article_Edition;
        private System.Windows.Forms.Button Bouton_Validation;
        private System.Windows.Forms.Button Bouton_Annulation;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox Choix_Marque_Article;
        private System.Windows.Forms.TextBox Reference_Article_Edition;
        private System.Windows.Forms.ErrorProvider Erreur;
        private System.ComponentModel.IContainer components;
    }
}