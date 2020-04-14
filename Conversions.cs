using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIntroduccionCSharp
{
    class Conversions
    {
        public void Main()
        {
            ParseToBoolean();
            ExamplesToParse();
        }

        void ParseToBoolean() {
            Console.WriteLine("Usando Convert.ToBoolean()");
            bool convertTrue= Convert.ToBoolean("true");
            bool convertFalse = Convert.ToBoolean("false");
            bool convertNumberOneInBoolean = Convert.ToBoolean(1);
            bool convertNumberZeroInBoolean = Convert.ToBoolean(0);
            Console.WriteLine($"El resultado de convertir 'true' a boolean usando Convert es: {convertTrue}.");
            Console.WriteLine($"El resultado de convertir 'false' a boolean usando Convert es: {convertFalse}.");
            Console.WriteLine($"El resultado de convertir '1' a boolean usando Convert es: {convertNumberOneInBoolean}");
            Console.WriteLine($"El resultado de convertir '0' a boolean usando Convert es: {convertNumberZeroInBoolean}");
            //En el caso del string true y del 1 se convierte en True del tipo boolean.
            //En el caso del string false y del 0 se convierte en False del tipo boolean.
            //En el caso del string, se se manda algo que no sea true o false rompe.
            /*En el caso de los numeros es distinto, cualquier numero que sea distinto de 0 lo tomara como True
              Y cuando se envie 0 se tomara como False
            */
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();
            Console.WriteLine("Usando bool.Parse()");
            bool parseTrue = bool.Parse("true");
            bool parseFalse = bool.Parse("false");
            //bool parseNumberOne = bool.Parse(1); //En este caso no es posible realizar el parseo. No es posible hacerlo con un int
            //bool parseNumberZero = bool.Parse(0); //En este caso no es posible realizar el parseo. No es posible hacerlo con un int
            /*
                bool parseNumberOne = bool.Parse("1");
                bool parseNumberZero = bool.Parse("0");
                Console.WriteLine($"El resultado de convertir '1' a boolean usando bool.Parse es: {parseNumberOne}");
                Console.WriteLine($"El resultado de convertir '0' a boolean usando bool.Parse es: {parseNumberZero}");
            */
            Console.WriteLine($"El resultado de convertir 'true' a boolean usando bool.Parse es: {parseTrue}.");
            Console.WriteLine($"El resultado de convertir 'false' a boolean usando bool.Parse es: {parseFalse}.");
            Console.WriteLine("No es posible convertir ni el numero ni el string 1 y 0 a boolean");
            //En el caso de los string true y false se convierten a sus valores correspondientes en el tipo boolean, es decir True y False
            /*
                En el caso de los numeros no es posible realizar la conversion. Lanza error al intentar usar un int, por lo que no se puede compilar
                Y en el caso de usar los numeros como string no es posible, ya que cuando llega al momento de parsear se rompe el programa
             */
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();

            Console.WriteLine("Usando bool.TryParse()");
            bool tryParseToBoolean;
            List<string> stringsToConvert = new List<string>();
            stringsToConvert.Add("true");
            stringsToConvert.Add("false");
            stringsToConvert.Add("1");
            stringsToConvert.Add("0");

            stringsToConvert.ForEach((stringToConvert) =>
            {
                if (bool.TryParse(stringToConvert, out tryParseToBoolean))
                {
                    Console.WriteLine($"Es posible convertir el string '{stringToConvert}' al tipo boolean");
                }
                else
                {
                    Console.WriteLine($"No es posible convertir el string {stringToConvert} al tipo boolean");
                }
            });

            //Al intentar convertir los string true y false el TryParse devuelve true y devuelve por parametro el valor correspondiente en boolean
            /*
                En el caso de los numeros 1 y 0 es distinto. Al igual que en el punto anterior no es posible usar el 1 y 0 como int
                En el caso de intentar usarlos como string no tira error al compilar, pero no puede convertirlos por lo que retorna false
            */
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        void ExamplesToParse()
        {
            int a = (int) 344.4;
            Console.WriteLine($"El resultado de a es: {a}. Al convertir un numero decimal a int, se perdera toda la parte decimal");
            decimal aDecimal = 10;
            Console.WriteLine($"El resultado de a es: {aDecimal}. Al convertir un numero entero a decimal quedara exactamente igual, en este caso el resultado sera 10");
            int b = 443444;
            short bShort = (short) b;
            Console.WriteLine($"El resultado de convertir b '{b}' a short es: {bShort}. Al superarnos el limite del short, devuelve otro numero que no se esperaba");
        }
    }
}
