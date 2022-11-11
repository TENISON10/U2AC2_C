using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2AC2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreusuario, contraseña;
            byte colores = 0;

            Console.WriteLine("ingresa tu nombre de usuario");
            nombreusuario = Console.ReadLine();
            Console.WriteLine("ingresa tu contraseña");
            contraseña = Console.ReadLine();
            Console.WriteLine("ingresa el numero 50 si quieres la combinacion de colores gris con azul oscuro'");
            Console.WriteLine("ingresa el numero 60 si quieres la combinacion de colores azul con amarillo");
            Console.WriteLine("ingresa el numero 70 si quieres la combinacion de colores cyan con verde");
            colores = Convert.ToByte(Console.ReadLine());

            if (colores ==50)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("ingresa tu nombre de usuario");
                nombreusuario = Console.ReadLine();
                Console.Clear();
            }
            if (colores == 60)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ingresa tu nombre de usuario");
                nombreusuario = Console.ReadLine();
                Console.Clear();
            }
            if (colores == 70)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ingresa tu nombre de usuario");
                nombreusuario = Console.ReadLine();
                Console.Clear();
            }

            Console.ReadKey();

        }
    }
}
