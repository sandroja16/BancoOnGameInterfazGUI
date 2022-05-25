using System;


namespace Presentacion
{
    public class Principal
    {
        public void MenuPrincipal()
        {
            int opcion;
            do
            {

                Console.Clear();
                Console.SetCursorPosition(32, 4); Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.SetCursorPosition(32, 5); Console.Write("~                       GameON banco                     ~");
                Console.SetCursorPosition(32, 6); Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.SetCursorPosition(32, 7); Console.Write("~                                                        ~");
                Console.SetCursorPosition(32, 8); Console.Write("~        1. CLIENTES                                     ~");
                Console.SetCursorPosition(32, 9); Console.Write("~        2. CUENTAS                                      ~");
                Console.SetCursorPosition(32, 10); Console.Write("~        3. SALIR                                        ~");
                Console.SetCursorPosition(32, 11); Console.Write("~                                                        ~");
                Console.SetCursorPosition(32, 12); Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.SetCursorPosition(32, 14); Console.Write("Digite una opcion: ");
                Console.SetCursorPosition(51, 14); opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        new PresentacionClientes().MenuClientes();
                        break;
                    case 2:
                        new PresentacionCuenta().MenuClientes();
                        break;

                    case 3:
                        Environment.Exit(3);
                        break;
                }
            } while (opcion != 3);

        }
    }
}

