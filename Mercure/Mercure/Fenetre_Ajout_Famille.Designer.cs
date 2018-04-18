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
            this.olala_la_la = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // olala_la_la
            // 
            this.olala_la_la.Location = new System.Drawing.Point(100, 81);
            this.olala_la_la.Name = "olala_la_la";
            this.olala_la_la.Size = new System.Drawing.Size(75, 23);
            this.olala_la_la.TabIndex = 0;
            this.olala_la_la.Text = "olala la la";
            this.olala_la_la.UseVisualStyleBackColor = true;
            this.olala_la_la.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fenetre_Ajout_Famille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.olala_la_la);
            this.Name = "Fenetre_Ajout_Famille";
            this.Text = "Fenetre_Ajout_Famille";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button olala_la_la;
    }
}