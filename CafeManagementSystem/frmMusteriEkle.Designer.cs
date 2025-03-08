namespace BarkodluSatis
{
    partial class frmMusteriEkle
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.lSandart2 = new BarkodluSatis.lSandart();
            this.lSandart4 = new BarkodluSatis.lSandart();
            this.lSandart5 = new BarkodluSatis.lSandart();
            this.btnMusteriKaydet = new BarkodluSatis.bStandart();
            this.lSandart3 = new BarkodluSatis.lSandart();
            this.lSandart1 = new BarkodluSatis.lSandart();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(152, 114);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(278, 30);
            this.txtAd.TabIndex = 23;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(152, 171);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(278, 30);
            this.txtTelefon.TabIndex = 24;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(152, 228);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(278, 30);
            this.txtAdres.TabIndex = 25;
            // 
            // txtEposta
            // 
            this.txtEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.Location = new System.Drawing.Point(152, 285);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(278, 30);
            this.txtEposta.TabIndex = 27;
            // 
            // lSandart2
            // 
            this.lSandart2.AutoSize = true;
            this.lSandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lSandart2.Location = new System.Drawing.Point(50, 286);
            this.lSandart2.Name = "lSandart2";
            this.lSandart2.Size = new System.Drawing.Size(82, 29);
            this.lSandart2.TabIndex = 26;
            this.lSandart2.Text = "Gmail:";
            // 
            // lSandart4
            // 
            this.lSandart4.AutoSize = true;
            this.lSandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lSandart4.Location = new System.Drawing.Point(48, 229);
            this.lSandart4.Name = "lSandart4";
            this.lSandart4.Size = new System.Drawing.Size(82, 29);
            this.lSandart4.TabIndex = 19;
            this.lSandart4.Text = "Adres:";
            // 
            // lSandart5
            // 
            this.lSandart5.AutoSize = true;
            this.lSandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lSandart5.Location = new System.Drawing.Point(34, 172);
            this.lSandart5.Name = "lSandart5";
            this.lSandart5.Size = new System.Drawing.Size(102, 29);
            this.lSandart5.TabIndex = 18;
            this.lSandart5.Text = "Telefon:";
            // 
            // btnMusteriKaydet
            // 
            this.btnMusteriKaydet.BackColor = System.Drawing.Color.Tomato;
            this.btnMusteriKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMusteriKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriKaydet.ForeColor = System.Drawing.Color.White;
            this.btnMusteriKaydet.Location = new System.Drawing.Point(175, 363);
            this.btnMusteriKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnMusteriKaydet.Name = "btnMusteriKaydet";
            this.btnMusteriKaydet.Size = new System.Drawing.Size(233, 68);
            this.btnMusteriKaydet.TabIndex = 12;
            this.btnMusteriKaydet.Text = "Kişi Kaydet";
            this.btnMusteriKaydet.UseVisualStyleBackColor = false;
            this.btnMusteriKaydet.Click += new System.EventHandler(this.btnMusteriKaydet_Click);
            // 
            // lSandart3
            // 
            this.lSandart3.AutoSize = true;
            this.lSandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lSandart3.Location = new System.Drawing.Point(122, 37);
            this.lSandart3.Name = "lSandart3";
            this.lSandart3.Size = new System.Drawing.Size(338, 36);
            this.lSandart3.TabIndex = 17;
            this.lSandart3.Text = "Veresiye için kişi ekleme";
            // 
            // lSandart1
            // 
            this.lSandart1.AutoSize = true;
            this.lSandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lSandart1.Location = new System.Drawing.Point(14, 115);
            this.lSandart1.Name = "lSandart1";
            this.lSandart1.Size = new System.Drawing.Size(122, 29);
            this.lSandart1.TabIndex = 13;
            this.lSandart1.Text = "Ad Soyad:";
            // 
            // frmMusteriEkle
            // 
            this.AcceptButton = this.btnMusteriKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 484);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.lSandart2);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lSandart4);
            this.Controls.Add(this.lSandart5);
            this.Controls.Add(this.btnMusteriKaydet);
            this.Controls.Add(this.lSandart3);
            this.Controls.Add(this.lSandart1);
            this.Name = "frmMusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.frmMusteriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private lSandart lSandart4;
        private lSandart lSandart5;
        private bStandart btnMusteriKaydet;
        private lSandart lSandart3;
        private lSandart lSandart1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private lSandart lSandart2;
        private System.Windows.Forms.TextBox txtEposta;
    }
}