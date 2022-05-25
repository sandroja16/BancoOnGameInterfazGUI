using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;
namespace PresentacionGUI
{
    public partial class FormListaDeCliente : Form
    {
        public FormListaDeCliente()
        {
            InitializeComponent();
        }

        private void ListaDeCliente_Load(object sender, EventArgs e)
        {

        }
        void ListaCliente()
        {
            Logica.ServicioClientes servicioClientes = new ServicioClientes();

        }
    }
}

