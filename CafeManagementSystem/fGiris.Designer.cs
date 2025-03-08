namespace BarkodluSatis
{
    partial class fGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGiris));
            this.tKullanici = new System.Windows.Forms.TextBox();
            this.tSifre = new System.Windows.Forms.TextBox();
            this.bGiris = new BarkodluSatis.bStandart();
            this.lSandart3 = new BarkodluSatis.lSandart();
            this.lSandart2 = new BarkodluSatis.lSandart();
            this.lSandart1 = new BarkodluSatis.lSandart();
            this.SuspendLayout();
            // 
            // tKullanici
            // 
            this.tKullanici.Location = new System.Drawing.Point(143, 77);
            this.tKullanici.Name = "tKullanici";
            this.tKullanici.Size = new System.Drawing.Size(198, 30);
            this.tKullanici.TabIndex = 1;
            // 
            // tSifre
            // 
            this.tSifre.Location = new System.Drawing.Point(143, 129);
            this.tSifre.Name = "tSifre";
            this.tSifre.PasswordChar = '*';
            this.tSifre.Size = new System.Drawing.Size(198, 30);
            this.tSifre.TabIndex = 2;
            // 
            // bGiris
            // 
            this.bGiris.BackColor = System.Drawing.Color.YellowGreen;
            this.bGiris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGiris.ForeColor = System.Drawing.Color.White;
            this.bGiris.Location = new System.Drawing.Point(199, 171);
            this.bGiris.Margin = new System.Windows.Forms.Padding(0);
            this.bGiris.Name = "bGiris";
            this.bGiris.Size = new System.Drawing.Size(142, 38);
            this.bGiris.TabIndex = 3;
            this.bGiris.Text = "Giriş Yap";
            this.bGiris.UseVisualStyleBackColor = false;
            this.bGiris.Click += new System.EventHandler(this.bGiris_Click);
            this.bGiris.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bGiris_KeyDown);
            // 
            // lSandart3
            // 
            this.lSandart3.AutoSize = true;
            this.lSandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart3.ForeColor = System.Drawing.Color.Red;
            this.lSandart3.Location = new System.Drawing.Point(174, 23);
            this.lSandart3.Name = "lSandart3";
            this.lSandart3.Size = new System.Drawing.Size(70, 25);
            this.lSandart3.TabIndex = 4;
            this.lSandart3.Text = "CAFE";
            // 
            // lSandart2
            // 
            this.lSandart2.AutoSize = true;
            this.lSandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart2.ForeColor = System.Drawing.Color.Black;
            this.lSandart2.Location = new System.Drawing.Point(93, 129);
            this.lSandart2.Name = "lSandart2";
            this.lSandart2.Size = new System.Drawing.Size(44, 20);
            this.lSandart2.TabIndex = 25;
            this.lSandart2.Text = "Şifre";
            // 
            // lSandart1
            // 
            this.lSandart1.AutoSize = true;
            this.lSandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart1.ForeColor = System.Drawing.Color.Black;
            this.lSandart1.Location = new System.Drawing.Point(36, 84);
            this.lSandart1.Name = "lSandart1";
            this.lSandart1.Size = new System.Drawing.Size(101, 20);
            this.lSandart1.TabIndex = 23;
            this.lSandart1.Text = "Kullanıcı Adı";
            // 
            // fGiris
            // 
            this.AcceptButton = this.bGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(419, 240);
            this.Controls.Add(this.bGiris);
            this.Controls.Add(this.lSandart3);
            this.Controls.Add(this.tSifre);
            this.Controls.Add(this.lSandart2);
            this.Controls.Add(this.tKullanici);
            this.Controls.Add(this.lSandart1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private lSandart lSandart1;
        private lSandart lSandart2;
        private lSandart lSandart3;
        private bStandart bGiris;
        private System.Windows.Forms.TextBox tKullanici;
        private System.Windows.Forms.TextBox tSifre;
    }
}