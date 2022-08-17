using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaraInventario
{
    public partial class Inventario : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-4GN06VU;Initial Catalog=InventarioPlata;Integrated Security=True");
        public Inventario()
        {
            InitializeComponent();
        }
        private void SumaCol()
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                total += Convert.ToInt32(row.Cells["Total"].Value);
                textTotal.Text = total.ToString();
            }
       
        }
        
        
        private void SumaArt()
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                total += Convert.ToInt32(row.Cells["totalArt"].Value);
                textArticulos.Text = total.ToString();
            }
        }
        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioPlataDataSetTotal.Total1' Puede moverla o quitarla según sea necesario.
            //this.total1TableAdapter.FillByNormal(this.inventarioPlataDataSetTotal.Total1);
            // TODO: esta línea de código carga datos en la tabla 'inventarioPlataDataSetTotal.Total' Puede moverla o quitarla según sea necesario.
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if(textID.Text == String.Empty)
            {
                MessageBox.Show("Campo ID vacio , favor de llenarlo", "AVISO");
            }else
            {
                try
                {
                  int precio = 0 ,  cantidad =0;
                  int multi;
                  string p;
                  precio = Convert.ToInt32(textPrecio.Text);
                  cantidad = Convert.ToInt32(textCantidad.Text);
                  multi = precio * cantidad;
                  p = Convert.ToString(multi);
                  


                    this.productoTableAdapter.Guardar(textID.Text, textArticulo.Text, textPrecio.Text, textCantidad.Text, textMedidas.Text, textCategoria.Text, textFamilia.Text, textFormato.Text, textModelo.Text, textComodin.Text);
                    this.productoTableAdapter.Fill(this.inventarioPlataDataSetProducto.Producto);
                    this.totalTableAdapter.Guardad(p,textCantidad.Text, DateTime.Now.ToString("d"),textID.Text);
                    this.totalTableAdapter.Fill(this.inventarioPlataDataSetTotal.Total);
                    
                    
                    SumaCol();
                    SumaArt();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("ID duplicado", "AVISO");
                }
                            
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            

            this.productoTableAdapter.Fill(this.inventarioPlataDataSetProducto.Producto);
            this.imagenesTableAdapter.Fill(this.inventarioPlataDataSetImagenes.Imagenes);
            this.totalTableAdapter.Fill(this.inventarioPlataDataSetTotal.Total);
            SumaCol();
            SumaArt();
            textID.Text = "";
            textArticulo.Text = "";
            textPrecio.Text = "";
            textCantidad.Text = "";
            textMedidas.Text = "";
            textCategoria.Text = "";
            textFamilia.Text = "";
            textFormato.Text = "";
            textModelo.Text = "";
            textComodin.Text = "";
        }

        private void dataGridProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = this.dataGridProd.SelectedRows[0].Cells[0].Value.ToString();
                string ar = this.dataGridProd.SelectedRows[0].Cells[1].Value.ToString();
                string pr = this.dataGridProd.SelectedRows[0].Cells[2].Value.ToString();
                string can = this.dataGridProd.SelectedRows[0].Cells[3].Value.ToString();
                string med = this.dataGridProd.SelectedRows[0].Cells[4].Value.ToString();
                string cat = this.dataGridProd.SelectedRows[0].Cells[5].Value.ToString();
                string fam = this.dataGridProd.SelectedRows[0].Cells[6].Value.ToString();
                string form = this.dataGridProd.SelectedRows[0].Cells[7].Value.ToString();
                string mod = this.dataGridProd.SelectedRows[0].Cells[8].Value.ToString();
                string com = this.dataGridProd.SelectedRows[0].Cells[9].Value.ToString();

                textID.Text = id;
                textArticulo.Text = ar;
                textPrecio.Text = pr;
                textCantidad.Text = can;
                textMedidas.Text = med;
                textCategoria.Text = cat;
                textFamilia.Text = fam;
                textFormato.Text = form;
                textModelo.Text = mod;
                textComodin.Text = com;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Favor de seleccionar la primera columna para continuar", "AVISO");

            }

        }

        private void textModificar_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridProd.Rows.Count > 0)
            {
                conexion.Open();

                SqlCommand cmd = conexion.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Producto where IdProducto like ('" + textModificar.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dataGridProd.DataSource = dt;
                conexion.Close();

            }
            else if (dataGridProd.Rows.Count <= 0)
            {
                MessageBox.Show("ID o Producto no encontrado", "AVISO");
                textEliminar.Text = "";
                conexion.Open();

                SqlCommand cmd = conexion.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Producto where IdProducto like ('" + textModificar.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dataGridProd.DataSource = dt;
                conexion.Close();

            }
        }

        private void textEliminar_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridProd.Rows.Count > 0)
            {
                conexion.Open();

                SqlCommand cmd = conexion.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Producto where IdProducto like ('" + textEliminar.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dataGridProd.DataSource = dt;
                conexion.Close();

            }
            else if (dataGridProd.Rows.Count <= 0)
            {
                MessageBox.Show("ID o Producto no encontrado", "AVISO");
                textEliminar.Text = "";
                conexion.Open();

                SqlCommand cmd = conexion.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Producto where IdProducto like ('" + textEliminar.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dataGridProd.DataSource = dt;
                conexion.Close();

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes();
            r.Show();
        }

        private void Inventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Imagenes I = new Imagenes();
            I.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int precio = 0, cantidad = 0;
            int multi;
            string p;
            precio = Convert.ToInt32(textPrecio.Text);
            cantidad = Convert.ToInt32(textCantidad.Text);
            multi = precio * cantidad;
            p = Convert.ToString(multi);

            this.productoTableAdapter.Modificar(textID.Text, textArticulo.Text, textPrecio.Text, textCantidad.Text, textMedidas.Text, textCategoria.Text, textFamilia.Text, textFormato.Text, textModelo.Text, textComodin.Text,textModificar.Text);
            this.totalTableAdapter.Guardad(p, textCantidad.Text, DateTime.Now.ToString("d"), textID.Text);
            this.productoTableAdapter.Fill(this.inventarioPlataDataSetProducto.Producto);
            MessageBox.Show("Articulo modificado", "Mensaje");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.productoTableAdapter.Eliminar(textEliminar.Text);
            this.productoTableAdapter.Fill(this.inventarioPlataDataSetProducto.Producto);
            MessageBox.Show("Articulo Eliminado", "Mensaje");
        }
    }
}
