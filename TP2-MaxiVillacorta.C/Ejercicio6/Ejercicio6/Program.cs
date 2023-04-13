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
            //Mostrar el area y perimetro de un hexagono.//
            float lado;
            float apotema;
            float perimetro;
            float area;
            Console.WriteLine("Ingrese uno de los lados: ");
            lado = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el apotema: ");
            apotema = float.Parse(Console.ReadLine());
            perimetro = lado * 6;
            area = (perimetro * apotema) / 2;
            Console.WriteLine("El perimetro del hoxageno es: "+ perimetro);
            Console.WriteLine("El area del hoxageno es: " + area);
            Console.ReadKey();
        }
    }
}
