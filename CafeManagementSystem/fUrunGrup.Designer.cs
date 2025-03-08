namespace BarkodluSatis
{
    partial class fUrunGrup
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
            this.lSandart1 = new BarkodluSatis.lSandart();
            this.tUrunGrupAd = new BarkodluSatis.tStandart();
            this.listUrunGrup = new System.Windows.Forms.ListBox();
            this.bSil = new BarkodluSatis.bStandart();
            this.bEkle = new BarkodluSatis.bStandart();
            this.SuspendLayout();
            // 
            // lSandart1
            // 
            this.lSandart1.AutoSize = true;
            this.lSandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart1.Location = new System.Drawing.Point(12, 23);
            this.lSandart1.Name = "lSandart1";
            this.lSandart1.Size = new System.Drawing.Size(147, 25);
            this.lSandart1.TabIndex = 0;
            this.lSandart1.Text = "Ürün Grubu Adı";
            // 
            // tUrunGrupAd
            // 
            this.tUrunGrupAd.BackColor = System.Drawing.Color.White;
            this.tUrunGrupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunGrupAd.Location = new System.Drawing.Point(12, 61);
            this.tUrunGrupAd.Name = "tUrunGrupAd";
            this.tUrunGrupAd.Size = new System.Drawing.Size(360, 30);
            this.tUrunGrupAd.TabIndex = 2;
            // 
            // listUrunGrup
            // 
            this.listUrunGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUrunGrup.FormattingEnabled = true;
            this.listUrunGrup.ItemHeight = 25;
            this.listUrunGrup.Location = new System.Drawing.Point(12, 97);
            this.listUrunGrup.Name = "listUrunGrup";
            this.listUrunGrup.Size = new System.Drawing.Size(360, 229);
            this.listUrunGrup.TabIndex = 3;
            // 
            // bSil
            // 
            this.bSil.BackColor = System.Drawing.Color.Tomato;
            this.bSil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.ForeColor = System.Drawing.Color.White;
            this.bSil.Image = global::BarkodluSatis.Properties.Resources.cancel242;
            this.bSil.Location = new System.Drawing.Point(33, 329);
            this.bSil.Margin = new System.Windows.Forms.Padding(0);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(156, 81);
            this.bSil.TabIndex = 4;
            this.bSil.Text = "Sil";
            this.bSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bSil.UseVisualStyleBackColor = false;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.Lime;
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.ForeColor = System.Drawing.Color.White;
            this.bEkle.Image = global::BarkodluSatis.Properties.Resources.Ekle24;
            this.bEkle.Location = new System.Drawing.Point(200, 329);
            this.bEkle.Margin = new System.Windows.Forms.Padding(0);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(156, 81);
            this.bEkle.TabIndex = 0;
            this.bEkle.Text = "Ekle";
            this.bEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // fUrunGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.listUrunGrup);
            this.Controls.Add(this.tUrunGrupAd);
            this.Controls.Add(this.lSandart1);
            this.Name = "fUrunGrup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Grup İşlemleri";
            this.Load += new System.EventHandler(this.fUrunGrup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lSandart lSandart1;
        private tStandart tUrunGrupAd;
        private System.Windows.Forms.ListBox listUrunGrup;
        private bStandart bEkle;
        private bStandart bSil;
    }
}