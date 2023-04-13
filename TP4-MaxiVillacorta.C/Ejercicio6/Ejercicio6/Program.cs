using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa que pida una frase o palabra y valide si la primera letra de esa frase es una 'A'. Si la primera letra es una 'A', se debera de imprimir un mensaje por pantalla que diga "CORRECTO", en caso contrario, se debera imprimir "INCORRECTO".
            string frase;
            string aux;
            Console.WriteLine("Ingrese una frase: ");
            frase = Console.ReadLine();
            aux = frase.Substring(0, 1);
            if (aux == "A" || aux == "a")
            {
                Console.WriteLine("La primera letra es una A, es CORRECTO");
            }
            else
            {
                Console.WriteLine("La primera letra no es una A, es INCORRECTO");
            }
            Console.ReadKey();
        }
    }
}
