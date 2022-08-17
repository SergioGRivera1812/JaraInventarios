using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaraInventario
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioPlataDataSetProducto.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.inventarioPlataDataSetProducto.Producto);
            // TODO: esta línea de código carga datos en la tabla 'inventarioPlataDataSetTotal.Total1' Puede moverla o quitarla según sea necesario.
            this.total1TableAdapter.FillxFiltro(this.inventarioPlataDataSetTotal.Total1);
            
            this.reportViewer1.RefreshReport();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
