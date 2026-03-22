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
    public partial class FormularioForm : Form
    {
        public FormularioForm()
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
        private void FormularioForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarBotones();
        }

        private void VolverAMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
