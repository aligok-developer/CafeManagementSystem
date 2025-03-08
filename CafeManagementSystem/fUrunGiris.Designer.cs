namespace BarkodluSatis
{
    partial class fUrunGiris
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tSatis = new System.Windows.Forms.TextBox();
            this.tUrunAra = new System.Windows.Forms.TextBox();
            this.cmbUrunGrup = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tUrunSayisi = new System.Windows.Forms.TextBox();
            this.tAlis = new System.Windows.Forms.TextBox();
            this.chUrunTipi = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lSandart2 = new BarkodluSatis.lSandart();
            this.lSandart8 = new BarkodluSatis.lSandart();
            this.lSandart1 = new BarkodluSatis.lSandart();
            this.bKullanilmayanUrunSilme = new BarkodluSatis.bStandart();
            this.tBarkod = new BarkodluSatis.tStandart();
            this.tAciklama = new BarkodluSatis.tStandart();
            this.lSandart5 = new BarkodluSatis.lSandart();
            this.lSandart9 = new BarkodluSatis.lSandart();
            this.tKdvOran = new BarkodluSatis.tNumeric();
            this.lKullanici = new BarkodluSatis.lSandart();
            this.bBarkodOlustur = new BarkodluSatis.bStandart();
            this.lStandart = new BarkodluSatis.lSandart();
            this.lSandart10 = new BarkodluSatis.lSandart();
            this.tGridUrunler = new BarkodluSatis.tGrid();
            this.lSandart11 = new BarkodluSatis.lSandart();
            this.bUrunGrupEkle = new BarkodluSatis.bStandart();
            this.lSandart3 = new BarkodluSatis.lSandart();
            this.lSandart4 = new BarkodluSatis.lSandart();
            this.bKaydet = new BarkodluSatis.bStandart();
            this.tUrunAdi = new BarkodluSatis.tStandart();
            this.bİptal = new BarkodluSatis.bStandart();
            this.lSandart6 = new BarkodluSatis.lSandart();
            this.lSandart7 = new BarkodluSatis.lSandart();
            this.tMiktar = new BarkodluSatis.tNumeric();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tGridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // tSatis
            // 
            this.tSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tSatis.Location = new System.Drawing.Point(545, 16);
            this.tSatis.Name = "tSatis";
            this.tSatis.Size = new System.Drawing.Size(115, 30);
            this.tSatis.TabIndex = 5;
            this.tSatis.Text = "0";
            this.tSatis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tSatis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tGridUrunler_KeyPress);
            // 
            // tUrunAra
            // 
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tUrunAra.Location = new System.Drawing.Point(120, 203);
            this.tUrunAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(250, 30);
            this.tUrunAra.TabIndex = 13;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // cmbUrunGrup
            // 
            this.cmbUrunGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrup.FormattingEnabled = true;
            this.cmbUrunGrup.ItemHeight = 25;
            this.cmbUrunGrup.Location = new System.Drawing.Point(120, 64);
            this.cmbUrunGrup.Name = "cmbUrunGrup";
            this.cmbUrunGrup.Size = new System.Drawing.Size(250, 33);
            this.cmbUrunGrup.TabIndex = 29;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // tUrunSayisi
            // 
            this.tUrunSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tUrunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tUrunSayisi.Location = new System.Drawing.Point(1388, 203);
            this.tUrunSayisi.Name = "tUrunSayisi";
            this.tUrunSayisi.ReadOnly = true;
            this.tUrunSayisi.Size = new System.Drawing.Size(115, 30);
            this.tUrunSayisi.TabIndex = 33;
            // 
            // tAlis
            // 
            this.tAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tAlis.Location = new System.Drawing.Point(61, 7);
            this.tAlis.Name = "tAlis";
            this.tAlis.Size = new System.Drawing.Size(47, 30);
            this.tAlis.TabIndex = 4;
            this.tAlis.Text = "0";
            this.tAlis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tAlis.Visible = false;
            this.tAlis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tGridUrunler_KeyPress);
            // 
            // chUrunTipi
            // 
            this.chUrunTipi.Appearance = System.Windows.Forms.Appearance.Button;
            this.chUrunTipi.AutoSize = true;
            this.chUrunTipi.BackColor = System.Drawing.Color.YellowGreen;
            this.chUrunTipi.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chUrunTipi.FlatAppearance.BorderSize = 0;
            this.chUrunTipi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chUrunTipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chUrunTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chUrunTipi.Location = new System.Drawing.Point(3, 6);
            this.chUrunTipi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chUrunTipi.Name = "chUrunTipi";
            this.chUrunTipi.Size = new System.Drawing.Size(52, 16);
            this.chUrunTipi.TabIndex = 30;
            this.chUrunTipi.Text = "Barkodlu Ürün ";
            this.chUrunTipi.UseVisualStyleBackColor = false;
            this.chUrunTipi.Visible = false;
            this.chUrunTipi.CheckedChanged += new System.EventHandler(this.chUrunTipi_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lSandart2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lSandart8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lSandart1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bKullanilmayanUrunSilme, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tBarkod, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chUrunTipi, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tAciklama, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tAlis, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lSandart5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lSandart9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tKdvOran, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lKullanici, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bBarkodOlustur, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lStandart, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1421, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(116, 44);
            this.tableLayoutPanel1.TabIndex = 32;
            this.tableLayoutPanel1.Visible = false;
            // 
            // lSandart2
            // 
            this.lSandart2.AutoSize = true;
            this.lSandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart2.Location = new System.Drawing.Point(3, 0);
            this.lSandart2.Name = "lSandart2";
            this.lSandart2.Size = new System.Drawing.Size(50, 1);
            this.lSandart2.TabIndex = 1;
            this.lSandart2.Text = "Açıklama";
            this.lSandart2.Visible = false;
            // 
            // lSandart8
            // 
            this.lSandart8.AutoSize = true;
            this.lSandart8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart8.ForeColor = System.Drawing.Color.Red;
            this.lSandart8.Location = new System.Drawing.Point(3, 24);
            this.lSandart8.Name = "lSandart8";
            this.lSandart8.Size = new System.Drawing.Size(52, 20);
            this.lSandart8.TabIndex = 31;
            this.lSandart8.Text = "Kullanılan ürünler güncellendikten sonra \r\nBurdan kullanılmayan ürünleri siliniz";
            this.lSandart8.Visible = false;
            // 
            // lSandart1
            // 
            this.lSandart1.AutoSize = true;
            this.lSandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart1.Location = new System.Drawing.Point(61, 0);
            this.lSandart1.Name = "lSandart1";
            this.lSandart1.Size = new System.Drawing.Size(52, 1);
            this.lSandart1.TabIndex = 0;
            this.lSandart1.Text = "Barkod ";
            this.lSandart1.Visible = false;
            // 
            // bKullanilmayanUrunSilme
            // 
            this.bKullanilmayanUrunSilme.BackColor = System.Drawing.Color.Tomato;
            this.bKullanilmayanUrunSilme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bKullanilmayanUrunSilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKullanilmayanUrunSilme.ForeColor = System.Drawing.Color.White;
            this.bKullanilmayanUrunSilme.Location = new System.Drawing.Point(58, 24);
            this.bKullanilmayanUrunSilme.Margin = new System.Windows.Forms.Padding(0);
            this.bKullanilmayanUrunSilme.Name = "bKullanilmayanUrunSilme";
            this.bKullanilmayanUrunSilme.Size = new System.Drawing.Size(58, 20);
            this.bKullanilmayanUrunSilme.TabIndex = 0;
            this.bKullanilmayanUrunSilme.Text = "Kullanılmayan \r\nÜrünleri Sil";
            this.bKullanilmayanUrunSilme.UseVisualStyleBackColor = false;
            this.bKullanilmayanUrunSilme.Visible = false;
            this.bKullanilmayanUrunSilme.Click += new System.EventHandler(this.bKullanilmayanUrunSilme_Click);
            // 
            // tBarkod
            // 
            this.tBarkod.BackColor = System.Drawing.Color.White;
            this.tBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBarkod.Location = new System.Drawing.Point(3, -25);
            this.tBarkod.Name = "tBarkod";
            this.tBarkod.Size = new System.Drawing.Size(47, 30);
            this.tBarkod.TabIndex = 0;
            this.tBarkod.Visible = false;
            this.tBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBarkod_KeyDown);
            // 
            // tAciklama
            // 
            this.tAciklama.BackColor = System.Drawing.Color.White;
            this.tAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAciklama.Location = new System.Drawing.Point(61, -25);
            this.tAciklama.Name = "tAciklama";
            this.tAciklama.Size = new System.Drawing.Size(47, 30);
            this.tAciklama.TabIndex = 3;
            this.tAciklama.Visible = false;
            // 
            // lSandart5
            // 
            this.lSandart5.AutoSize = true;
            this.lSandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart5.Location = new System.Drawing.Point(61, -56);
            this.lSandart5.Name = "lSandart5";
            this.lSandart5.Size = new System.Drawing.Size(49, 20);
            this.lSandart5.TabIndex = 8;
            this.lSandart5.Text = "Alış Fiyatı";
            this.lSandart5.Visible = false;
            // 
            // lSandart9
            // 
            this.lSandart9.AutoSize = true;
            this.lSandart9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart9.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart9.Location = new System.Drawing.Point(3, -56);
            this.lSandart9.Name = "lSandart9";
            this.lSandart9.Size = new System.Drawing.Size(52, 20);
            this.lSandart9.TabIndex = 19;
            this.lSandart9.Text = "Kdv Oranı";
            this.lSandart9.Visible = false;
            // 
            // tKdvOran
            // 
            this.tKdvOran.BackColor = System.Drawing.Color.White;
            this.tKdvOran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKdvOran.Location = new System.Drawing.Point(61, -33);
            this.tKdvOran.Name = "tKdvOran";
            this.tKdvOran.Size = new System.Drawing.Size(47, 30);
            this.tKdvOran.TabIndex = 7;
            this.tKdvOran.Text = "0";
            this.tKdvOran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tKdvOran.Visible = false;
            this.tKdvOran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tGridUrunler_KeyPress);
            // 
            // lKullanici
            // 
            this.lKullanici.AutoSize = true;
            this.lKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lKullanici.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKullanici.Location = new System.Drawing.Point(3, -16);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(43, 20);
            this.lKullanici.TabIndex = 14;
            this.lKullanici.Text = "Admin";
            this.lKullanici.Visible = false;
            // 
            // bBarkodOlustur
            // 
            this.bBarkodOlustur.BackColor = System.Drawing.Color.Lime;
            this.bBarkodOlustur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bBarkodOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bBarkodOlustur.ForeColor = System.Drawing.Color.White;
            this.bBarkodOlustur.Image = global::BarkodluSatis.Properties.Resources.barcode48321;
            this.bBarkodOlustur.Location = new System.Drawing.Point(0, -36);
            this.bBarkodOlustur.Margin = new System.Windows.Forms.Padding(0);
            this.bBarkodOlustur.Name = "bBarkodOlustur";
            this.bBarkodOlustur.Size = new System.Drawing.Size(58, 20);
            this.bBarkodOlustur.TabIndex = 12;
            this.bBarkodOlustur.Text = "Barkod Oluştur";
            this.bBarkodOlustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bBarkodOlustur.UseVisualStyleBackColor = false;
            this.bBarkodOlustur.Visible = false;
            this.bBarkodOlustur.Click += new System.EventHandler(this.bBarkodOlustur_Click_1);
            // 
            // lStandart
            // 
            this.lStandart.AutoSize = true;
            this.lStandart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lStandart.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart.Location = new System.Drawing.Point(61, -16);
            this.lStandart.Name = "lStandart";
            this.lStandart.Size = new System.Drawing.Size(52, 20);
            this.lStandart.TabIndex = 15;
            this.lStandart.Text = "Kullanıcı";
            this.lStandart.Visible = false;
            // 
            // lSandart10
            // 
            this.lSandart10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSandart10.AutoSize = true;
            this.lSandart10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart10.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart10.Location = new System.Drawing.Point(1199, 206);
            this.lSandart10.Name = "lSandart10";
            this.lSandart10.Size = new System.Drawing.Size(183, 25);
            this.lSandart10.TabIndex = 34;
            this.lSandart10.Text = "Toplam Ürün Sayısı";
            // 
            // tGridUrunler
            // 
            this.tGridUrunler.AllowUserToAddRows = false;
            this.tGridUrunler.AllowUserToDeleteRows = false;
            this.tGridUrunler.AllowUserToResizeColumns = false;
            this.tGridUrunler.AllowUserToResizeRows = false;
            this.tGridUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tGridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tGridUrunler.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tGridUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tGridUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tGridUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tGridUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.tGridUrunler.EnableHeadersVisualStyles = false;
            this.tGridUrunler.Location = new System.Drawing.Point(0, 243);
            this.tGridUrunler.Margin = new System.Windows.Forms.Padding(0);
            this.tGridUrunler.Name = "tGridUrunler";
            this.tGridUrunler.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tGridUrunler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tGridUrunler.RowHeadersVisible = false;
            this.tGridUrunler.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tGridUrunler.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tGridUrunler.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.tGridUrunler.RowTemplate.Height = 32;
            this.tGridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tGridUrunler.Size = new System.Drawing.Size(1525, 520);
            this.tGridUrunler.TabIndex = 0;
            this.tGridUrunler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tGridUrunler_KeyPress);
            // 
            // lSandart11
            // 
            this.lSandart11.AutoSize = true;
            this.lSandart11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart11.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart11.Location = new System.Drawing.Point(22, 206);
            this.lSandart11.Name = "lSandart11";
            this.lSandart11.Size = new System.Drawing.Size(90, 25);
            this.lSandart11.TabIndex = 28;
            this.lSandart11.Text = "Ürün Ara";
            // 
            // bUrunGrupEkle
            // 
            this.bUrunGrupEkle.BackColor = System.Drawing.Color.Tomato;
            this.bUrunGrupEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bUrunGrupEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bUrunGrupEkle.ForeColor = System.Drawing.Color.White;
            this.bUrunGrupEkle.Image = global::BarkodluSatis.Properties.Resources.Ekle24;
            this.bUrunGrupEkle.Location = new System.Drawing.Point(270, 98);
            this.bUrunGrupEkle.Margin = new System.Windows.Forms.Padding(0);
            this.bUrunGrupEkle.Name = "bUrunGrupEkle";
            this.bUrunGrupEkle.Size = new System.Drawing.Size(100, 100);
            this.bUrunGrupEkle.TabIndex = 11;
            this.bUrunGrupEkle.Text = "Ürün Grubu Ekle";
            this.bUrunGrupEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bUrunGrupEkle.UseVisualStyleBackColor = false;
            this.bUrunGrupEkle.Click += new System.EventHandler(this.bUrunGrupEkle_Click);
            // 
            // lSandart3
            // 
            this.lSandart3.AutoSize = true;
            this.lSandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart3.Location = new System.Drawing.Point(26, 19);
            this.lSandart3.Name = "lSandart3";
            this.lSandart3.Size = new System.Drawing.Size(88, 25);
            this.lSandart3.TabIndex = 2;
            this.lSandart3.Text = "Ürün Adı";
            // 
            // lSandart4
            // 
            this.lSandart4.AutoSize = true;
            this.lSandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart4.Location = new System.Drawing.Point(-1, 68);
            this.lSandart4.Name = "lSandart4";
            this.lSandart4.Size = new System.Drawing.Size(113, 25);
            this.lSandart4.TabIndex = 3;
            this.lSandart4.Text = "Ürün Grubu";
            // 
            // bKaydet
            // 
            this.bKaydet.BackColor = System.Drawing.Color.Lime;
            this.bKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKaydet.ForeColor = System.Drawing.Color.White;
            this.bKaydet.Image = global::BarkodluSatis.Properties.Resources.save24;
            this.bKaydet.Location = new System.Drawing.Point(560, 98);
            this.bKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(100, 100);
            this.bKaydet.TabIndex = 8;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bKaydet.UseVisualStyleBackColor = false;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // tUrunAdi
            // 
            this.tUrunAdi.BackColor = System.Drawing.Color.White;
            this.tUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAdi.Location = new System.Drawing.Point(120, 16);
            this.tUrunAdi.Name = "tUrunAdi";
            this.tUrunAdi.Size = new System.Drawing.Size(250, 30);
            this.tUrunAdi.TabIndex = 2;
            // 
            // bİptal
            // 
            this.bİptal.BackColor = System.Drawing.Color.OrangeRed;
            this.bİptal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bİptal.ForeColor = System.Drawing.Color.White;
            this.bİptal.Image = global::BarkodluSatis.Properties.Resources.cancel241;
            this.bİptal.Location = new System.Drawing.Point(450, 98);
            this.bİptal.Margin = new System.Windows.Forms.Padding(0);
            this.bİptal.Name = "bİptal";
            this.bİptal.Size = new System.Drawing.Size(100, 100);
            this.bİptal.TabIndex = 9;
            this.bİptal.Text = "İptal";
            this.bİptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bİptal.UseVisualStyleBackColor = false;
            this.bİptal.Click += new System.EventHandler(this.bİptal_Click);
            // 
            // lSandart6
            // 
            this.lSandart6.AutoSize = true;
            this.lSandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart6.Location = new System.Drawing.Point(432, 19);
            this.lSandart6.Name = "lSandart6";
            this.lSandart6.Size = new System.Drawing.Size(107, 25);
            this.lSandart6.TabIndex = 9;
            this.lSandart6.Text = "Satış Fiyatı";
            // 
            // lSandart7
            // 
            this.lSandart7.AutoSize = true;
            this.lSandart7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart7.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart7.Location = new System.Drawing.Point(474, 68);
            this.lSandart7.Name = "lSandart7";
            this.lSandart7.Size = new System.Drawing.Size(53, 25);
            this.lSandart7.TabIndex = 10;
            this.lSandart7.Text = "Adet";
            // 
            // tMiktar
            // 
            this.tMiktar.BackColor = System.Drawing.Color.White;
            this.tMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tMiktar.Location = new System.Drawing.Point(545, 65);
            this.tMiktar.Name = "tMiktar";
            this.tMiktar.Size = new System.Drawing.Size(115, 30);
            this.tMiktar.TabIndex = 6;
            this.tMiktar.Text = "0";
            this.tMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tGridUrunler_KeyPress);
            // 
            // fUrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1525, 763);
            this.Controls.Add(this.lSandart10);
            this.Controls.Add(this.tUrunSayisi);
            this.Controls.Add(this.tGridUrunler);
            this.Controls.Add(this.tUrunAra);
            this.Controls.Add(this.tSatis);
            this.Controls.Add(this.lSandart11);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cmbUrunGrup);
            this.Controls.Add(this.bUrunGrupEkle);
            this.Controls.Add(this.lSandart3);
            this.Controls.Add(this.lSandart4);
            this.Controls.Add(this.bKaydet);
            this.Controls.Add(this.tUrunAdi);
            this.Controls.Add(this.bİptal);
            this.Controls.Add(this.lSandart6);
            this.Controls.Add(this.lSandart7);
            this.Controls.Add(this.tMiktar);
            this.Name = "fUrunGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Giriş Formu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fUrunGiris_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tGridUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private tStandart tUrunAdi;
        private lSandart lSandart4;
        private lSandart lSandart3;
        private lSandart lSandart7;
        private lSandart lSandart6;
        private tNumeric tMiktar;
        private bStandart bKaydet;
        private bStandart bİptal;
        private bStandart bUrunGrupEkle;
        private lSandart lSandart11;
        private tGrid tGridUrunler;
        private System.Windows.Forms.TextBox tUrunAra;
        public System.Windows.Forms.ComboBox cmbUrunGrup;
        private System.Windows.Forms.TextBox tSatis;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.TextBox tUrunSayisi;
        private lSandart lSandart10;
        private lSandart lStandart;
        private bStandart bBarkodOlustur;
        internal lSandart lKullanici;
        private tNumeric tKdvOran;
        private lSandart lSandart9;
        private lSandart lSandart5;
        private System.Windows.Forms.TextBox tAlis;
        private tStandart tAciklama;
        private System.Windows.Forms.CheckBox chUrunTipi;
        internal tStandart tBarkod;
        private bStandart bKullanilmayanUrunSilme;
        private lSandart lSandart1;
        private lSandart lSandart8;
        private lSandart lSandart2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}