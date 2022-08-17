using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaraInventario
{
    public partial class Imagenes : Form
    {
        public Imagenes()
        {
            InitializeComponent();
        }

        private void Imagenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioPlataDataSetImagenes.Imagenes' Puede moverla o quitarla según sea necesario.
            this.imagenesTableAdapter.Fill(this.inventarioPlataDataSetImagenes.Imagenes);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pImagen.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                this.imagenesTableAdapter.Guardar(textIdProd.Text, textNombreP.Text, aByte);
                MessageBox.Show("Imagen cargada correctamente", "Aviso");

            }catch (NullReferenceException)
            {
                MessageBox.Show("Favor de cargar una imagen", "ERROR");
            }catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Favor de registrar primero el producto para dar de alta la imagen", "AVISO");
            }
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pImagen.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
