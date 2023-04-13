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
            //Escriba un programa que pida 3 notas y valide si esas notas estan entre 1 y 10.Si estan entre esos parametros se debe poner en verdadero una variable de tipo logico y si no ponerla en falso. Al final el programa debe decir si las 3 notas son correctas usando la variable de tipo logico.//
            int nota1;
            int nota2;
            int nota3;
            Console.WriteLine("Ingrese la primera nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota: ");
            nota3 = Convert.ToInt32(Console.ReadLine());
            if (nota1 <= 10 && nota2 <= 10 && nota3 <= 10)
            {
                Console.WriteLine("las variables son correctas: ");
            }
            else
            {
                Console.WriteLine("Las variables son falsas: ");
            }
            Console.ReadKey();
        }
    }
}
