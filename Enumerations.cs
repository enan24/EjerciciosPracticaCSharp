using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIntroduccionCSharp
{

    class Enumerations
    {
        public enum Days
        {
            Domingo = 1,
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado
        }
        public void Main()
        {
            Console.WriteLine("Bienvenido a Enumeraciones");
            Console.WriteLine("Escriba un día de la semana para ver su valor");
            string input = Console.ReadLine();
            switch(input)
            {
                case nameof(Days.Domingo):
                    Console.WriteLine($"Elegiste el dia {Days.Domingo}");
                    break;
                case nameof(Days.Lunes):
                    Console.WriteLine($"Elegiste el dia {Days.Lunes}");
                    break;
                case nameof(Days.Martes):
                    Console.WriteLine($"Elegiste el dia {Days.Martes}");
                    break;
                case nameof(Days.Miercoles):
                    Console.WriteLine($"Elegiste el dia {Days.Miercoles}");
                    break;
                case nameof(Days.Jueves):
                    Console.WriteLine($"Elegiste el dia {Days.Jueves}");
                    break;
                case nameof(Days.Viernes):
                    Console.WriteLine($"Elegiste el dia {Days.Viernes}");
                    break;
                case nameof(Days.Sabado):
                    Console.WriteLine($"Elegiste el dia {Days.Sabado}");
                    break;
                default: break;
            }

        }
    }
}
