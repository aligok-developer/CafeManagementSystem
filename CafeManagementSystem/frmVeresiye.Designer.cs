namespace BarkodluSatis
{
    partial class frmVeresiye
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
            this.dataGridViewMusteri = new System.Windows.Forms.DataGridView();
            this.btnVeresiyeKaydet = new System.Windows.Forms.Button();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMusteri
            // 
            this.dataGridViewMusteri.AllowUserToResizeRows = false;
            this.dataGridViewMusteri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteri.Location = new System.Drawing.Point(10, 62);
            this.dataGridViewMusteri.Name = "dataGridViewMusteri";
            this.dataGridViewMusteri.RowHeadersWidth = 51;
            this.dataGridViewMusteri.RowTemplate.Height = 24;
            this.dataGridViewMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMusteri.Size = new System.Drawing.Size(753, 309);
            this.dataGridViewMusteri.TabIndex = 0;
            // 
            // btnVeresiyeKaydet
            // 
            this.btnVeresiyeKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVeresiyeKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVeresiyeKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeresiyeKaydet.Location = new System.Drawing.Point(568, 400);
            this.btnVeresiyeKaydet.Name = "btnVeresiyeKaydet";
            this.btnVeresiyeKaydet.Size = new System.Drawing.Size(195, 46);
            this.btnVeresiyeKaydet.TabIndex = 1;
            this.btnVeresiyeKaydet.Text = "Veresiye Yaz";
            this.btnVeresiyeKaydet.UseVisualStyleBackColor = false;
            this.btnVeresiyeKaydet.Click += new System.EventHandler(this.btnVeresiyeKaydet_Click);
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKisiEkle.BackColor = System.Drawing.Color.Tomato;
            this.btnKisiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiEkle.Location = new System.Drawing.Point(10, 400);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(131, 46);
            this.btnKisiEkle.TabIndex = 4;
            this.btnKisiEkle.Text = "Kişi Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = false;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(122, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 31);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kişi Ara:";
            // 
            // frmVeresiye
            // 
            this.AcceptButton = this.btnVeresiyeKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(775, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKisiEkle);
            this.Controls.Add(this.btnVeresiyeKaydet);
            this.Controls.Add(this.dataGridViewMusteri);
            this.Name = "frmVeresiye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veresiye";
            this.Load += new System.EventHandler(this.frmVeresiye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMusteri;
        private System.Windows.Forms.Button btnVeresiyeKaydet;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}