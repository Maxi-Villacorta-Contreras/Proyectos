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
            //Realizar un programa que pida introducir solo frases o palabras de 6 caracteres. Si el usuario ingresa una frase o palabra de 6 caracteres se debera de imprimir un mensaje por pantalla que diga "CORRECTO", en caso contrario, se debera imprimir "INCORRECTO".//
            int nota1;
            int nota2;
            int nota3;
            bool variable1 = false;
            bool variable2 = false;
            bool variable3 = false;
            Console.WriteLine("Ingrese la primera nota: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingese la tercera nota: ");
            nota3 = int.Parse(Console.ReadLine());
            if (nota1 > 1 && nota1 < 10)
            {
                variable1 = true;
            }
            if (nota2 > 1 && nota2 < 10)
            {
                variable2 = true;
            }
            if (nota3 > 1 && nota3 < 10)
            {
                variable3 = true;
            }
            if ((variable1 && variable2 && variable3) == true)
            {
                Console.WriteLine("Las tres notas son CORRECTAS");
            }
            else
            {
                Console.WriteLine("Una o las tres notas son INCORRECTAS");
            }
            Console.ReadKey();
        }
    }
}
