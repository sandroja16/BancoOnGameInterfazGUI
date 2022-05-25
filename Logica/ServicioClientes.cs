using Datos;
using Entidad;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class ServicioClientes
    {
       
        List<Cliente> clientes;
        RepositorioClientes repositorioClientes = new RepositorioClientes();
        public ServicioClientes()
        {
            clientes = repositorioClientes.ConsultarTodos();  
        }

        public string Guardar(Cliente cliente)
        {
            string mensaje = string.Empty;
            try
            {

                if (repositorioClientes.Buscar(cliente.IdCliente) == null)
                {
                    mensaje = repositorioClientes.Guardar(cliente);
                    Actualizar();
                    return mensaje; 
                }
                return mensaje; 
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }

        private void Actualizar()
        {
            clientes = repositorioClientes.ConsultarTodos();
        }
        public List<Cliente> Consultar()
        {
            return clientes;
        }

        public Cliente BuscarID(string IDcliente)
        {
            foreach (var item in clientes)
            {
                if (item.IdCliente == IDcliente)
                {
                    return item;
                }

            }
            return null;

        }

        public string Eliminar(string identificacion)
        {
            Cliente cliente = BuscarID(identificacion);
            if (cliente == null)
            {
                return "cliente no existe";
            }
            else
            {
                clientes.Remove(cliente);

                repositorioClientes.Modificar_tmp(clientes);
                return "cliente eliminado";
            }
        }
        public string Modificar(Cliente cliente_New)
        {
            Cliente cliente_actual = BuscarID(cliente_New.IdCliente);
            if (cliente_actual == null)
            {
                return Guardar(cliente_New);

            }
            else
            {
                cliente_actual.Nombre = cliente_New.Nombre;
                return repositorioClientes.Modificar_tmp(clientes);
            }


        }


        public class ClienteConsultaResponse
        {
            public List<Cliente> Clientes { get; set; }
            public string Message { get; set; }
            public bool Error { get; set; }
            public bool ClienteEncontrado { get; set; }
            public ClienteConsultaResponse(string message)
            {
                Error = true;
                Message = message;
                ClienteEncontrado = false;
            }
            public ClienteConsultaResponse(List<Cliente> clientes)
            {
                Clientes = clientes;
                Error = false;
                ClienteEncontrado = true;
            }
        }
    }
}

