using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;


namespace AppCatalogo
{
    public partial class CatalogoForm : Form
    {
        List<Producto> listaProductos;
        CategoriaNegocio CategoriaNegocio = new CategoriaNegocio();
        MarcaNegocio MarcaNegocio = new MarcaNegocio();
        public CatalogoForm()
        {
            InitializeComponent();
        }
        private void MostrarBotones()
        {
            MainMenuForm main_menu = (MainMenuForm)this.MdiParent;
            main_menu.CatalogoButton.Visible = true;
            main_menu.AgregarButton.Visible = true;
            main_menu.ModificarButton.Visible = true;
        }
        private void CatalogoForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarBotones();
        }

        private void VolverAMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarDataGridView()
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            try
            {
                listaProductos = productoNegocio.ListarProductos();
                CatalogoDataGridView.DataSource = listaProductos;
                OcultarColumnas();
                CargarImagen(listaProductos[0].ImagenUrl);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        private void OcultarColumnas()
        {
            CatalogoDataGridView.Columns["Id"].Visible = false;
            CatalogoDataGridView.Columns["ImagenUrl"].Visible = false;
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                CatalogoPictureBox.Load(imagen);
            }
            catch (Exception)
            {
                CatalogoPictureBox.Load("https://as1.ftcdn.net/jpg/10/22/24/80/220_F_1022248039_7LDxHRi3Mlt9BK3wzLBUGZp9XAO1gt2s.jpg");

            }
        }
        private void CatalogoForm_Load(object sender, EventArgs e)
        {

            ActualizarDataGridView();
            CategoriaFiltroComboBox.DataSource = CategoriaNegocio.listarCategoria();
            CategoriaFiltroComboBox.ValueMember = "Id";
            CategoriaFiltroComboBox.DisplayMember = "Descripcion";
            MarcaFiltroComboBox.DataSource = MarcaNegocio.listarMarca();
            MarcaFiltroComboBox.ValueMember = "Id";
            MarcaFiltroComboBox.DisplayMember = "Descripcion";
            MarcaFiltroComboBox.SelectedIndex = -1;
            CategoriaFiltroComboBox.SelectedIndex = -1;

        }

        private void CatalogoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CatalogoDataGridView.CurrentRow != null)
            {
                Producto seleccionado = (Producto)CatalogoDataGridView.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            while (!(FiltroValido()))
            {
                string categoria = CategoriaFiltroComboBox.SelectedItem.ToString();
                string marca = MarcaFiltroComboBox.SelectedItem.ToString();
                CatalogoDataGridView.DataSource = productoNegocio.Filtrar(categoria, marca);
            }
        }

        private bool FiltroValido()
        {
            string validacion;
            if (MarcaFiltroComboBox.SelectedIndex != -1 || CategoriaFiltroComboBox.SelectedIndex != -1)
            {
                validacion = "Seleccionar una opción";
                AdvertenciaLabel.Text = validacion;
                return true;

            }
            else
                return false;
        }
    }
}
