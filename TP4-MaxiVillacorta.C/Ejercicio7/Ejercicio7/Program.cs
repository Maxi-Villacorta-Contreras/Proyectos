using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Continuando el ejercicio anterior, ahora se pedira una frase o palabra y se validara si la primera letra de la frase es igual a la ultima letra de la frase. Se debera de imprimir un mensaje por pantalla que diga "CORRECTO", en caso contrario, se debera imprimir "INCORRECTO".//
            string frase;
            int longitud;
            string aux;
            string aux2;
            Console.WriteLine("Ingrese una frase: ");
            frase = Console.ReadLine();
            longitud = frase.Length - 1;
            aux = frase.Substring(0, 1);
            aux2 = frase.Substring(longitud);
            if (aux == aux2)
            {
                Console.WriteLine("CORRECTO");
            }
            else
            {
                Console.WriteLine("INCORRECTO");
            }
            Console.ReadKey();
        }
    }
}
