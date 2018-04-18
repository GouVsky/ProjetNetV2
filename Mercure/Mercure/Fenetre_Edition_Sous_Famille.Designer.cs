namespace Mercure
{
    partial class Fenetre_Edition_Sous_Famille
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
            this.Bouton_Quitter = new System.Windows.Forms.Button();
            this.Bouton_Supprimer = new System.Windows.Forms.Button();
            this.Bouton_Modifier = new System.Windows.Forms.Button();
            this.Bouton_Ajouter = new System.Windows.Forms.Button();
            this.Sous_Familles_Liste = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Bouton_Quitter
            // 
            this.Bouton_Quitter.Location = new System.Drawing.Point(221, 273);
            this.Bouton_Quitter.Name = "Bouton_Quitter";
            this.Bouton_Quitter.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Quitter.TabIndex = 9;
            this.Bouton_Quitter.Text = "Quitter";
            this.Bouton_Quitter.UseVisualStyleBackColor = true;
            this.Bouton_Quitter.Click += new System.EventHandler(this.Bouton_Quitter_Click);
            // 
            // Bouton_Supprimer
            // 
            this.Bouton_Supprimer.Location = new System.Drawing.Point(221, 89);
            this.Bouton_Supprimer.Name = "Bouton_Supprimer";
            this.Bouton_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Supprimer.TabIndex = 8;
            this.Bouton_Supprimer.Text = "Supprimer";
            this.Bouton_Supprimer.UseVisualStyleBackColor = true;
            this.Bouton_Supprimer.Click += new System.EventHandler(this.Bouton_Supprimer_Click);
            // 
            // Bouton_Modifier
            // 
            this.Bouton_Modifier.Location = new System.Drawing.Point(221, 50);
            this.Bouton_Modifier.Name = "Bouton_Modifier";
            this.Bouton_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Modifier.TabIndex = 7;
            this.Bouton_Modifier.Text = "Modifier";
            this.Bouton_Modifier.UseVisualStyleBackColor = true;
            this.Bouton_Modifier.Click += new System.EventHandler(this.Bouton_Modifier_Click);
            // 
            // Bouton_Ajouter
            // 
            this.Bouton_Ajouter.Location = new System.Drawing.Point(221, 12);
            this.Bouton_Ajouter.Name = "Bouton_Ajouter";
            this.Bouton_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Bouton_Ajouter.TabIndex = 6;
            this.Bouton_Ajouter.Text = "Ajouter";
            this.Bouton_Ajouter.UseVisualStyleBackColor = true;
            this.Bouton_Ajouter.Click += new System.EventHandler(this.Bouton_Ajouter_Click);
            // 
            // Sous_Familles_Liste
            // 
            this.Sous_Familles_Liste.FullRowSelect = true;
            this.Sous_Familles_Liste.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.Sous_Familles_Liste.Location = new System.Drawing.Point(12, 12);
            this.Sous_Familles_Liste.MultiSelect = false;
            this.Sous_Familles_Liste.Name = "Sous_Familles_Liste";
            this.Sous_Familles_Liste.Size = new System.Drawing.Size(192, 284);
            this.Sous_Familles_Liste.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Sous_Familles_Liste.TabIndex = 5;
            this.Sous_Familles_Liste.UseCompatibleStateImageBehavior = false;
            this.Sous_Familles_Liste.View = System.Windows.Forms.View.Details;
            // 
            // Fenetre_Edition_Sous_Famille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 306);
            this.Controls.Add(this.Bouton_Quitter);
            this.Controls.Add(this.Bouton_Supprimer);
            this.Controls.Add(this.Bouton_Modifier);
            this.Controls.Add(this.Bouton_Ajouter);
            this.Controls.Add(this.Sous_Familles_Liste);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Fenetre_Edition_Sous_Famille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fenetre_Edition_Sous_Famille";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bouton_Quitter;
        private System.Windows.Forms.Button Bouton_Supprimer;
        private System.Windows.Forms.Button Bouton_Modifier;
        private System.Windows.Forms.Button Bouton_Ajouter;
        private System.Windows.Forms.ListView Sous_Familles_Liste;
    }
}