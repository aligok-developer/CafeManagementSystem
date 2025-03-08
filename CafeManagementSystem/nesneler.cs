using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    internal class nesneler
    {
    }
    class lSandart : Label // Assuming the class name is lSandart based on the constructor
    {
        public lSandart()
        {
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Text = "lStandart"; // Assuming the text should be "lStandart" based on the constructor
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // Completing the Font constructor
            this.Name = "lStandart";
        }

    }
    class bStandart : Button
    {
        public bStandart()
        {
            this.BackColor = System.Drawing.Color.Tomato;
            this.Dock = System.Windows.Forms.DockStyle.None;
            this.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            //this.Image = global::BarkodluSatis.Properties.Resources.tl_48;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "  ";
            this.Size = new System.Drawing.Size(183, 120);
            this.TabIndex = 0;
            //this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UseVisualStyleBackColor = false;
        }
    }
    class tStandart : TextBox
    {
        public tStandart()
        {
            this.Size = new System.Drawing.Size(250, 26);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        }
    }
    class tNumeric : TextBox
    {
        public tNumeric()
        {
            this.Size = new System.Drawing.Size(115, 26);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "tNumeric";
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Click += TNumeric_Click;
            this.KeyPress += TNumeric_KeyPress;
        }

        private void TNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && (e.KeyChar!=(char)44))
            {
                e.Handled = true;
            }
        }

        private void TNumeric_Click(object sender, EventArgs e)
        {
            this.SelectAll();
        }
    }
    class tGrid : DataGridView
    {
        public tGrid()
        {
            this.AllowUserToAddRows = false;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;

            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;


            // DefaultCellStyle'ı bir kez ayarlayın
            this.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            // Arka plan rengi (beyaz)
            this.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
         ((byte)(162)));
            this.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            // Font rengi (siyah)
            this.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);

            this.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue; // Seçili satır arka plan rengi (örnek olarak açık mavi)
            this.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black; // Seçili satır font rengi (siyah)

            this.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            // Diğer stil ayarları
            this.ColumnHeadersDefaultCellStyle = this.DefaultCellStyle;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnableHeadersVisualStyles = false;
            this.Location = new System.Drawing.Point(0,
         150);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "gridSatisListesi";
            this.RowHeadersDefaultCellStyle = this.DefaultCellStyle;
            this.RowHeadersVisible = false;
            this.RowHeadersWidth = 51;
            this.RowTemplate.Height = 32;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Size = new System.Drawing.Size(918,
         476);
        }
    }

    
}
