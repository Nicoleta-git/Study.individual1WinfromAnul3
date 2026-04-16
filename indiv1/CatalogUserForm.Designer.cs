namespace indiv1
{
    partial class CatalogUserForm
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
            this.cautaTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StocTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pretTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ImgProdus = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.HardwareTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.updateBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.softwareTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.saveBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.producatorTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.numeProdusTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.categorieProdusTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.idProdusTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Producator = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.importBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new ModerDataGridViewCustom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProdus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.cautaTxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 381);
            this.panel1.TabIndex = 0;
            // 
            // cautaTxt
            // 
            this.cautaTxt.Location = new System.Drawing.Point(77, 42);
            this.cautaTxt.Name = "cautaTxt";
            this.cautaTxt.Size = new System.Drawing.Size(246, 32);
            this.cautaTxt.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.cautaTxt.StateCommon.Border.Color1 = System.Drawing.Color.Purple;
            this.cautaTxt.StateCommon.Border.Color2 = System.Drawing.Color.Purple;
            this.cautaTxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cautaTxt.StateCommon.Border.Rounding = 4;
            this.cautaTxt.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.cautaTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cautaTxt.TabIndex = 15;
            this.cautaTxt.TextChanged += new System.EventHandler(this.cautaTxt_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cauta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total produse";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.StocTxt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pretTxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.HardwareTxt);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.softwareTxt);
            this.panel2.Controls.Add(this.saveBtn);
            this.panel2.Controls.Add(this.producatorTxt);
            this.panel2.Controls.Add(this.numeProdusTxt);
            this.panel2.Controls.Add(this.categorieProdusTxt);
            this.panel2.Controls.Add(this.idProdusTxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Producator);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.importBtn);
            this.panel2.Location = new System.Drawing.Point(21, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 295);
            this.panel2.TabIndex = 1;
            // 
            // StocTxt
            // 
            this.StocTxt.Location = new System.Drawing.Point(495, 74);
            this.StocTxt.Name = "StocTxt";
            this.StocTxt.Size = new System.Drawing.Size(160, 32);
            this.StocTxt.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.StocTxt.StateCommon.Border.Color1 = System.Drawing.Color.Purple;
            this.StocTxt.StateCommon.Border.Color2 = System.Drawing.Color.Purple;
            this.StocTxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StocTxt.StateCommon.Border.Rounding = 4;
            this.StocTxt.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.StocTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.StocTxt.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(389, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Stoc:";
            // 
            // pretTxt
            // 
            this.pretTxt.Location = new System.Drawing.Point(495, 35);
            this.pretTxt.Name = "pretTxt";
            this.pretTxt.Size = new System.Drawing.Size(160, 32);
            this.pretTxt.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.pretTxt.StateCommon.Border.Color1 = System.Drawing.Color.Purple;
            this.pretTxt.StateCommon.Border.Color2 = System.Drawing.Color.Purple;
            this.pretTxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pretTxt.StateCommon.Border.Rounding = 4;
            this.pretTxt.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.pretTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.pretTxt.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(386, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Pret: ";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(399, 243);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(109, 32);
            this.clearBtn.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.clearBtn.StateCommon.Back.Color2 = System.Drawing.Color.Purple;
            this.clearBtn.StateCommon.Back.ColorAngle = 45F;
            this.clearBtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.clearBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.clearBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearBtn.StateCommon.Border.Rounding = 5;
            this.clearBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.clearBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.clearBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.TabIndex = 28;
            this.clearBtn.Values.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(696, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 174);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ImgProdus);
            this.panel3.Location = new System.Drawing.Point(3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 162);
            this.panel3.TabIndex = 1;
            // 
            // ImgProdus
            // 
            this.ImgProdus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgProdus.Location = new System.Drawing.Point(0, 0);
            this.ImgProdus.Name = "ImgProdus";
            this.ImgProdus.Size = new System.Drawing.Size(140, 162);
            this.ImgProdus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgProdus.TabIndex = 0;
            this.ImgProdus.TabStop = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(274, 243);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(109, 32);
            this.deleteBtn.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.deleteBtn.StateCommon.Back.Color2 = System.Drawing.Color.Purple;
            this.deleteBtn.StateCommon.Back.ColorAngle = 45F;
            this.deleteBtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.deleteBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.deleteBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteBtn.StateCommon.Border.Rounding = 5;
            this.deleteBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.deleteBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.deleteBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.TabIndex = 27;
            this.deleteBtn.Values.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // HardwareTxt
            // 
            this.HardwareTxt.Location = new System.Drawing.Point(495, 155);
            this.HardwareTxt.Name = "HardwareTxt";
            this.HardwareTxt.Size = new System.Drawing.Size(160, 32);
            this.HardwareTxt.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.HardwareTxt.StateCommon.Border.Color1 = System.Drawing.Color.Purple;
            this.HardwareTxt.StateCommon.Border.Color2 = System.Drawing.Color.Purple;
            this.HardwareTxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.HardwareTxt.StateCommon.Border.Rounding = 4;
            this.HardwareTxt.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.HardwareTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.HardwareTxt.TabIndex = 13;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(159, 243);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(109, 32);
            this.updateBtn.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.updateBtn.StateCommon.Back.Color2 = System.Drawing.Color.Purple;
            this.updateBtn.StateCommon.Back.ColorAngle = 45F;
            this.updateBtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.updateBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.updateBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.updateBtn.StateCommon.Border.Rounding = 5;
            this.updateBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.updateBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.updateBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBtn.TabIndex = 26;
            this.updateBtn.Values.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // softwareTxt
            // 
            this.softwareTxt.Location = new System.Drawing.Point(495, 112);
            this.softwareTxt.Name = "softwareTxt";
            this.softwareTxt.Size = new System.Drawing.Size(160, 32);
            this.softwareTxt.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.softwareTxt.StateCommon.Border.Color1 = System.Drawing.Color.Purple;
            this.softwareTxt.StateCommon.Border.Color2 = System.Drawing.Color.Purple;
            this.softwareTxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.softwareTxt.StateCommon.Border.Rounding = 4;
            this.softwareTxt.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.softwareTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.softwareTxt.TabIndex = 12;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(44, 243);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(109, 32);
            this.saveBtn.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.saveBtn.StateCommon.Back.Color2 = System.Drawing.Color.Purple;
            this.saveBtn.StateCommon.Back.ColorAngle = 45F;
            this.saveBtn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.saveBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.saveBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveBtn.StateCommon.Border.Rounding = 5;
            this.saveBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.saveBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.saveBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.TabIndex = 25;
            this.saveBtn.Values.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // producatorTxt
            // 
            this.producatorTxt.Location = new System.Drawing.Point(183, 169);
            this.producatorTxt.Name = "producatorTxt";
            this.producatorTxt.Size = new System.Drawing.Size(160, 32);
            this.producatorTxt.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.producatorTxt.StateCommon.Border.Color1 = System.Drawing.Color.Purple;
            this.producatorTxt.StateCommon.Border.Color2 = System.Drawing.Color.Purple;
            this.producatorTxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.producatorTxt.StateCommon.Border.Rounding = 4;
            this.producatorTxt.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.producatorTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.producatorTxt.TabIndex = 11;
            // 
            // numeProdusTxt
            // 
            this.numeProdusTxt.Location = new System.Drawing.Point(183, 78);
            this.numeProdusTxt.Name = "numeProdusTxt";
            this.numeProdusTxt.Size = new System.Drawing.Size(160, 32);
            this.numeProdusTxt.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.numeProdusTxt.StateCommon.Border.Color1 = System.Drawing.Color.Purple;
            this.numeProdusTxt.StateCommon.Border.Color2 = System.Drawing.Color.Purple;
            this.numeProdusTxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.numeProdusTxt.StateCommon.Border.Rounding = 4;
            this.numeProdusTxt.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.numeProdusTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.numeProdusTxt.TabIndex = 10;
            // 
            // categorieProdusTxt
            // 
            this.categorieProdusTxt.Location = new System.Drawing.Point(183, 121);
            this.categorieProdusTxt.Name = "categorieProdusTxt";
            this.categorieProdusTxt.Size = new System.Drawing.Size(160, 32);
            this.categorieProdusTxt.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.categorieProdusTxt.StateCommon.Border.Color1 = System.Drawing.Color.Purple;
            this.categorieProdusTxt.StateCommon.Border.Color2 = System.Drawing.Color.Purple;
            this.categorieProdusTxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.categorieProdusTxt.StateCommon.Border.Rounding = 4;
            this.categorieProdusTxt.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.categorieProdusTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.categorieProdusTxt.TabIndex = 9;
            // 
            // idProdusTxt
            // 
            this.idProdusTxt.Location = new System.Drawing.Point(183, 35);
            this.idProdusTxt.Name = "idProdusTxt";
            this.idProdusTxt.Size = new System.Drawing.Size(160, 32);
            this.idProdusTxt.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.idProdusTxt.StateCommon.Border.Color1 = System.Drawing.Color.Purple;
            this.idProdusTxt.StateCommon.Border.Color2 = System.Drawing.Color.Purple;
            this.idProdusTxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.idProdusTxt.StateCommon.Border.Rounding = 4;
            this.idProdusTxt.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.idProdusTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.idProdusTxt.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(389, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "HardWare:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(389, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Software:";
            // 
            // Producator
            // 
            this.Producator.AutoSize = true;
            this.Producator.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Producator.ForeColor = System.Drawing.Color.White;
            this.Producator.Location = new System.Drawing.Point(23, 169);
            this.Producator.Name = "Producator";
            this.Producator.Size = new System.Drawing.Size(100, 23);
            this.Producator.TabIndex = 5;
            this.Producator.Text = "Producator:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nume produs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categorie produs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id produs:";
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.Black;
            this.importBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.importBtn.Location = new System.Drawing.Point(699, 215);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(140, 33);
            this.importBtn.TabIndex = 2;
            this.importBtn.Text = "IMPORT";
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.dataGridView1.Location = new System.Drawing.Point(24, 90);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(822, 263);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CatalogUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CatalogUserForm";
            this.Size = new System.Drawing.Size(910, 710);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgProdus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ImgProdus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Producator;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox HardwareTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox softwareTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox producatorTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox numeProdusTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox categorieProdusTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox idProdusTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox cautaTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton clearBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton updateBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton saveBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox pretTxt;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox StocTxt;
        private System.Windows.Forms.Label label9;
        private ModerDataGridViewCustom dataGridView1;
    }
}
