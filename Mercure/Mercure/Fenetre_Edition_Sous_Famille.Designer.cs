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
            this.Bouton_Ajout_SF = new System.Windows.Forms.Button();
            this.Bouton_Edit_SF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Bouton_Quitter = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Bouton_Ajout_SF
            // 
            this.Bouton_Ajout_SF.Location = new System.Drawing.Point(315, 44);
            this.Bouton_Ajout_SF.Name = "Bouton_Ajout_SF";
            this.Bouton_Ajout_SF.Size = new System.Drawing.Size(83, 23);
            this.Bouton_Ajout_SF.TabIndex = 0;
            this.Bouton_Ajout_SF.Text = "Ajout";
            this.Bouton_Ajout_SF.UseVisualStyleBackColor = true;
            this.Bouton_Ajout_SF.Click += new System.EventHandler(this.Bouton_Ajout_SF_Click);
            // 
            // Bouton_Edit_SF
            // 
            this.Bouton_Edit_SF.Location = new System.Drawing.Point(315, 92);
            this.Bouton_Edit_SF.Name = "Bouton_Edit_SF";
            this.Bouton_Edit_SF.Size = new System.Drawing.Size(83, 23);
            this.Bouton_Edit_SF.TabIndex = 1;
            this.Bouton_Edit_SF.Text = "Edition";
            this.Bouton_Edit_SF.UseVisualStyleBackColor = true;
            this.Bouton_Edit_SF.Click += new System.EventHandler(this.Bouton_Edit_SF_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bouton_Quitter
            // 
            this.Bouton_Quitter.Location = new System.Drawing.Point(315, 317);
            this.Bouton_Quitter.Name = "Bouton_Quitter";
            this.Bouton_Quitter.Size = new System.Drawing.Size(83, 23);
            this.Bouton_Quitter.TabIndex = 3;
            this.Bouton_Quitter.Text = "Quitter";
            this.Bouton_Quitter.UseVisualStyleBackColor = true;
            this.Bouton_Quitter.Click += new System.EventHandler(this.Bouton_Quitter_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(296, 327);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Fenetre_Edition_Sous_Famille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 352);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Bouton_Quitter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bouton_Edit_SF);
            this.Controls.Add(this.Bouton_Ajout_SF);
            this.Name = "Fenetre_Edition_Sous_Famille";
            this.Text = "Fenetre_Edition_Sous_Famille";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bouton_Ajout_SF;
        private System.Windows.Forms.Button Bouton_Edit_SF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Bouton_Quitter;
        private System.Windows.Forms.ListView listView1;
    }
}