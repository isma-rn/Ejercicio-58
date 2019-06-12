using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E58_FahrenheitACelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string opcion;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Programa que convierte grados Fahrenheit a Censius");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese grados Fahrenheit:");
                
                if( Double.TryParse( Console.ReadLine(), out double numero) )
                {
                    Console.WriteLine("Resultado:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t{0:0.####}°C", ConvertirFahrenheitACelsius(numero) );

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error al ingresar grados Fahrenheit");
                }

                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("n : nuevo, s : salir");
                    opcion = Console.ReadLine();

                    if (opcion.Equals("s"))
                    {
                        salir = true;
                        break;
                    }
                    else if (!opcion.Equals("n"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se reconoce opción...");
                    }
                    else
                        break;
                } while (true);

            } while (!salir);
        }
        //(32 °F − 32) × 5/9 = 0 °C
        public static double ConvertirFahrenheitACelsius(double numero)
        {
            return (( numero-32 )* 5) / 9;
        }
    }
}
