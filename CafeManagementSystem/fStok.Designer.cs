namespace BarkodluSatis
{
    partial class fStok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lKullanici = new System.Windows.Forms.Label();
            this.bRapor = new BarkodluSatis.bStandart();
            this.panelDate = new System.Windows.Forms.Panel();
            this.dBitis = new System.Windows.Forms.DateTimePicker();
            this.dBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lSandart5 = new BarkodluSatis.lSandart();
            this.lSandart4 = new BarkodluSatis.lSandart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdUrunGrubu = new System.Windows.Forms.RadioButton();
            this.rdTumu = new System.Windows.Forms.RadioButton();
            this.lSandart2 = new BarkodluSatis.lSandart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lSandart3 = new BarkodluSatis.lSandart();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbIslemTuru = new System.Windows.Forms.ComboBox();
            this.lSandart1 = new BarkodluSatis.lSandart();
            this.bAra = new BarkodluSatis.bStandart();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tUrunAra = new BarkodluSatis.tStandart();
            this.lSandart6 = new BarkodluSatis.lSandart();
            this.tGridListe = new BarkodluSatis.tGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tGridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lKullanici);
            this.splitContainer1.Panel1.Controls.Add(this.bRapor);
            this.splitContainer1.Panel1.Controls.Add(this.panelDate);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.bAra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1401, 760);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.TabIndex = 0;
            // 
            // lKullanici
            // 
            this.lKullanici.AutoSize = true;
            this.lKullanici.Location = new System.Drawing.Point(9, 8);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(62, 16);
            this.lKullanici.TabIndex = 52;
            this.lKullanici.Text = "Kullanıcı :";
            // 
            // bRapor
            // 
            this.bRapor.BackColor = System.Drawing.Color.RoyalBlue;
            this.bRapor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bRapor.ForeColor = System.Drawing.Color.White;
            this.bRapor.Image = global::BarkodluSatis.Properties.Resources.Excel32;
            this.bRapor.Location = new System.Drawing.Point(12, 620);
            this.bRapor.Margin = new System.Windows.Forms.Padding(0);
            this.bRapor.Name = "bRapor";
            this.bRapor.Size = new System.Drawing.Size(174, 72);
            this.bRapor.TabIndex = 51;
            this.bRapor.Text = "Rapor Paylaş";
            this.bRapor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bRapor.UseVisualStyleBackColor = false;
            this.bRapor.Click += new System.EventHandler(this.bRapor_Click);
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.dBitis);
            this.panelDate.Controls.Add(this.dBaslangic);
            this.panelDate.Controls.Add(this.lSandart5);
            this.panelDate.Controls.Add(this.lSandart4);
            this.panelDate.Location = new System.Drawing.Point(9, 432);
            this.panelDate.Margin = new System.Windows.Forms.Padding(0);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(369, 178);
            this.panelDate.TabIndex = 4;
            this.panelDate.Visible = false;
            // 
            // dBitis
            // 
            this.dBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dBitis.Location = new System.Drawing.Point(20, 135);
            this.dBitis.Name = "dBitis";
            this.dBitis.Size = new System.Drawing.Size(326, 26);
            this.dBitis.TabIndex = 6;
            this.dBitis.Value = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            // 
            // dBaslangic
            // 
            this.dBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dBaslangic.Location = new System.Drawing.Point(20, 54);
            this.dBaslangic.Name = "dBaslangic";
            this.dBaslangic.Size = new System.Drawing.Size(326, 26);
            this.dBaslangic.TabIndex = 5;
            this.dBaslangic.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lSandart5
            // 
            this.lSandart5.AutoSize = true;
            this.lSandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart5.ForeColor = System.Drawing.Color.Black;
            this.lSandart5.Location = new System.Drawing.Point(15, 96);
            this.lSandart5.Name = "lSandart5";
            this.lSandart5.Size = new System.Drawing.Size(102, 20);
            this.lSandart5.TabIndex = 4;
            this.lSandart5.Text = "Bitiş Tarihi";
            // 
            // lSandart4
            // 
            this.lSandart4.AutoSize = true;
            this.lSandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart4.ForeColor = System.Drawing.Color.Black;
            this.lSandart4.Location = new System.Drawing.Point(15, 14);
            this.lSandart4.Name = "lSandart4";
            this.lSandart4.Size = new System.Drawing.Size(146, 20);
            this.lSandart4.TabIndex = 3;
            this.lSandart4.Text = "Başlangıç Tarihi";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdUrunGrubu);
            this.panel3.Controls.Add(this.rdTumu);
            this.panel3.Controls.Add(this.lSandart2);
            this.panel3.Location = new System.Drawing.Point(9, 271);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 141);
            this.panel3.TabIndex = 3;
            // 
            // rdUrunGrubu
            // 
            this.rdUrunGrubu.AutoSize = true;
            this.rdUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdUrunGrubu.Location = new System.Drawing.Point(20, 93);
            this.rdUrunGrubu.Name = "rdUrunGrubu";
            this.rdUrunGrubu.Size = new System.Drawing.Size(181, 24);
            this.rdUrunGrubu.TabIndex = 3;
            this.rdUrunGrubu.Text = "Grubuna göre listele";
            this.rdUrunGrubu.UseVisualStyleBackColor = true;
            // 
            // rdTumu
            // 
            this.rdTumu.AutoSize = true;
            this.rdTumu.Checked = true;
            this.rdTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTumu.Location = new System.Drawing.Point(20, 51);
            this.rdTumu.Name = "rdTumu";
            this.rdTumu.Size = new System.Drawing.Size(139, 24);
            this.rdTumu.TabIndex = 2;
            this.rdTumu.TabStop = true;
            this.rdTumu.Text = "Tümünü listele";
            this.rdTumu.UseVisualStyleBackColor = true;
            // 
            // lSandart2
            // 
            this.lSandart2.AutoSize = true;
            this.lSandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart2.ForeColor = System.Drawing.Color.Black;
            this.lSandart2.Location = new System.Drawing.Point(15, 11);
            this.lSandart2.Name = "lSandart2";
            this.lSandart2.Size = new System.Drawing.Size(137, 20);
            this.lSandart2.TabIndex = 1;
            this.lSandart2.Text = "Filtreleme Türü";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lSandart3);
            this.panel2.Controls.Add(this.cmbUrunGrubu);
            this.panel2.Location = new System.Drawing.Point(9, 137);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 113);
            this.panel2.TabIndex = 2;
            // 
            // lSandart3
            // 
            this.lSandart3.AutoSize = true;
            this.lSandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart3.ForeColor = System.Drawing.Color.Black;
            this.lSandart3.Location = new System.Drawing.Point(15, 14);
            this.lSandart3.Name = "lSandart3";
            this.lSandart3.Size = new System.Drawing.Size(106, 20);
            this.lSandart3.TabIndex = 2;
            this.lSandart3.Text = "Ürün Grubu";
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(20, 51);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(326, 28);
            this.cmbUrunGrubu.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbIslemTuru);
            this.panel1.Controls.Add(this.lSandart1);
            this.panel1.Location = new System.Drawing.Point(9, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 96);
            this.panel1.TabIndex = 1;
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş İzleme"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(19, 50);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(326, 28);
            this.cmbIslemTuru.TabIndex = 1;
            // 
            // lSandart1
            // 
            this.lSandart1.AutoSize = true;
            this.lSandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart1.ForeColor = System.Drawing.Color.Black;
            this.lSandart1.Location = new System.Drawing.Point(16, 18);
            this.lSandart1.Name = "lSandart1";
            this.lSandart1.Size = new System.Drawing.Size(98, 20);
            this.lSandart1.TabIndex = 0;
            this.lSandart1.Text = "İşlem Türü";
            // 
            // bAra
            // 
            this.bAra.BackColor = System.Drawing.Color.Tomato;
            this.bAra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAra.ForeColor = System.Drawing.Color.White;
            this.bAra.Image = global::BarkodluSatis.Properties.Resources.ara2424;
            this.bAra.Location = new System.Drawing.Point(196, 620);
            this.bAra.Margin = new System.Windows.Forms.Padding(0);
            this.bAra.Name = "bAra";
            this.bAra.Size = new System.Drawing.Size(182, 72);
            this.bAra.TabIndex = 0;
            this.bAra.Text = "Stok Ara";
            this.bAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAra.UseVisualStyleBackColor = false;
            this.bAra.Click += new System.EventHandler(this.bAra_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tUrunAra);
            this.splitContainer2.Panel1.Controls.Add(this.lSandart6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tGridListe);
            this.splitContainer2.Size = new System.Drawing.Size(1014, 760);
            this.splitContainer2.SplitterDistance = 72;
            this.splitContainer2.TabIndex = 0;
            // 
            // tUrunAra
            // 
            this.tUrunAra.BackColor = System.Drawing.Color.White;
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAra.Location = new System.Drawing.Point(124, 20);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(699, 30);
            this.tUrunAra.TabIndex = 4;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // lSandart6
            // 
            this.lSandart6.AutoSize = true;
            this.lSandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart6.ForeColor = System.Drawing.Color.Black;
            this.lSandart6.Location = new System.Drawing.Point(14, 27);
            this.lSandart6.Name = "lSandart6";
            this.lSandart6.Size = new System.Drawing.Size(84, 20);
            this.lSandart6.TabIndex = 3;
            this.lSandart6.Text = "Ürün Ara";
            // 
            // tGridListe
            // 
            this.tGridListe.AllowUserToAddRows = false;
            this.tGridListe.AllowUserToDeleteRows = false;
            this.tGridListe.AllowUserToResizeRows = false;
            this.tGridListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tGridListe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tGridListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tGridListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tGridListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tGridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tGridListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.tGridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tGridListe.EnableHeadersVisualStyles = false;
            this.tGridListe.Location = new System.Drawing.Point(0, 0);
            this.tGridListe.Margin = new System.Windows.Forms.Padding(0);
            this.tGridListe.Name = "tGridListe";
            this.tGridListe.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tGridListe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tGridListe.RowHeadersVisible = false;
            this.tGridListe.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tGridListe.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tGridListe.RowTemplate.Height = 32;
            this.tGridListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tGridListe.Size = new System.Drawing.Size(1014, 684);
            this.tGridListe.TabIndex = 2;
            // 
            // fStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1401, 760);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fStok";
            this.Text = "Stok Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fStok_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tGridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private bStandart bAra;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dBitis;
        private System.Windows.Forms.DateTimePicker dBaslangic;
        private lSandart lSandart5;
        private lSandart lSandart4;
        private System.Windows.Forms.RadioButton rdUrunGrubu;
        private System.Windows.Forms.RadioButton rdTumu;
        private lSandart lSandart2;
        private lSandart lSandart3;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private lSandart lSandart1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private tStandart tUrunAra;
        private lSandart lSandart6;
        private tGrid tGridListe;
        private bStandart bRapor;
        public System.Windows.Forms.Label lKullanici;
    }
}