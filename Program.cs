using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIntroduccionCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el numero de la opción deseada");
            Console.WriteLine("1 - Generalidades");
            Console.WriteLine("2 - Enumeraciones");
            Console.WriteLine("3 - Conversiones");
            Console.WriteLine("3 - Otros");

            int optionSelected;
            string input = Console.ReadLine();
            if (!int.TryParse(input, out optionSelected))
            {
                Console.WriteLine("La opcion no es un numero u ocurrio otro error inesperado");
            }
            Console.Clear();
            switch(optionSelected) {
                case 1:
                    Generalities general = new Generalities();
                    general.Main();
                    break;
                case 2:
                    Enumerations enums = new Enumerations();
                    enums.Main();
                    break;
                case 3:
                    Conversions conversions = new Conversions();
                    conversions.Main();
                    break;
                case 4:
                    Others others = new Others();
                    others.Main();
                    break;
                default:
                    Console.WriteLine("La opcion seleccionada no existe");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadLine();
        }
    }
}
