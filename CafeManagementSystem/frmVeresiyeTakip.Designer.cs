namespace BarkodluSatis
{
    partial class frmVeresiyeTakip
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
            this.dataGridViewVeresiye = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.lSandart1 = new BarkodluSatis.lSandart();
            this.txtOdemeAl = new System.Windows.Forms.TextBox();
            this.btnVeresiyeRapor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeresiye)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVeresiye
            // 
            this.dataGridViewVeresiye.AllowUserToAddRows = false;
            this.dataGridViewVeresiye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVeresiye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVeresiye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeresiye.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewVeresiye.Name = "dataGridViewVeresiye";
            this.dataGridViewVeresiye.RowHeadersWidth = 51;
            this.dataGridViewVeresiye.RowTemplate.Height = 24;
            this.dataGridViewVeresiye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVeresiye.Size = new System.Drawing.Size(1259, 554);
            this.dataGridViewVeresiye.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(172, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müşteri Ara:";
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOdemeAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOdemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.Location = new System.Drawing.Point(12, 705);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(269, 56);
            this.btnOdemeAl.TabIndex = 4;
            this.btnOdemeAl.Text = "Ödeme Yap";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // lSandart1
            // 
            this.lSandart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lSandart1.AutoSize = true;
            this.lSandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lSandart1.Location = new System.Drawing.Point(12, 646);
            this.lSandart1.Name = "lSandart1";
            this.lSandart1.Size = new System.Drawing.Size(193, 29);
            this.lSandart1.TabIndex = 6;
            this.lSandart1.Text = "Ödenecek Tutar:";
            // 
            // txtOdemeAl
            // 
            this.txtOdemeAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOdemeAl.BackColor = System.Drawing.Color.Tomato;
            this.txtOdemeAl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOdemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeAl.ForeColor = System.Drawing.Color.White;
            this.txtOdemeAl.Location = new System.Drawing.Point(215, 639);
            this.txtOdemeAl.Margin = new System.Windows.Forms.Padding(0);
            this.txtOdemeAl.Name = "txtOdemeAl";
            this.txtOdemeAl.Size = new System.Drawing.Size(138, 42);
            this.txtOdemeAl.TabIndex = 8;
            this.txtOdemeAl.Text = "0";
            this.txtOdemeAl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOdemeAl.Enter += new System.EventHandler(this.txtOdemeAl_Enter);
            // 
            // btnVeresiyeRapor
            // 
            this.btnVeresiyeRapor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVeresiyeRapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVeresiyeRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeresiyeRapor.Location = new System.Drawing.Point(954, 705);
            this.btnVeresiyeRapor.Name = "btnVeresiyeRapor";
            this.btnVeresiyeRapor.Size = new System.Drawing.Size(317, 56);
            this.btnVeresiyeRapor.TabIndex = 9;
            this.btnVeresiyeRapor.Text = "Veresiye Rapor Görüntüle";
            this.btnVeresiyeRapor.UseVisualStyleBackColor = false;
            this.btnVeresiyeRapor.Click += new System.EventHandler(this.btnVeresiyeRapor_Click);
            // 
            // frmVeresiyeTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1283, 790);
            this.Controls.Add(this.btnVeresiyeRapor);
            this.Controls.Add(this.txtOdemeAl);
            this.Controls.Add(this.lSandart1);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewVeresiye);
            this.Name = "frmVeresiyeTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veresiye Defteri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVeresiyeTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeresiye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewVeresiye;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdemeAl;
        private lSandart lSandart1;
        public System.Windows.Forms.TextBox txtOdemeAl;
        private System.Windows.Forms.Button btnVeresiyeRapor;
    }
}