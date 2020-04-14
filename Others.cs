using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIntroduccionCSharp
{
    class Others
    {
        public enum Colors
        {
            Blanco,
            Azul,
            Negro
        }
        public void Main()
        {
            /*
                Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro)
                y para cada caso indicar un mensaje de cual es el color informado.
            */
            Console.WriteLine("Ingrese un color. Blanco, Azul o Negro");
            string inputColor = Console.ReadLine();
            switch(inputColor)
            {
                case nameof(Colors.Blanco):
                    Console.WriteLine("El color seleccionado es el blanco");
                    break;
                case nameof(Colors.Azul):
                    Console.WriteLine("El color seleccionado es el azul");
                    break;
                case nameof(Colors.Negro):
                    Console.WriteLine("El color seleccionado es el negro");
                    break;
                default: break;
            }

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();

            /*
                Si se tiene una variable entera a, realice una sentencia if para evaluar si la variable a es mayor a 10.
                Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10.  
                Agregar la sentencia de else y, en ella, indicar un mensaje de error.
            */
            int a = 5;
            if (a > 10)
            {
                Console.WriteLine("La variable a es mayor a 10");
            } else
            {
                Console.WriteLine("La variable a no es mayor a 10");
            }

            /*
                ¿Cuál es la diferencia entre la sentencia for y foreach? Cuándo se debe utilizar cada una de ellas?
            */
            /*
                For: Itera sobre algo que no necesariamente existe antes del for. La condicion de salida la elegimos nosotros.
                ForEach: Itera sobre algo que si o si tiene que existir antes del ForEach. Se recorre desde el primero al ultimo.
                         No tenemos eleccion sobre el orden de acceso.
                El ForEach se usaria mas que nada cuando se quiera recorrer si o si todos los elementos del array
            */

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();

            /*
                Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5.
                Cuando la variable a exceda el valor de 50, el ciclo while debe finalizar
            */

            int varA = 0;
            while(varA <= 50)
            {
                varA += 5;
            }
            Console.WriteLine($"La variable a vale mas de 50, su valor es: {varA}");
        }
    }
}
