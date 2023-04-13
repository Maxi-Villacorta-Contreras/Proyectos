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
            //A partir de una conocida cantidad de dias que el usuario ingresa a traves, escriba un programa para convertir los dias en horas, en minutos y en segundos.//
            int dia = 24;
            int horas = 60;
            int minutos = 1440;
            int segundos = 86400;
            int resulthoras;
            int resultmin;
            int resultseg;
            Console.WriteLine("Ingrese los dias: ");
            dia = int.Parse(Console.ReadLine());
            resulthoras = dia * horas;
            resultmin = dia * minutos;
            resultseg = dia * segundos;
            Console.WriteLine("El resultado de dias a horas es: " + resulthoras);
            Console.WriteLine("El resultado de dias a minutos es: " + resultmin);
            Console.WriteLine("El resultado de dias a segundos es: " + resultseg);
            Console.ReadKey();

        }
    }
}
