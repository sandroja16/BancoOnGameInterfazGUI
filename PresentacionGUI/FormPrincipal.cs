using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCientes_Click(object sender, EventArgs e)
        {

            if (PanelMenuCliente.Visible == true)
            {
                PanelMenuCliente.Visible = false;
            }
            else
            {
                PanelMenuCliente.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            if (PanelMenuCuenta.Visible == true)
            {
                PanelMenuCuenta.Visible = false;
            }
            else
            {
                PanelMenuCuenta.Visible = true;
            }

        }

        private void PanelMenuCuenta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel_segundario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarCiente_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultarCliente_Click(object sender, EventArgs e)
        {
            FormListaDeCliente formListaDeCliente = new FormListaDeCliente();
           formListaDeCliente.ShowDialog();

        }
    }
    
}
