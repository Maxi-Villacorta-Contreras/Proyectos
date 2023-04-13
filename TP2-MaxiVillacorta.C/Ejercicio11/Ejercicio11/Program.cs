using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pide al usuario dos numeros y muestra la "distancia" entre ellos (el valor absoluto de su diferencia, de modo que el resultado sea siempre positivo.//
            int num1, num2, distancia;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1>num2)
            {
                distancia = num1 - num2;
                Console.WriteLine("La distancia entre los dos numeros es: " + distancia);
            }
            else
            {
                distancia = num1 - num2;
                Console.WriteLine("La distancia entre los dos numeros es: "+ distancia);
            }
            Console.ReadKey();
        }
    }
}
