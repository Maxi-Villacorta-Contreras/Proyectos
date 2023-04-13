using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que pida introducir solo frases o palabras de 6 caracteres. Si el usuario ingresa una frase o palabra de 6 caracteres se debera de imprimir un mensaje por pantalla que diga "CORRECTO", en caso contrario, se debera imprimir "INCORRECTO".//
            string frases;
            int cantidadcaracteres = 0;
            Console.WriteLine("Ingrese una frase de 6 caracteres: ");
            frases = Console.ReadLine();
            cantidadcaracteres = frases.Length;
            if (cantidadcaracteres < 7)
            {
                Console.WriteLine("La frase es CORRECTA: ");
            }
            else
            {
                Console.WriteLine("La frase es INCORRECTA: ");
            }
            Console.ReadKey();
        }
    }
}
