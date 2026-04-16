namespace indiv1
{
    partial class Produs
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
            this.productTxt = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgProdus = new System.Windows.Forms.PictureBox();
            this.add_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProdus)).BeginInit();
            this.SuspendLayout();
            // 
            // productTxt
            // 
            this.productTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTxt.ForeColor = System.Drawing.Color.White;
            this.productTxt.Location = new System.Drawing.Point(3, 136);
            this.productTxt.Name = "productTxt";
            this.productTxt.Size = new System.Drawing.Size(209, 66);
            this.productTxt.TabIndex = 1;
            this.productTxt.Text = "Nume Produs:";
            // 
            // priceTxt
            // 
            this.priceTxt.AutoSize = true;
            this.priceTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTxt.ForeColor = System.Drawing.Color.White;
            this.priceTxt.Location = new System.Drawing.Point(12, 221);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(50, 23);
            this.priceTxt.TabIndex = 2;
            this.priceTxt.Text = "$0.00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 324);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.add_btn);
            this.panel3.Controls.Add(this.productTxt);
            this.panel3.Controls.Add(this.priceTxt);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 318);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.imgProdus);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 130);
            this.panel1.TabIndex = 28;
            // 
            // imgProdus
            // 
            this.imgProdus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgProdus.Location = new System.Drawing.Point(0, 0);
            this.imgProdus.Name = "imgProdus";
            this.imgProdus.Size = new System.Drawing.Size(211, 130);
            this.imgProdus.TabIndex = 1;
            this.imgProdus.TabStop = false;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(7, 267);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(199, 39);
            this.add_btn.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.add_btn.StateCommon.Back.Color2 = System.Drawing.Color.Purple;
            this.add_btn.StateCommon.Back.ColorAngle = 45F;
            this.add_btn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.add_btn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.add_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.add_btn.StateCommon.Border.Rounding = 5;
            this.add_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.add_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.add_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.TabIndex = 27;
            this.add_btn.Values.Text = "Adauga in cos";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Produs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel2);
            this.Name = "Produs";
            this.Size = new System.Drawing.Size(233, 330);
            this.Load += new System.EventHandler(this.Produs_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProdus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label productTxt;
        private System.Windows.Forms.Label priceTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton add_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgProdus;
    }
}
