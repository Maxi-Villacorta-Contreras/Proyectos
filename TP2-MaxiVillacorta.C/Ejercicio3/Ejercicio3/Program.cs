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
            //Hacer un programa que calcule el salario de un empleado, si se descuenta el 20% de su salario bruto.//
            int salario;
            int porciento;
            Console.WriteLine("Ingrese el salario: ");
            salario = int.Parse(Console.ReadLine());
            porciento = (int)(salario * 0.20);
            Console.WriteLine("El salario es:" + porciento);
            Console.ReadKey();
        }
    }
}
