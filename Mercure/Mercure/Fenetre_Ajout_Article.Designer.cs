using System.Drawing;

namespace Mercure
{
    partial class Fenetre_Ajout_Article
    {
        private void InitializeComponent()
        {
            this.Description_Article_Edition = new System.Windows.Forms.TextBox();
            this.Reference_Article_Titre = new System.Windows.Forms.Label();
            this.Description_Article_Label = new System.Windows.Forms.Label();
            this.Reference_Article_Edition = new System.Windows.Forms.TextBox();
            this.Famille_Article_Titre = new System.Windows.Forms.Label();
            this.Sous_Famille_Article_Titre = new System.Windows.Forms.Label();
            this.Marque_Article_Titre = new System.Windows.Forms.Label();
            this.Choix_Famille_Article = new System.Windows.Forms.ComboBox();
            this.Choix_Sous_Famille_Article = new System.Windows.Forms.ComboBox();
            this.Choix_Marque_Article = new System.Windows.Forms.ComboBox();
            this.Prix_Unitaire_Article_Titre = new System.Windows.Forms.Label();
            this.Quantite_Article_Titre = new System.Windows.Forms.Label();
            this.Zone_Autres_Informations_Titre = new System.Windows.Forms.Label();
            this.Zone_Description_Article_Titre = new System.Windows.Forms.Label();
            this.Quantite_Article_Edition = new System.Windows.Forms.NumericUpDown();
            this.Prix_Unitaire_Article_Edition = new System.Windows.Forms.NumericUpDown();
            this.Bouton_Validation = new System.Windows.Forms.Button();
            this.Bouton_Annulation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Quantite_Article_Edition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prix_Unitaire_Article_Edition)).BeginInit();
            this.SuspendLayout();
            // 
            // Description_Article_Edition
            // 
            this.Description_Article_Edition.Location = new System.Drawing.Point(21, 182);
            this.Description_Article_Edition.Multiline = true;
            this.Description_Article_Edition.Name = "Description_Article_Edition";
            this.Description_Article_Edition.Size = new System.Drawing.Size(346, 98);
            this.Description_Article_Edition.TabIndex = 0;
            // 
            // Reference_Article_Titre
            // 
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
            // Reference_Article_Edition
            // 
            this.Reference_Article_Edition.Location = new System.Drawing.Point(21, 68);
            this.Reference_Article_Edition.Name = "Reference_Article_Edition";
            this.Reference_Article_Edition.Size = new System.Drawing.Size(150, 20);
            this.Reference_Article_Edition.TabIndex = 3;
            this.Reference_Article_Edition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Reference_Article_Edition_KeyPress);
            // 
            // Famille_Article_Titre
            // 
            this.Famille_Article_Titre.AutoSize = true;
            this.Famille_Article_Titre.Location = new System.Drawing.Point(18, 107);
            this.Famille_Article_Titre.Name = "Famille_Article_Titre";
            this.Famille_Article_Titre.Size = new System.Drawing.Size(39, 13);
            this.Famille_Article_Titre.TabIndex = 4;
            this.Famille_Article_Titre.Text = "Famille";
            // 
            // Sous_Famille_Article_Titre
            // 
            this.Sous_Famille_Article_Titre.AutoSize = true;
            this.Sous_Famille_Article_Titre.Location = new System.Drawing.Point(211, 107);
            this.Sous_Famille_Article_Titre.Name = "Sous_Famille_Article_Titre";
            this.Sous_Famille_Article_Titre.Size = new System.Drawing.Size(63, 13);
            this.Sous_Famille_Article_Titre.TabIndex = 5;
            this.Sous_Famille_Article_Titre.Text = "Sous famille";
            // 
            // Marque_Article_Titre
            // 
            this.Marque_Article_Titre.AutoSize = true;
            this.Marque_Article_Titre.Location = new System.Drawing.Point(211, 52);
            this.Marque_Article_Titre.Name = "Marque_Article_Titre";
            this.Marque_Article_Titre.Size = new System.Drawing.Size(43, 13);
            this.Marque_Article_Titre.TabIndex = 6;
            this.Marque_Article_Titre.Text = "Marque";
            // 
            // Choix_Famille_Article
            // 
            this.Choix_Famille_Article.FormattingEnabled = true;
            this.Choix_Famille_Article.Location = new System.Drawing.Point(21, 123);
            this.Choix_Famille_Article.Name = "Choix_Famille_Article";
            this.Choix_Famille_Article.Size = new System.Drawing.Size(150, 21);
            this.Choix_Famille_Article.TabIndex = 7;
            // 
            // Choix_Sous_Famille_Article
            // 
            this.Choix_Sous_Famille_Article.FormattingEnabled = true;
            this.Choix_Sous_Famille_Article.Location = new System.Drawing.Point(217, 123);
            this.Choix_Sous_Famille_Article.Name = "Choix_Sous_Famille_Article";
            this.Choix_Sous_Famille_Article.Size = new System.Drawing.Size(150, 21);
            this.Choix_Sous_Famille_Article.TabIndex = 8;
            // 
            // Choix_Marque_Article
            // 
            this.Choix_Marque_Article.FormattingEnabled = true;
            this.Choix_Marque_Article.Location = new System.Drawing.Point(214, 68);
            this.Choix_Marque_Article.Name = "Choix_Marque_Article";
            this.Choix_Marque_Article.Size = new System.Drawing.Size(153, 21);
            this.Choix_Marque_Article.TabIndex = 9;
            // 
            // Prix_Unitaire_Article_Titre
            // 
            this.Prix_Unitaire_Article_Titre.AutoSize = true;
            this.Prix_Unitaire_Article_Titre.Location = new System.Drawing.Point(18, 349);
            this.Prix_Unitaire_Article_Titre.Name = "Prix_Unitaire_Article_Titre";
            this.Prix_Unitaire_Article_Titre.Size = new System.Drawing.Size(118, 13);
            this.Prix_Unitaire_Article_Titre.TabIndex = 11;
            this.Prix_Unitaire_Article_Titre.Text = "Prix unitaire (hors taxes)";
            // 
            // Quantite_Article_Titre
            // 
            this.Quantite_Article_Titre.AutoSize = true;
            this.Quantite_Article_Titre.Location = new System.Drawing.Point(214, 349);
            this.Quantite_Article_Titre.Name = "Quantite_Article_Titre";
            this.Quantite_Article_Titre.Size = new System.Drawing.Size(47, 13);
            this.Quantite_Article_Titre.TabIndex = 12;
            this.Quantite_Article_Titre.Text = "Quantité";
            // 
            // Zone_Autres_Informations_Titre
            // 
            this.Zone_Autres_Informations_Titre.AutoSize = true;
            this.Zone_Autres_Informations_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Zone_Autres_Informations_Titre.Location = new System.Drawing.Point(18, 315);
            this.Zone_Autres_Informations_Titre.Name = "Zone_Autres_Informations_Titre";
            this.Zone_Autres_Informations_Titre.Size = new System.Drawing.Size(115, 13);
            this.Zone_Autres_Informations_Titre.TabIndex = 15;
            this.Zone_Autres_Informations_Titre.Text = "Autres informations";
            // 
            // Zone_Description_Article_Titre
            // 
            this.Zone_Description_Article_Titre.AutoSize = true;
            this.Zone_Description_Article_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Zone_Description_Article_Titre.Location = new System.Drawing.Point(18, 22);
            this.Zone_Description_Article_Titre.Name = "Zone_Description_Article_Titre";
            this.Zone_Description_Article_Titre.Size = new System.Drawing.Size(134, 13);
            this.Zone_Description_Article_Titre.TabIndex = 16;
            this.Zone_Description_Article_Titre.Text = "Description de l\'article";
            // 
            // Quantite_Article_Edition
            // 
            this.Quantite_Article_Edition.Location = new System.Drawing.Point(217, 366);
            this.Quantite_Article_Edition.Name = "Quantite_Article_Edition";
            this.Quantite_Article_Edition.Size = new System.Drawing.Size(68, 20);
            this.Quantite_Article_Edition.TabIndex = 17;
            // 
            // Prix_Unitaire_Article_Edition
            // 
            this.Prix_Unitaire_Article_Edition.DecimalPlaces = 2;
            this.Prix_Unitaire_Article_Edition.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Prix_Unitaire_Article_Edition.Location = new System.Drawing.Point(21, 366);
            this.Prix_Unitaire_Article_Edition.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Prix_Unitaire_Article_Edition.Name = "Prix_Unitaire_Article_Edition";
            this.Prix_Unitaire_Article_Edition.Size = new System.Drawing.Size(70, 20);
            this.Prix_Unitaire_Article_Edition.TabIndex = 18;
            // 
            // Bouton_Validation
            // 
            this.Bouton_Validation.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Bouton_Validation.Location = new System.Drawing.Point(199, 427);
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
            this.Bouton_Annulation.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bouton_Annulation.Location = new System.Drawing.Point(292, 427);
            this.Bouton_Annulation.Name = "Bouton_Annulation";
            this.Bouton_Annulation.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Annulation.TabIndex = 20;
            this.Bouton_Annulation.Text = "Annuler";
            this.Bouton_Annulation.UseVisualStyleBackColor = true;
            // 
            // Fenetre_Ajout_Article
            // 
            this.AcceptButton = this.Bouton_Validation;
            this.CancelButton = this.Bouton_Annulation;
            this.ClientSize = new System.Drawing.Size(390, 462);
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
            this.Name = "Fenetre_Ajout_Article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.Quantite_Article_Edition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prix_Unitaire_Article_Edition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox Description_Article_Edition;
        private System.Windows.Forms.Label Reference_Article_Titre;
        private System.Windows.Forms.Label Description_Article_Label;
        private System.Windows.Forms.TextBox Reference_Article_Edition;
        private System.Windows.Forms.Label Famille_Article_Titre;
        private System.Windows.Forms.Label Sous_Famille_Article_Titre;
        private System.Windows.Forms.Label Marque_Article_Titre;
        private System.Windows.Forms.ComboBox Choix_Famille_Article;
        private System.Windows.Forms.ComboBox Choix_Sous_Famille_Article;
        private System.Windows.Forms.ComboBox Choix_Marque_Article;
        private System.Windows.Forms.Label Prix_Unitaire_Article_Titre;
        private System.Windows.Forms.Label Quantite_Article_Titre;
        private System.Windows.Forms.Label Zone_Autres_Informations_Titre;
        private System.Windows.Forms.Label Zone_Description_Article_Titre;
        private System.Windows.Forms.NumericUpDown Quantite_Article_Edition;
        private System.Windows.Forms.NumericUpDown Prix_Unitaire_Article_Edition;
        private System.Windows.Forms.Button Bouton_Validation;
        private System.Windows.Forms.Button Bouton_Annulation;
    }
}