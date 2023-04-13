using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realiza un programa que solo permita introducir los caracteres 'S' y 'N'. Si el usuario ingresa alguno de esos dos caracteres se debera de imprimir un mensaje por pantalla que diga "CORRECTO", en caso contrario, se debera imprimir "INCORRECTO"

            char caracter;
            Console.WriteLine("Ingrese un caracter");
            caracter = char.Parse(Console.ReadLine());
            if (caracter == 'S' | caracter == 'N' | caracter == 's' | caracter == 'n')
            {
                Console.WriteLine("El caracter es CORRECTO ");
            }
            else
            {
                Console.WriteLine("El caracter es INCORRECTO ");
            }
            Console.ReadKey();
        }
    }
}
