namespace indiv1
{
    partial class Rapoarte
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_TopProduseVanduteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darwinDBDataSet = new indiv1.DarwinDBDataSet();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produseTableAdapter = new indiv1.DarwinDBDataSetTableAdapters.ProduseTableAdapter();
            this.darwinDBDataSet1 = new indiv1.DarwinDBDataSet();
            this.spTopProduseVanduteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_TopProduseVanduteTableAdapter = new indiv1.DarwinDBDataSetTableAdapters.sp_TopProduseVanduteTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKComenziClientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comenziTableAdapter = new indiv1.DarwinDBDataSetTableAdapters.ComenziTableAdapter();
            this.clientiTableAdapter1 = new indiv1.DarwinDBDataSetTableAdapters.ClientiTableAdapter();
            this.darwinTabControl1 = new indiv1.DarwinTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.sp_TopProduseVanduteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darwinDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darwinDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTopProduseVanduteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKComenziClientiBindingSource)).BeginInit();
            this.darwinTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp_TopProduseVanduteBindingSource
            // 
            this.sp_TopProduseVanduteBindingSource.DataMember = "sp_TopProduseVandute";
            this.sp_TopProduseVanduteBindingSource.DataSource = this.darwinDBDataSet;
            // 
            // darwinDBDataSet
            // 
            this.darwinDBDataSet.DataSetName = "DarwinDBDataSet";
            this.darwinDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.darwinDBDataSet;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // darwinDBDataSet1
            // 
            this.darwinDBDataSet1.DataSetName = "DarwinDBDataSet";
            this.darwinDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spTopProduseVanduteBindingSource
            // 
            this.spTopProduseVanduteBindingSource.DataMember = "sp_TopProduseVandute";
            this.spTopProduseVanduteBindingSource.DataSource = this.darwinDBDataSet;
            // 
            // sp_TopProduseVanduteTableAdapter
            // 
            this.sp_TopProduseVanduteTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.fKComenziClientiBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "indiv1.DateClienti.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(890, 655);
            this.reportViewer3.TabIndex = 3;
            // 
            // ClientiBindingSource
            // 
            this.ClientiBindingSource.DataMember = "Clienti";
            this.ClientiBindingSource.DataSource = this.darwinDBDataSet;
            // 
            // fKComenziClientiBindingSource
            // 
            this.fKComenziClientiBindingSource.DataMember = "FK_Comenzi_Clienti";
            this.fKComenziClientiBindingSource.DataSource = this.ClientiBindingSource;
            // 
            // comenziTableAdapter
            // 
            this.comenziTableAdapter.ClearBeforeFill = true;
            // 
            // clientiTableAdapter1
            // 
            this.clientiTableAdapter1.ClearBeforeFill = true;
            // 
            // darwinTabControl1
            // 
            this.darwinTabControl1.Controls.Add(this.tabPage1);
            this.darwinTabControl1.Controls.Add(this.tabPage2);
            this.darwinTabControl1.Controls.Add(this.tabPage3);
            this.darwinTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.darwinTabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.darwinTabControl1.ItemSize = new System.Drawing.Size(130, 35);
            this.darwinTabControl1.Location = new System.Drawing.Point(3, 3);
            this.darwinTabControl1.Name = "darwinTabControl1";
            this.darwinTabControl1.SelectedIndex = 0;
            this.darwinTabControl1.Size = new System.Drawing.Size(904, 704);
            this.darwinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.darwinTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 167);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produse";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.produseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "indiv1.Produse.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(534, 161);
            this.reportViewer1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(540, 167);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Top produse";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.sp_TopProduseVanduteBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "indiv1.ReportTop5pord.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(534, 161);
            this.reportViewer2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(896, 661);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Detalii Clienti";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Rapoarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.darwinTabControl1);
            this.Name = "Rapoarte";
            this.Size = new System.Drawing.Size(910, 710);
            ((System.ComponentModel.ISupportInitialize)(this.sp_TopProduseVanduteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darwinDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darwinDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTopProduseVanduteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKComenziClientiBindingSource)).EndInit();
            this.darwinTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private DarwinDBDataSet darwinDBDataSet;
        private DarwinDBDataSetTableAdapters.ProduseTableAdapter produseTableAdapter;
        private DarwinTabControl darwinTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DarwinDBDataSet darwinDBDataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource spTopProduseVanduteBindingSource;
        private System.Windows.Forms.BindingSource sp_TopProduseVanduteBindingSource;
        private DarwinDBDataSetTableAdapters.sp_TopProduseVanduteTableAdapter sp_TopProduseVanduteTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource ClientiBindingSource;
        private System.Windows.Forms.BindingSource fKComenziClientiBindingSource;
        private DarwinDBDataSetTableAdapters.ComenziTableAdapter comenziTableAdapter;
        private DarwinDBDataSetTableAdapters.ClientiTableAdapter clientiTableAdapter1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
