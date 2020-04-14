using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIntroduccionCSharp
{
    class Generalities
    {
        public void Main()
        {
            Console.WriteLine("Escriba el numero de la opción deseada");
            Console.WriteLine("1 - Sumar dos numeros");
            Console.WriteLine("2 - Devolver primeros 4 caracteres de un string");
            Console.WriteLine("3 - Fecha y hora");
            string optionSelected = Console.ReadLine();
            int option;
            if (!int.TryParse(optionSelected, out option))
            {
                Console.WriteLine("El valor insertado no es valido");
            }
            switch (option)
            {
                case 1:
                    Console.WriteLine("Escriba el numero 1 de la suma");
                    string numero1 = Console.ReadLine();
                    Console.WriteLine("Escriba el numero 2 de la suma");
                    string numero2 = Console.ReadLine();
                    bool error;
                    int result = Sum(numero1, numero2, out error);
                    if (!error)
                    {
                        Console.WriteLine($"El resultado de la suma es: {result}");
                    }
                    break;
                case 2:
                    Console.WriteLine("Inserte una cadena, se devolveran los primeros 4 caracteres");
                    string input = Console.ReadLine();
                    CutString(ref input, 4);
                    Console.WriteLine($"El resultado del corte es: {input}");
                    break;
                case 3:
                    DateTime dateNow = GetDateNow();
                    Console.WriteLine($"La fecha y hora actual es: {dateNow}");
                    break;
                default:
                    Console.WriteLine("La opcion no existe");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadLine();
        }

        int Sum(string num1, string num2, out bool error)
        {
            int val1, val2;
            if (!int.TryParse(num1, out val1))
            {
                Console.WriteLine("El valor 1 no es un numero");
                error = true;
                return 0;
            }
            if (!int.TryParse(num2, out val2))
            {
                Console.WriteLine("El valor 2 no es un numero");
                error = true;
                return 0;
            }
            error = false;
            return val1 + val2;
        }

        void CutString(ref string val, int quantityCharacters)
        {
            //Usando un metodo ya existente para cortar la cadena
            //val = val.Substring(0, 4);

            //Usando mi propio algoritmo para cortar la cadena
            string substring = "";
            for (int i = 0; i < val.Length; i++)
            {
                if (i < quantityCharacters)
                {
                    substring += val[i];
                }
            }
            val = substring;
        }

        DateTime GetDateNow()
        {
            return DateTime.Now;
        }
    }
}
