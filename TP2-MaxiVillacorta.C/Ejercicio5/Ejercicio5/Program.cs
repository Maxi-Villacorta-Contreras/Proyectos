using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar el area y perimetro de un rombo.//
            float area;
            float perimetro;
            float diag1;
            float diag2;
            float lados;
            Console.WriteLine("Ingrese el lado del rombo: ");
            lados = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la diagonal numero 1: ");
            diag1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la diagonal numero 2: ");
            diag2 = float.Parse(Console.ReadLine());
            area = (diag1 * diag2) / 2;
            perimetro = lados * 4;
            Console.WriteLine("El area del rombo es: " + area);
            Console.WriteLine("El perimetro del rombo es: " + perimetro);
            Console.ReadKey();
        }
    }
}
