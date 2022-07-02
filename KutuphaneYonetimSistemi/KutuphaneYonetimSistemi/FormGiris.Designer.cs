namespace KutuphaneYonetimSistemi
{
    partial class FormGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGiris = new System.Windows.Forms.Button();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(193, 227);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(100, 38);
            this.buttonGiris.TabIndex = 0;
            this.buttonGiris.Text = "Giriş";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(193, 90);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(100, 23);
            this.textBoxKullaniciAdi.TabIndex = 1;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(193, 152);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(100, 23);
            this.textBoxSifre.TabIndex = 2;
            this.textBoxSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "KullanıcıAdı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(68, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre :";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(406, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.buttonGiris);
            this.Name = "FormGiris";
            this.Text = "Kütüphane Yönetim Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonGiris;
        private TextBox textBoxKullaniciAdi;
        private TextBox textBoxSifre;
        private Label label2;
        private Label label3;
    }
}