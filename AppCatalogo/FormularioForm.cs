using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace AppCatalogo
{
    public partial class FormularioForm : Form
    {
        private Producto producto = null;

        public FormularioForm()
        {
            InitializeComponent();

        }
        public FormularioForm(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            FormularioGroupBox.Text = "Modificar";
        }
        private void MostrarBotones()
        {
            MainMenuForm main_menu = (MainMenuForm)this.MdiParent;
            main_menu.CatalogoButton.Visible = true;
            main_menu.AgregarButton.Visible = true;
            main_menu.ModificarButton.Visible = true;
        }
        private void FormularioForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarBotones();
        }

        private void VolverAMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            try
            {
                if (producto == null)
                {
                    producto = new Producto();
                }
                producto.Codigo = CodigoTextBox.Text;
                producto.Nombre = NombreTextBox.Text;
                producto.Descripcion = DescripcionTextBox.Text;
                producto.Marca = (Marca)MarcaComboBox.SelectedItem;
                producto.Categoria = (Categoria)CategoriaComboBox.SelectedItem;
                producto.ImagenUrl = ImagenTextBox.Text;
                producto.Precio = double.Parse(PrecioTextBox.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormularioForm_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                MarcaComboBox.DataSource = marcaNegocio.listarMarca();
                MarcaComboBox.ValueMember = "Id";
                MarcaComboBox.DisplayMember = "Descripcion";
                MarcaComboBox.SelectedIndex = -1;
                CategoriaComboBox.DataSource = categoriaNegocio.listarCategoria();
                CategoriaComboBox.ValueMember = "Id";
                CategoriaComboBox.DisplayMember = "Descripcion";
                CategoriaComboBox.SelectedIndex = -1;

                if (producto != null)
                {
                    CodigoTextBox.Text = producto.Codigo;
                    NombreTextBox.Text = producto.Nombre;
                    DescripcionTextBox.Text = producto.Descripcion;
                    ImagenTextBox.Text = producto.ImagenUrl;
                    CargarImagen(producto.ImagenUrl);
                    MarcaComboBox.SelectedValue = producto.Marca.Id;
                    CategoriaComboBox.SelectedValue = producto.Categoria.Id;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                ImagenPictureBox.Load(imagen);
            }
            catch (Exception)
            {
                ImagenPictureBox.Load("https://as1.ftcdn.net/jpg/10/22/24/80/220_F_1022248039_7LDxHRi3Mlt9BK3wzLBUGZp9XAO1gt2s.jpg");
            }
        }

        private void ImagenTextBox_Leave(object sender, EventArgs e)
        {
            CargarImagen(ImagenTextBox.Text);
        }
    }
}
