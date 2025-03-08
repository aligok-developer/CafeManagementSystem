namespace BarkodluSatis
{
    partial class adisyonEkle
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
            this.bStandart1 = new BarkodluSatis.bStandart();
            this.lSandart2 = new BarkodluSatis.lSandart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lSandart1
            // 
            this.lSandart1.AutoSize = true;
            this.lSandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart1.Location = new System.Drawing.Point(12, 54);
            this.lSandart1.Name = "lSandart1";
            this.lSandart1.Size = new System.Drawing.Size(47, 25);
            this.lSandart1.TabIndex = 1;
            this.lSandart1.Text = "İsim";
            // 
            // bStandart1
            // 
            this.bStandart1.BackColor = System.Drawing.Color.Tomato;
            this.bStandart1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bStandart1.ForeColor = System.Drawing.Color.White;
            this.bStandart1.Location = new System.Drawing.Point(61, 106);
            this.bStandart1.Margin = new System.Windows.Forms.Padding(0);
            this.bStandart1.Name = "bStandart1";
            this.bStandart1.Size = new System.Drawing.Size(250, 79);
            this.bStandart1.TabIndex = 0;
            this.bStandart1.Text = "Adisyon Ekle";
            this.bStandart1.UseVisualStyleBackColor = false;
            this.bStandart1.Click += new System.EventHandler(this.bStandart1_Click);
            // 
            // lSandart2
            // 
            this.lSandart2.AutoSize = true;
            this.lSandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart2.Location = new System.Drawing.Point(12, 9);
            this.lSandart2.Name = "lSandart2";
            this.lSandart2.Size = new System.Drawing.Size(222, 25);
            this.lSandart2.TabIndex = 3;
            this.lSandart2.Text = "Adisyon için isim giriniz !";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 22);
            this.textBox1.TabIndex = 0;
            // 
            // adisyonEkle
            // 
            this.AcceptButton = this.bStandart1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 210);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lSandart2);
            this.Controls.Add(this.bStandart1);
            this.Controls.Add(this.lSandart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adisyonEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adisyon Adı";
            this.Load += new System.EventHandler(this.adisyonEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lSandart lSandart1;
        private bStandart bStandart1;
        private lSandart lSandart2;
        private System.Windows.Forms.TextBox textBox1;
    }
}