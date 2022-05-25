using System;

namespace Presentacion
{
    public class PresentacionClientes
    {
        public void MenuClientes()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(32, 4); Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.SetCursorPosition(32, 5); Console.Write("~                       GameON banco                     ~");
                Console.SetCursorPosition(32, 6); Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.SetCursorPosition(32, 7); Console.Write("~                                                         ~");
                Console.SetCursorPosition(32, 8); Console.Write("~        1. Agregar clientes                              ~");
                Console.SetCursorPosition(32, 9); Console.Write("~        2. Consultar cliente                             ~");
                Console.SetCursorPosition(32, 10); Console.Write("~        3. Modificar                                     ~");
                Console.SetCursorPosition(32, 11); Console.Write("~        4. Eliminar                                      ~");
                Console.SetCursorPosition(32, 12); Console.Write("~        5. Volver                                        ~");
                Console.SetCursorPosition(32, 13); Console.Write("~                                                         ~");
                Console.SetCursorPosition(32, 14); Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.SetCursorPosition(32, 16); Console.Write("Digite una opcion: ");
                Console.SetCursorPosition(50, 16); opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: // agregar
                        Console.Clear();
                        new Presentacion.Menu_Plantilla().Menu_presentacion();
                        MenuAgregar();
                        break;
                    case 2:
                        Console.Clear();
                        new Presentacion.Menu_Plantilla().Menu_presentacionConsultar();
                        MenuConsultar();
                        break;
                    case 3:
                        Console.Clear();
                        new Presentacion.Menu_Plantilla().Menu_presentacion();
                        MenuModificar();
                        break;
                    case 4:
                        Console.Clear();
                        new Presentacion.Menu_Plantilla().Menu_presentacion();
                        MenuEliminar();
                        break;
                    case 5:
                        break;
                }
            } while (opcion != 5);

        }

        public void MenuAgregar()
        {
            Entidad.Cliente cliente = new Entidad.Cliente();
            Logica.ServicioClientes servico = new Logica.ServicioClientes();
            Console.SetCursorPosition(50, 5); Console.Write("AGREGAR CLIENTE");
            Console.SetCursorPosition(32, 12); Console.Write("Id Cliente : ");
            Console.SetCursorPosition(45, 12); cliente.IdCliente = Console.ReadLine();
            Console.SetCursorPosition(32, 14); Console.Write("Nombre cliente : ");
            Console.SetCursorPosition(50, 14); cliente.Nombre = Console.ReadLine();
            Console.SetCursorPosition(32, 25); Console.Write(servico.Guardar(cliente));
            Console.ReadKey();
        }
        public void MenuConsultar()
        {
            Entidad.Cliente cliente = new Entidad.Cliente();
            Logica.ServicioClientes servico = new Logica.ServicioClientes();
            int i = 0;
            Console.SetCursorPosition(42, 5); Console.Write("Lista de clientes ");
            Console.SetCursorPosition(32, 7); Console.Write("IdCliente");
            Console.SetCursorPosition(52, 7); Console.Write("Nombre del cliente");
            foreach (var item in servico.Consultar())
            {
                i = i + 1;
                Console.SetCursorPosition(32, 8 + i); Console.Write(item.IdCliente);
                Console.SetCursorPosition(52, 8 + i); Console.Write(item.Nombre);
            }

            Console.ReadKey();
        }
        public void MenuEliminar()
        {
            Entidad.Cliente cliente;
            string id_cliente;
            Logica.ServicioClientes servico = new Logica.ServicioClientes();
            Console.SetCursorPosition(50, 5); Console.Write("Eliminar cliente");
            Console.SetCursorPosition(32, 10); Console.Write("id Cliente : ");
            Console.SetCursorPosition(32, 12); Console.Write("Nombre cliente : ");
            Console.SetCursorPosition(46, 10); id_cliente = Console.ReadLine();

            cliente = servico.BuscarID(id_cliente);
            if (cliente == null)
            {
                Console.Clear();
                new Presentacion.Menu_Plantilla().Menu_presentacion();
                Console.SetCursorPosition(50, 5); Console.Write("Eliminar cliente ");
                Console.SetCursorPosition(32, 25); Console.WriteLine("cliente no existe");
                Console.ReadKey();
                return;
            }

            Console.SetCursorPosition(47, 12); Console.WriteLine(cliente.Nombre);
            string op = string.Empty;
            Console.SetCursorPosition(32, 25); Console.WriteLine("desea eliniminar el cliente s/n ..");
            Console.SetCursorPosition(69, 25); op = Console.ReadLine();
            if (op.ToUpper() == "S")
            {
                Console.Clear();
                new Presentacion.Menu_Plantilla().Menu_presentacion();
                Console.SetCursorPosition(50, 5); Console.Write("Eliminar cliente ");
                Console.SetCursorPosition(32, 25); Console.Write(servico.Eliminar(id_cliente));

            }
            else
            {
                return;
            }
            Console.ReadKey();
        }
        public void MenuModificar()
        {
            Entidad.Cliente cliente = new Entidad.Cliente();
            string id_cliente;
            Logica.ServicioClientes servico = new Logica.ServicioClientes();
            Console.SetCursorPosition(50, 5); Console.Write("Modificar cliente ");
            Console.SetCursorPosition(32, 12); Console.Write("id Cliente : ");
            Console.SetCursorPosition(32, 14); Console.Write("nombre cliente : ");

            Console.SetCursorPosition(46, 12); id_cliente = Console.ReadLine();

            cliente = servico.BuscarID(id_cliente);
            if (cliente == null)
            {
                Console.Clear();
                new Presentacion.Menu_Plantilla().Menu_presentacion();
                Console.SetCursorPosition(50, 5); Console.Write("Modificar cliente ");
                Console.SetCursorPosition(32, 12); Console.Write("cliente no existe");

                Console.ReadKey();
                return;
            }

            Console.SetCursorPosition(49, 12); Console.Write(cliente.Nombre);

            string op = string.Empty;
            Console.SetCursorPosition(32, 25); Console.Write("Desea modificar el cliente s/n ..");
            Console.SetCursorPosition(62, 25); op = Console.ReadLine();
            if (op.ToUpper() == "S")
            {
                Console.Clear();
                new Presentacion.Menu_Plantilla().Menu_presentacion();
                Console.SetCursorPosition(50, 5); Console.Write("Modificar cliente ");
                Console.SetCursorPosition(32, 14); Console.Write("Nuevo Mombre del cliente  : ");
                Console.SetCursorPosition(60, 14); cliente.Nombre = Console.ReadLine();
                Console.SetCursorPosition(32, 25); Console.Write(servico.Modificar(cliente));


            }
            else
            {
                return;
            }
            Console.ReadKey();
        }

    }
}
