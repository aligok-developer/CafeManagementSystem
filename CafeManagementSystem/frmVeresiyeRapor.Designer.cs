namespace BarkodluSatis
{
    partial class frmVeresiyeRapor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dBitis = new System.Windows.Forms.DateTimePicker();
            this.dBaslangic = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTarihSecme = new System.Windows.Forms.Button();
            this.btnVeresiyeRaporla = new System.Windows.Forms.Button();
            this.tGridVeresiye = new BarkodluSatis.tGrid();
            this.textBitis = new BarkodluSatis.lSandart();
            this.lBaslagicTarihi = new BarkodluSatis.lSandart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tGridVeresiye)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dBitis);
            this.panel1.Controls.Add(this.dBaslangic);
            this.panel1.Controls.Add(this.textBitis);
            this.panel1.Controls.Add(this.lBaslagicTarihi);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1469, 103);
            this.panel1.TabIndex = 6;
            // 
            // dBitis
            // 
            this.dBitis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dBitis.Location = new System.Drawing.Point(1158, 56);
            this.dBitis.Name = "dBitis";
            this.dBitis.Size = new System.Drawing.Size(300, 30);
            this.dBitis.TabIndex = 17;
            // 
            // dBaslangic
            // 
            this.dBaslangic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dBaslangic.Location = new System.Drawing.Point(843, 56);
            this.dBaslangic.Name = "dBaslangic";
            this.dBaslangic.Size = new System.Drawing.Size(300, 30);
            this.dBaslangic.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arama Yap:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTarihSecme);
            this.panel2.Controls.Add(this.btnVeresiyeRaporla);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 567);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1469, 128);
            this.panel2.TabIndex = 7;
            // 
            // btnTarihSecme
            // 
            this.btnTarihSecme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTarihSecme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTarihSecme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarihSecme.Location = new System.Drawing.Point(15, 30);
            this.btnTarihSecme.Name = "btnTarihSecme";
            this.btnTarihSecme.Size = new System.Drawing.Size(201, 73);
            this.btnTarihSecme.TabIndex = 20;
            this.btnTarihSecme.Text = "Tarih Aralığını Göster";
            this.btnTarihSecme.UseVisualStyleBackColor = false;
            this.btnTarihSecme.Click += new System.EventHandler(this.btnTarihSecme_Click);
            // 
            // btnVeresiyeRaporla
            // 
            this.btnVeresiyeRaporla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVeresiyeRaporla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVeresiyeRaporla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeresiyeRaporla.Location = new System.Drawing.Point(1256, 30);
            this.btnVeresiyeRaporla.Name = "btnVeresiyeRaporla";
            this.btnVeresiyeRaporla.Size = new System.Drawing.Size(201, 73);
            this.btnVeresiyeRaporla.TabIndex = 19;
            this.btnVeresiyeRaporla.Text = "Tarih Aralığını Paylaş";
            this.btnVeresiyeRaporla.UseVisualStyleBackColor = false;
            this.btnVeresiyeRaporla.Click += new System.EventHandler(this.btnVeresiyeRaporla_Click);
            // 
            // tGridVeresiye
            // 
            this.tGridVeresiye.AllowUserToAddRows = false;
            this.tGridVeresiye.AllowUserToResizeRows = false;
            this.tGridVeresiye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tGridVeresiye.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tGridVeresiye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tGridVeresiye.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tGridVeresiye.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tGridVeresiye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tGridVeresiye.DefaultCellStyle = dataGridViewCellStyle2;
            this.tGridVeresiye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tGridVeresiye.EnableHeadersVisualStyles = false;
            this.tGridVeresiye.Location = new System.Drawing.Point(0, 103);
            this.tGridVeresiye.Margin = new System.Windows.Forms.Padding(0);
            this.tGridVeresiye.Name = "tGridVeresiye";
            this.tGridVeresiye.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tGridVeresiye.RowHeadersVisible = false;
            this.tGridVeresiye.RowHeadersWidth = 51;
            this.tGridVeresiye.RowTemplate.Height = 32;
            this.tGridVeresiye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tGridVeresiye.Size = new System.Drawing.Size(1469, 592);
            this.tGridVeresiye.TabIndex = 0;
            // 
            // textBitis
            // 
            this.textBitis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBitis.AutoSize = true;
            this.textBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBitis.ForeColor = System.Drawing.Color.Black;
            this.textBitis.Location = new System.Drawing.Point(1153, 20);
            this.textBitis.Name = "textBitis";
            this.textBitis.Size = new System.Drawing.Size(102, 25);
            this.textBitis.TabIndex = 15;
            this.textBitis.Text = "Bitiş Tarihi";
            // 
            // lBaslagicTarihi
            // 
            this.lBaslagicTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lBaslagicTarihi.AutoSize = true;
            this.lBaslagicTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBaslagicTarihi.ForeColor = System.Drawing.Color.Black;
            this.lBaslagicTarihi.Location = new System.Drawing.Point(838, 20);
            this.lBaslagicTarihi.Name = "lBaslagicTarihi";
            this.lBaslagicTarihi.Size = new System.Drawing.Size(151, 25);
            this.lBaslagicTarihi.TabIndex = 14;
            this.lBaslagicTarihi.Text = "Başlangıç Tarihi";
            // 
            // frmVeresiyeRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1469, 695);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tGridVeresiye);
            this.Controls.Add(this.panel1);
            this.Name = "frmVeresiyeRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veresiye Rapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVeresiyeRapor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tGridVeresiye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private tGrid tGridVeresiye;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private lSandart textBitis;
        private lSandart lBaslagicTarihi;
        private System.Windows.Forms.Button btnVeresiyeRaporla;
        private System.Windows.Forms.Button btnTarihSecme;
        private System.Windows.Forms.DateTimePicker dBitis;
        private System.Windows.Forms.DateTimePicker dBaslangic;
    }
}