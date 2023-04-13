using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un vendedor recibe un sueldo base mas un 10% extra por comision de sus ventas, el vendedor desea saber cuanto dinero obtendra por concepto de comisiones por las tres ventas que realiza en el mes y el total que recibira en el mes tomando en cuenta su sueldo base y comisiones.//
            float sueldo;
            float sueldox1;
            float sueldox2;
            float sueldofin1;
            float sueldofin2;
            Console.WriteLine("Ingrese el sueldo: ");
            sueldo = float.Parse(Console.ReadLine());
            sueldox1 = (float)(sueldo * 0.10);
            sueldox2 = (float)(sueldo * 30);
            sueldofin1 = sueldo;
            sueldofin2 = sueldo;
            Console.WriteLine("El sueldo mas el 10% es: " + sueldofin1);
            Console.WriteLine("El sueldo final sumando las comisiones es: " + sueldofin2);
            Console.ReadKey();
        }
    }
}
