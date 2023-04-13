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
            //Mostrar el area y perimetro de un paralelogramo.//
            float area;
            float altura;
            float basee;
            float perimetro;
            Console.WriteLine("Ingrese la base del paralelogramo: ");
            basee = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del paralelogramo: ");
            altura = float.Parse(Console.ReadLine());
            perimetro = (basee * 2) + (altura * 2);
            area = basee * altura;
            Console.WriteLine("El perimetro es: " + perimetro);
            Console.WriteLine("El area es: " + area);
            Console.ReadKey();
        }
    }
}
