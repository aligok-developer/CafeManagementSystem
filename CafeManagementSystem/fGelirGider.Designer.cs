namespace BarkodluSatis
{
    partial class fGelirGider
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
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.lGelirGider = new BarkodluSatis.lSandart();
            this.tNakit = new BarkodluSatis.tNumeric();
            this.tKart = new BarkodluSatis.tNumeric();
            this.lSandart3 = new BarkodluSatis.lSandart();
            this.lSandart4 = new BarkodluSatis.lSandart();
            this.tAçiklama = new BarkodluSatis.tStandart();
            this.lSandart5 = new BarkodluSatis.lSandart();
            this.lSandart6 = new BarkodluSatis.lSandart();
            this.dTarih = new System.Windows.Forms.DateTimePicker();
            this.bEkle = new BarkodluSatis.bStandart();
            this.SuspendLayout();
            // 
            // lSandart1
            // 
            this.lSandart1.AutoSize = true;
            this.lSandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart1.Location = new System.Drawing.Point(31, 70);
            this.lSandart1.Name = "lSandart1";
            this.lSandart1.Size = new System.Drawing.Size(123, 25);
            this.lSandart1.TabIndex = 0;
            this.lSandart1.Text = "Ödeme Türü";
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "NAKİT",
            "KART",
            "KART - NAKİT"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(26, 98);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(274, 28);
            this.cmbOdemeTuru.TabIndex = 2;
            this.cmbOdemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeTuru_SelectedIndexChanged);
            // 
            // lGelirGider
            // 
            this.lGelirGider.AutoSize = true;
            this.lGelirGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lGelirGider.ForeColor = System.Drawing.Color.DarkCyan;
            this.lGelirGider.Location = new System.Drawing.Point(31, 31);
            this.lGelirGider.Name = "lGelirGider";
            this.lGelirGider.Size = new System.Drawing.Size(116, 25);
            this.lGelirGider.TabIndex = 3;
            this.lGelirGider.Text = "Gelir - Gider";
            // 
            // tNakit
            // 
            this.tNakit.BackColor = System.Drawing.Color.White;
            this.tNakit.Enabled = false;
            this.tNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNakit.Location = new System.Drawing.Point(26, 161);
            this.tNakit.Name = "tNakit";
            this.tNakit.Size = new System.Drawing.Size(134, 30);
            this.tNakit.TabIndex = 4;
            this.tNakit.Text = "0";
            this.tNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tKart
            // 
            this.tKart.BackColor = System.Drawing.Color.White;
            this.tKart.Enabled = false;
            this.tKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKart.Location = new System.Drawing.Point(166, 161);
            this.tKart.Name = "tKart";
            this.tKart.Size = new System.Drawing.Size(134, 30);
            this.tKart.TabIndex = 5;
            this.tKart.Text = "0";
            this.tKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lSandart3
            // 
            this.lSandart3.AutoSize = true;
            this.lSandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart3.Location = new System.Drawing.Point(31, 133);
            this.lSandart3.Name = "lSandart3";
            this.lSandart3.Size = new System.Drawing.Size(56, 25);
            this.lSandart3.TabIndex = 6;
            this.lSandart3.Text = "Nakit";
            // 
            // lSandart4
            // 
            this.lSandart4.AutoSize = true;
            this.lSandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart4.Location = new System.Drawing.Point(173, 133);
            this.lSandart4.Name = "lSandart4";
            this.lSandart4.Size = new System.Drawing.Size(48, 25);
            this.lSandart4.TabIndex = 7;
            this.lSandart4.Text = "Kart";
            // 
            // tAçiklama
            // 
            this.tAçiklama.BackColor = System.Drawing.Color.White;
            this.tAçiklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAçiklama.Location = new System.Drawing.Point(21, 229);
            this.tAçiklama.Multiline = true;
            this.tAçiklama.Name = "tAçiklama";
            this.tAçiklama.Size = new System.Drawing.Size(279, 80);
            this.tAçiklama.TabIndex = 8;
            // 
            // lSandart5
            // 
            this.lSandart5.AutoSize = true;
            this.lSandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart5.Location = new System.Drawing.Point(21, 201);
            this.lSandart5.Name = "lSandart5";
            this.lSandart5.Size = new System.Drawing.Size(92, 25);
            this.lSandart5.TabIndex = 9;
            this.lSandart5.Text = "Açıklama";
            // 
            // lSandart6
            // 
            this.lSandart6.AutoSize = true;
            this.lSandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart6.Location = new System.Drawing.Point(21, 316);
            this.lSandart6.Name = "lSandart6";
            this.lSandart6.Size = new System.Drawing.Size(57, 25);
            this.lSandart6.TabIndex = 10;
            this.lSandart6.Text = "Tarih";
            // 
            // dTarih
            // 
            this.dTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTarih.Location = new System.Drawing.Point(21, 344);
            this.dTarih.Name = "dTarih";
            this.dTarih.Size = new System.Drawing.Size(279, 30);
            this.dTarih.TabIndex = 13;
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.Tomato;
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.ForeColor = System.Drawing.Color.White;
            this.bEkle.Image = global::BarkodluSatis.Properties.Resources.Ekle24;
            this.bEkle.Location = new System.Drawing.Point(18, 394);
            this.bEkle.Margin = new System.Windows.Forms.Padding(0);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(282, 60);
            this.bEkle.TabIndex = 14;
            this.bEkle.Text = "Ekle";
            this.bEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // fGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(332, 653);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.dTarih);
            this.Controls.Add(this.lSandart6);
            this.Controls.Add(this.lSandart5);
            this.Controls.Add(this.tAçiklama);
            this.Controls.Add(this.lSandart4);
            this.Controls.Add(this.lSandart3);
            this.Controls.Add(this.tKart);
            this.Controls.Add(this.tNakit);
            this.Controls.Add(this.lGelirGider);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.lSandart1);
            this.MaximumSize = new System.Drawing.Size(350, 700);
            this.MinimumSize = new System.Drawing.Size(350, 700);
            this.Name = "fGelirGider";
            this.Text = "fGelirGider";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lSandart lSandart1;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private lSandart lGelirGider;
        private tNumeric tNakit;
        private tNumeric tKart;
        private lSandart lSandart3;
        private lSandart lSandart4;
        private tStandart tAçiklama;
        private lSandart lSandart5;
        private lSandart lSandart6;
        private System.Windows.Forms.DateTimePicker dTarih;
        private bStandart bEkle;
    }
}