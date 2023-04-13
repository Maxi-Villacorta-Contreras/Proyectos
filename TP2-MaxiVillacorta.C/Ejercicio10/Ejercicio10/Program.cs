using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una tienda ofrece un descuento del 15% sobre el total de la compra y un cliente desea saber cuanto debera pagar finalmente por su compra.//
            float compra;
            float total;
            float totalf;
            Console.WriteLine("El total de la compra es: ");
            compra = float.Parse(Console.ReadLine());
            total = (float)(compra * 0.15);
            totalf = (float)(compra - total);
            Console.WriteLine("El precio con el 15% de descuento es: " + totalf);
            Console.ReadKey();
        }
    }
}
