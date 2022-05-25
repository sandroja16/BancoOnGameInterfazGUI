using Entidad;
using Logica;
using System;
using System.Windows.Forms;
//ESTUDIANTE Sandro Antonio Jaramillo Ortiz 
namespace PresentacionGUI
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtIdCliente.Text);
        }
        void Buscar(string id)
        {
            ServicioClientes servicioClientes = new ServicioClientes();
            Cliente cliente;
            cliente = servicioClientes.BuscarID(id);
            if (cliente == null) 
            {
                MessageBox.Show("Cliente no exite ");
                return;
            }
            ver(cliente);
        }
        void ver(Cliente cliente)
        {
            txtIdCliente.Text = cliente.IdCliente;
            txtNombre.Text = cliente.Nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar(new Cliente(txtIdCliente.Text,txtNombre.Text));
            Nuevo();
        }
        void Guardar(Cliente cliente)
        {
            Logica.ServicioClientes servicioClientes = new ServicioClientes();

            string mensaje = servicioClientes.Guardar(cliente);
            MessageBox.Show(mensaje);
       
          

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            
        }
        void Nuevo()
        {
            if (txtIdCliente.Text != "")
            {
                txtIdCliente.Text = "";
            }
            if (txtNombre.Text != "")
            {
                txtNombre.Text = "";
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
