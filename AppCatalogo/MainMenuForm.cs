using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppCatalogo
{
    public partial class MainMenuForm : Form
    {
        
        public MainMenuForm()
        {
            InitializeComponent();
        }
        private void OcultarBotones()
        {
            try
            {
                CatalogoButton.Visible = false;
                AgregarButton.Visible = false;
                ModificarButton.Visible = false;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CatalogoButton_Click(object sender, EventArgs e)
        {
            
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(CatalogoForm))
                {
                    return;
                }
            }
            do
            {
                CatalogoForm catalogo_menu = new CatalogoForm();
                catalogo_menu.MdiParent = this;
                catalogo_menu.Show();
                OcultarBotones();

            } while (false);

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormularioForm))
                {
                    return;
                }
            }
            do
            {
                FormularioForm catalogo_menu = new FormularioForm();
                catalogo_menu.MdiParent = this;
                catalogo_menu.Show();
                OcultarBotones();

                ComboBox codigoProducto = catalogo_menu.Controls.Find("CodigoComboBox", true).FirstOrDefault() as ComboBox;
                codigoProducto.Hide();
                TextBox nombreTextoBox = catalogo_menu.Controls.Find("NombreTextBox", true).FirstOrDefault() as TextBox;
                nombreTextoBox.Clear();
                TextBox descripcionTextBox = catalogo_menu.Controls.Find("DescripcionTextBox", true).FirstOrDefault() as TextBox;
                descripcionTextBox.Clear();
                ComboBox marcaComboBox = catalogo_menu.Controls.Find("MarcaComboBox", true).FirstOrDefault() as ComboBox;
                marcaComboBox.SelectedIndex = -1;
                ComboBox categoriaComboBox = catalogo_menu.Controls.Find("CategoriaComboBox", true).FirstOrDefault() as ComboBox;
                categoriaComboBox.SelectedIndex = -1;
                TextBox imagenTextBox = catalogo_menu.Controls.Find("ImagenTextBox", true).FirstOrDefault() as TextBox;
                imagenTextBox.Clear();
                TextBox precioTextBox = catalogo_menu.Controls.Find("PrecioTextBox", true).FirstOrDefault() as TextBox;
                precioTextBox.Clear();
                PictureBox imagenPictureBox = catalogo_menu.Controls.Find("ImagenPictureBox", true).FirstOrDefault() as PictureBox;
                imagenPictureBox.Image = null;

            } while (false);
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormularioForm))
                {
                    return;
                }
            }
            do
            {
                FormularioForm catalogo_menu = new FormularioForm();
                catalogo_menu.MdiParent = this;
                catalogo_menu.Show();
                OcultarBotones();
                 
                TextBox codigoProducto = catalogo_menu.Controls.Find("CodigoTextBox", true).FirstOrDefault() as TextBox;
                codigoProducto.Hide();
                

            } while (false);
                        

        }
    }
}
