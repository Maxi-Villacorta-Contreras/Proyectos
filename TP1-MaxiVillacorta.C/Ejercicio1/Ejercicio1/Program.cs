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
            //Solicitar al usuario que ingrese la base y altura de un rectangulo, calcular y mostrar por pantalla el area y perimetro del mismo.//
            float area;
            float basee;
            float perimetro;
            float altura;
            Console.WriteLine("Mostrar la base del rectangulo: ");
            basee = float.Parse(Console.ReadLine());
            Console.WriteLine("Mostrar la altura del rectangulo: ");
            altura = float.Parse(Console.ReadLine());
            area = basee * altura;
            perimetro = 2 * altura + 2 * basee;
            Console.WriteLine("Muestre el resultado del area: "+area);
            Console.WriteLine("Muestre el resultado del perimetro: " + perimetro);
            Console.ReadKey();
        }
    }
}
