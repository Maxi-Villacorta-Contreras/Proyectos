using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que solicite al usuario que ingrese el precio de un producto al inicio del año, y el precio del mismo producto al finalizar el año. El programa debe calcular cuanto fue el porcentaje de aumento que tuvo ese producto en el año y mostrarlo por pantalla.//
            int precio;
            Console.WriteLine("Ingrese el precio de un producto al inicio del año: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("El 5% del precio es: " + (precio * 0.05) + "El 95% del precio es: " + (precio - (precio * 0.059)));
            Console.ReadKey();

        }
    }
}
