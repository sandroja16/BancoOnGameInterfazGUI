using Entidad;
using Logica;
using System;
namespace Presentacion
{
    public class PresentacionCuenta
    {

        public void MenuClientes()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(31, 4); Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.SetCursorPosition(31, 5); Console.Write("~                       GameON banco                     ~");
                Console.SetCursorPosition(31, 6); Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.SetCursorPosition(31, 7); Console.Write("~                                                        ~");
                Console.SetCursorPosition(31, 8); Console.Write("~        1. Agregar cuenta                               ~");
                Console.SetCursorPosition(31, 9); Console.Write("~        2. Consultar cuenta                             ~");
                Console.SetCursorPosition(31, 10); Console.Write("~        3.Consignar                                     ~");
                Console.SetCursorPosition(31, 11); Console.Write("~        4.Retirar                                       ~");
                Console.SetCursorPosition(31, 12); Console.Write("~        5.Volver                                        ~");
                Console.SetCursorPosition(31, 13); Console.Write("~                                                        ~");
                Console.SetCursorPosition(31, 14); Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.SetCursorPosition(31, 16); Console.Write("Digite una opcion:  ");
                Console.SetCursorPosition(51, 16); opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: 
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
                        MenuConsignar();
                        break;
                    case 4:
                        Console.Clear();
                        new Presentacion.Menu_Plantilla().Menu_presentacion();
                        MenuRetirar();
                        break;
                    case 5:
                        break;

                }
            } while (opcion != 5);
        }

        void MenuAgregar()
        {
            Cliente clientes;

            double numCuenta, saldo;
            string id;
            Console.SetCursorPosition(50, 5); Console.Write("Crear cuenta ");
            Logica.ServicioCuentas servico = new Logica.ServicioCuentas();
            Console.SetCursorPosition(31, 10); Console.Write("id Cliente : "); Console.SetCursorPosition(45, 10); id = Console.ReadLine();

            clientes = new ServicioClientes().BuscarID(id);

            if (clientes == null)
            {
                Console.Clear();
                Console.SetCursorPosition(50, 5); Console.Write("Crear cuenta ");
                new Presentacion.Menu_Plantilla().Menu_presentacion();
                Console.SetCursorPosition(32, 25); Console.WriteLine("cliente no existe ... debe crearlo primero");
                Console.ReadKey();
                return;
            }
            Console.SetCursorPosition(31, 12); Console.Write("Numero de cuenta : ");
            Console.SetCursorPosition(49, 12); numCuenta = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(31, 14); Console.Write("saldo inicial : ");
            Console.SetCursorPosition(47, 14); saldo = double.Parse(Console.ReadLine());
            Cuenta cuenta = new Cuenta(numCuenta, clientes, saldo);

            Console.SetCursorPosition(32, 25); Console.Write(servico.Guardar(cuenta));
            Console.ReadKey();
        }
        void MenuConsultar()
        {
            int i = 0;
            Logica.ServicioCuentas servico = new Logica.ServicioCuentas();

            Console.SetCursorPosition(50, 5); Console.Write("Lista de cuentas ");
            Console.SetCursorPosition(26, 7); Console.WriteLine("NUMERO ");
            Console.SetCursorPosition(46, 7); Console.WriteLine("NOMBRE CLIENTE");
            Console.SetCursorPosition(75, 7); Console.WriteLine("SALDO");
            foreach (var item in servico.Consultar())
            {
                i = i + 1;
                Console.SetCursorPosition(26, 8 + i); Console.Write(item.NumeroCuenta);
                Console.SetCursorPosition(46, 8 + i); Console.Write(item.Cliente.Nombre);
                Console.SetCursorPosition(75, 8 + i); Console.Write(item.getSaldo());
            }

            Console.ReadKey();
        }
        public void MenuConsignar()
        {
            Cuenta cuenta;
            double numCuenta;
            Logica.ServicioCuentas servico = new Logica.ServicioCuentas();
            Console.SetCursorPosition(50, 5); Console.Write("Consignar dinero :");
            Console.SetCursorPosition(31, 12); Console.Write("Numero de cuenta :");
            Console.SetCursorPosition(51, 12); numCuenta = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(31, 14); Console.Write("Digite el valor a consinar:");
            Console.SetCursorPosition(59, 14); double valor = double.Parse(Console.ReadLine());
            var lista = new ServicioCuentas();
            cuenta = lista.BuscarCuenta(numCuenta);
            if (cuenta == null)
            {
                Console.Clear();
                Console.SetCursorPosition(50, 5); Console.Write("Consignar dinero :");
                new Presentacion.Menu_Plantilla().Menu_presentacion();
                Console.SetCursorPosition(32, 25); Console.WriteLine(" Cuenta no existe");
                Console.ReadKey();
                return;
            }
            else
            {

                string op = string.Empty;
                Console.SetCursorPosition(32, 25); Console.WriteLine("Desea consignar dinero la cuenta s/n ..");
                Console.SetCursorPosition(71, 25); op = Console.ReadLine();
                if (op.ToUpper() == "S")
                {
                    
                    
                    cuenta.Consignar(valor);
                    Console.Clear();
                    Console.SetCursorPosition(50, 5); Console.Write("Consignar dinero :");
                    new Presentacion.Menu_Plantilla().Menu_presentacion();
                    new ServicioCuentas().Modifar(lista.Consultar());
                    Console.SetCursorPosition(32, 25); Console.WriteLine("Consinacion exitosa $"+" " +  valor + " " + "gracias por usar nuestros servicios ");

                }
                Console.ReadKey();
                return;
            }





        }

        public void MenuRetirar()
        {
            Cuenta cuenta;
            double numCuenta;
            Logica.ServicioCuentas servico = new Logica.ServicioCuentas();
            Console.SetCursorPosition(50, 5); Console.Write("Retirar dinero :");
            Console.SetCursorPosition(31, 12); Console.Write("Numero de cuenta :");
            Console.SetCursorPosition(51, 12); numCuenta = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(31, 14); Console.Write("Digite el valor a retirar:");
            Console.SetCursorPosition(59, 14); double valor = double.Parse(Console.ReadLine());
            var lista = new ServicioCuentas();
            cuenta = lista.BuscarCuenta(numCuenta);
           
            if (cuenta == null)
            {
                Console.Clear();
                Console.SetCursorPosition(50, 5); Console.Write("Retirar dinero :");
                new Presentacion.Menu_Plantilla().Menu_presentacion();
                Console.SetCursorPosition(32, 25); Console.WriteLine(" Cuenta no existe");
                Console.ReadKey();
                return;
            }
            else
            {
                string op = string.Empty;
                Console.SetCursorPosition(32, 25); Console.WriteLine("Desea retirar dinero la cuenta s/n ..");
                Console.SetCursorPosition(71, 25); op = Console.ReadLine();
                if (op.ToUpper() == "S")
                {
                    
                    cuenta.Retirar(valor);
                    new ServicioCuentas().Modifar(lista.Consultar());
                    Console.Clear();
                    Console.SetCursorPosition(50, 5); Console.Write("Retirar dinero :");
                    new Presentacion.Menu_Plantilla().Menu_presentacion();
                    Console.SetCursorPosition(32, 25); Console.WriteLine("Retiro  exitoso... $" + " " + valor + " " + "gracias por usar nuestras servicios ");


                }
                Console.ReadKey();
                return;
            }



        }

    }

}


