namespace indiv1
{
    partial class UcCatalog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btn_check = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_cumpara = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.moderDataGridViewCustom1 = new ModerDataGridViewCustom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moderDataGridViewCustom1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 656);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(617, 615);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Laptopuri";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(496, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 656);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.moderDataGridViewCustom1);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.btn_check);
            this.panel4.Controls.Add(this.btn_cumpara);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 649);
            this.panel4.TabIndex = 27;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(15, 429);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 28);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "Total: ";
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(20, 523);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(365, 32);
            this.btn_check.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.btn_check.StateCommon.Back.Color2 = System.Drawing.Color.Purple;
            this.btn_check.StateCommon.Back.ColorAngle = 45F;
            this.btn_check.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btn_check.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btn_check.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_check.StateCommon.Border.Rounding = 5;
            this.btn_check.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_check.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_check.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_check.TabIndex = 27;
            this.btn_check.Values.Text = "Cec";
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_cumpara
            // 
            this.btn_cumpara.Location = new System.Drawing.Point(20, 586);
            this.btn_cumpara.Name = "btn_cumpara";
            this.btn_cumpara.Size = new System.Drawing.Size(365, 32);
            this.btn_cumpara.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.btn_cumpara.StateCommon.Back.Color2 = System.Drawing.Color.Purple;
            this.btn_cumpara.StateCommon.Back.ColorAngle = 45F;
            this.btn_cumpara.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btn_cumpara.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btn_cumpara.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_cumpara.StateCommon.Border.Rounding = 5;
            this.btn_cumpara.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_cumpara.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_cumpara.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cumpara.TabIndex = 26;
            this.btn_cumpara.Values.Text = "Cumpara";
            this.btn_cumpara.Click += new System.EventHandler(this.btn_cumpara_Click);
            // 
            // moderDataGridViewCustom1
            // 
            this.moderDataGridViewCustom1.AllowUserToAddRows = false;
            this.moderDataGridViewCustom1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.moderDataGridViewCustom1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.moderDataGridViewCustom1.BackgroundColor = System.Drawing.Color.Black;
            this.moderDataGridViewCustom1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moderDataGridViewCustom1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.moderDataGridViewCustom1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moderDataGridViewCustom1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.moderDataGridViewCustom1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.moderDataGridViewCustom1.DefaultCellStyle = dataGridViewCellStyle3;
            this.moderDataGridViewCustom1.EnableHeadersVisualStyles = false;
            this.moderDataGridViewCustom1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.moderDataGridViewCustom1.Location = new System.Drawing.Point(3, 3);
            this.moderDataGridViewCustom1.MultiSelect = false;
            this.moderDataGridViewCustom1.Name = "moderDataGridViewCustom1";
            this.moderDataGridViewCustom1.RowHeadersVisible = false;
            this.moderDataGridViewCustom1.RowHeadersWidth = 51;
            this.moderDataGridViewCustom1.RowTemplate.Height = 35;
            this.moderDataGridViewCustom1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.moderDataGridViewCustom1.Size = new System.Drawing.Size(399, 400);
            this.moderDataGridViewCustom1.TabIndex = 30;
            // 
            // UcCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UcCatalog";
            this.Size = new System.Drawing.Size(910, 681);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moderDataGridViewCustom1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ModerDataGridViewCustom moderDataGridViewCustom1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_check;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cumpara;
    }
}
