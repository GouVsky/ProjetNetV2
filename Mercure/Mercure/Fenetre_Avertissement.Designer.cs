namespace Mercure
{
    partial class Fenetre_Avertissement
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Buton_Oui = new System.Windows.Forms.Button();
            this.Buton_Non = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 40);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Attention, cette integration remplacera intégralement votre base de donnée actuel" +
    "le, continuer quand même?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Buton_Oui
            // 
            this.Buton_Oui.Location = new System.Drawing.Point(12, 88);
            this.Buton_Oui.Name = "Buton_Oui";
            this.Buton_Oui.Size = new System.Drawing.Size(108, 43);
            this.Buton_Oui.TabIndex = 1;
            this.Buton_Oui.Text = "Oui";
            this.Buton_Oui.UseVisualStyleBackColor = true;
            this.Buton_Oui.Click += new System.EventHandler(this.Buton_Oui_Click);
            // 
            // Buton_Non
            // 
            this.Buton_Non.Location = new System.Drawing.Point(336, 88);
            this.Buton_Non.Name = "Buton_Non";
            this.Buton_Non.Size = new System.Drawing.Size(108, 43);
            this.Buton_Non.TabIndex = 2;
            this.Buton_Non.Text = "Non";
            this.Buton_Non.UseVisualStyleBackColor = true;
            this.Buton_Non.Click += new System.EventHandler(this.Buton_Non_Click);
            // 
            // Fenetre_Avertissement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 143);
            this.Controls.Add(this.Buton_Non);
            this.Controls.Add(this.Buton_Oui);
            this.Controls.Add(this.textBox1);
            this.Name = "Fenetre_Avertissement";
            this.Text = "Fenetre_Avertissement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Buton_Oui;
        private System.Windows.Forms.Button Buton_Non;
    }
}