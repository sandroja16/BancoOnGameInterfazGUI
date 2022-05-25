using System;

namespace Presentacion
{
    static class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Principal vistaPrincipal = new Principal();
            vistaPrincipal.MenuPrincipal();

        }
    }
}

