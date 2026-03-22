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

            } while (false);

        }
    }
}
