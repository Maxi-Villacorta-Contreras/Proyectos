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
            //Escribir un programa que pregunte al usuario su nombre , y luego lo salude.//
            string nombre;
            Console.WriteLine("¿Como te llamas?");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola, ¿Como estas?" + nombre);
            Console.ReadKey();
        }
    }
}
