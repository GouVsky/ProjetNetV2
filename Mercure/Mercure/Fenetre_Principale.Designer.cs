namespace Mercure
{
    partial class Fenetre_Principale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.Barre_Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_Fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Fichier_Import_XML = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Fichier_Quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edition = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Affichage = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Apropos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Aide = new System.Windows.Forms.ToolStripMenuItem();
            this.Barre_De_Statut = new System.Windows.Forms.StatusStrip();
            this.Barre_De_Statut_Texte = new System.Windows.Forms.ToolStripStatusLabel();
            this.Affichage_Articles = new System.Windows.Forms.ListView();
            this.Barre_Menu.SuspendLayout();
            this.Barre_De_Statut.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barre_Menu
            // 
            this.Barre_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Fichier,
            this.Menu_Edition,
            this.Menu_Affichage,
            this.Menu_Apropos,
            this.Menu_Aide});
            this.Barre_Menu.Location = new System.Drawing.Point(0, 0);
            this.Barre_Menu.Name = "Barre_Menu";
            this.Barre_Menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Barre_Menu.Size = new System.Drawing.Size(939, 24);
            this.Barre_Menu.TabIndex = 0;
            this.Barre_Menu.Text = "Menu";
            // 
            // Menu_Fichier
            // 
            this.Menu_Fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Fichier_Import_XML,
            this.Menu_Fichier_Quitter});
            this.Menu_Fichier.Name = "Menu_Fichier";
            this.Menu_Fichier.Size = new System.Drawing.Size(54, 20);
            this.Menu_Fichier.Text = "Fichier";
            // 
            // Menu_Fichier_Import_XML
            // 
            this.Menu_Fichier_Import_XML.Name = "Menu_Fichier_Import_XML";
            this.Menu_Fichier_Import_XML.Size = new System.Drawing.Size(147, 22);
            this.Menu_Fichier_Import_XML.Text = "Importer XML";
            this.Menu_Fichier_Import_XML.Click += new System.EventHandler(this.Menu_Fichier_Import_XML_Click);
            // 
            // Menu_Fichier_Quitter
            // 
            this.Menu_Fichier_Quitter.Name = "Menu_Fichier_Quitter";
            this.Menu_Fichier_Quitter.Size = new System.Drawing.Size(147, 22);
            this.Menu_Fichier_Quitter.Text = "Quitter";
            this.Menu_Fichier_Quitter.Click += new System.EventHandler(this.Menu_Fichier_Quitter_Click);
            // 
            // Menu_Edition
            // 
            this.Menu_Edition.Name = "Menu_Edition";
            this.Menu_Edition.Size = new System.Drawing.Size(56, 20);
            this.Menu_Edition.Text = "Edition";
            // 
            // Menu_Affichage
            // 
            this.Menu_Affichage.Name = "Menu_Affichage";
            this.Menu_Affichage.Size = new System.Drawing.Size(70, 20);
            this.Menu_Affichage.Text = "Affichage";
            // 
            // Menu_Apropos
            // 
            this.Menu_Apropos.Name = "Menu_Apropos";
            this.Menu_Apropos.Size = new System.Drawing.Size(70, 20);
            this.Menu_Apropos.Text = "A propos ";
            // 
            // Menu_Aide
            // 
            this.Menu_Aide.Name = "Menu_Aide";
            this.Menu_Aide.Size = new System.Drawing.Size(24, 20);
            this.Menu_Aide.Text = "?";
            // 
            // Barre_De_Statut
            // 
            this.Barre_De_Statut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Barre_De_Statut_Texte});
            this.Barre_De_Statut.Location = new System.Drawing.Point(0, 564);
            this.Barre_De_Statut.Name = "Barre_De_Statut";
            this.Barre_De_Statut.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.Barre_De_Statut.Size = new System.Drawing.Size(939, 22);
            this.Barre_De_Statut.TabIndex = 2;
            // 
            // Barre_De_Statut_Texte
            // 
            this.Barre_De_Statut_Texte.Name = "Barre_De_Statut_Texte";
            this.Barre_De_Statut_Texte.Size = new System.Drawing.Size(119, 17);
            this.Barre_De_Statut_Texte.Text = "Etat De La Connexion";
            // 
            // Affichage_Articles
            // 
            this.Affichage_Articles.FullRowSelect = true;
            this.Affichage_Articles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.Affichage_Articles.Location = new System.Drawing.Point(44, 67);
            this.Affichage_Articles.MultiSelect = false;
            this.Affichage_Articles.Name = "Affichage_Articles";
            this.Affichage_Articles.Size = new System.Drawing.Size(855, 449);
            this.Affichage_Articles.TabIndex = 3;
            this.Affichage_Articles.UseCompatibleStateImageBehavior = false;
            this.Affichage_Articles.View = System.Windows.Forms.View.Details;
            this.Affichage_Articles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Affichage_Articles_KeyDown);
            this.Affichage_Articles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Affichage_Articles_MouseClick);
            this.Affichage_Articles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Affichage_Articles_MouseDoubleClick);
            // 
            // Fenetre_Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 586);
            this.Controls.Add(this.Affichage_Articles);
            this.Controls.Add(this.Barre_De_Statut);
            this.Controls.Add(this.Barre_Menu);
            this.MainMenuStrip = this.Barre_Menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Fenetre_Principale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercure";
            this.Barre_Menu.ResumeLayout(false);
            this.Barre_Menu.PerformLayout();
            this.Barre_De_Statut.ResumeLayout(false);
            this.Barre_De_Statut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Barre_Menu;
        private System.Windows.Forms.StatusStrip Barre_De_Statut;
        private System.Windows.Forms.ToolStripMenuItem Menu_Fichier;
        private System.Windows.Forms.ToolStripMenuItem Menu_Fichier_Import_XML;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edition;
        private System.Windows.Forms.ToolStripMenuItem Menu_Affichage;
        private System.Windows.Forms.ToolStripMenuItem Menu_Apropos;
        private System.Windows.Forms.ToolStripMenuItem Menu_Aide;
        private System.Windows.Forms.ToolStripMenuItem Menu_Fichier_Quitter;
        private System.Windows.Forms.ToolStripStatusLabel Barre_De_Statut_Texte;
        private System.Windows.Forms.ListView Affichage_Articles;
    }
}

