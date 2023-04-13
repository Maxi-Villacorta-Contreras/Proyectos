using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que lea un numero y que muestre su raiz cuadrada y su raiz cubica. C# tiene funcion que permita calcular la raiz cuadrada cubica.¿Como se puede calcular?.//
            float cubica = 0;
            float cuadrada = 0;
            int numero = 0;
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            cuadrada = (float)Math.Pow(numero, 0.3);
            cubica = (float)Math.Pow(numero, 0.3);
            Console.WriteLine("La raiz cubica del numero es: " + cubica);
            Console.WriteLine("La raiz cuadrada del numero es: " + cuadrada);
            Console.ReadKey();
        }
    }
}
