namespace JaraInventario
{
    partial class Reportes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioPlataDataSetProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioPlataDataSetProducto = new JaraInventario.InventarioPlataDataSetProducto();
            this.total1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioPlataDataSetTotal = new JaraInventario.InventarioPlataDataSetTotal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.total1TableAdapter = new JaraInventario.InventarioPlataDataSetTotalTableAdapters.Total1TableAdapter();
            this.productoTableAdapter = new JaraInventario.InventarioPlataDataSetProductoTableAdapters.ProductoTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioPlataDataSetProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioPlataDataSetProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioPlataDataSetTotal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.inventarioPlataDataSetProductoBindingSource;
            // 
            // inventarioPlataDataSetProductoBindingSource
            // 
            this.inventarioPlataDataSetProductoBindingSource.DataSource = this.inventarioPlataDataSetProducto;
            this.inventarioPlataDataSetProductoBindingSource.Position = 0;
            // 
            // inventarioPlataDataSetProducto
            // 
            this.inventarioPlataDataSetProducto.DataSetName = "InventarioPlataDataSetProducto";
            this.inventarioPlataDataSetProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // total1BindingSource
            // 
            this.total1BindingSource.DataMember = "Total1";
            this.total1BindingSource.DataSource = this.inventarioPlataDataSetTotal;
            // 
            // inventarioPlataDataSetTotal
            // 
            this.inventarioPlataDataSetTotal.DataSetName = "InventarioPlataDataSetTotal";
            this.inventarioPlataDataSetTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetProd";
            reportDataSource1.Value = this.productoBindingSource;
            reportDataSource2.Name = "DataSetTotal";
            reportDataSource2.Value = this.total1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JaraInventario.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1350, 696);
            this.reportViewer1.TabIndex = 0;
            // 
            // total1TableAdapter
            // 
            this.total1TableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioPlataDataSetProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioPlataDataSetProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioPlataDataSetTotal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private InventarioPlataDataSetProducto inventarioPlataDataSetProducto;
        private System.Windows.Forms.BindingSource inventarioPlataDataSetProductoBindingSource;
        private InventarioPlataDataSetTotal inventarioPlataDataSetTotal;
        private System.Windows.Forms.BindingSource total1BindingSource;
        private InventarioPlataDataSetTotalTableAdapters.Total1TableAdapter total1TableAdapter;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private InventarioPlataDataSetProductoTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}