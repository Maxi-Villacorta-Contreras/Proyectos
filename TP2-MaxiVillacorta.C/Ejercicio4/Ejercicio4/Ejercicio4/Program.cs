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
            //Hacer un programa que ingrese por teclado un numero total de segundos y que luego pueda mostrar la cantidad de horas, minutos y segundos que existen en el valor ingresado.//
            int num;
            int min;
            int hora;
            Console.WriteLine("Ingrese los segundos por teclado: ");
            num = int.Parse(Console.ReadLine());
            min = num / 60;
            hora = num / 3600;
            Console.WriteLine("La cantidad de minutos es: " + min);
            Console.WriteLine("La cantidad de horas es: " + hora);
            Console.WriteLine("La cantidad de segundos es: " + num);
            Console.ReadKey();
        }
    }
}
