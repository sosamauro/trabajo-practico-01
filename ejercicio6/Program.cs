using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var radio = 0.0;
            var perimetro = 0.0;
            var area = 0.0;

            Console.WriteLine("Ingrese el radio: ");
            radio = Double.Parse(Console.ReadLine());

            perimetro = Math.PI * 2 * radio;
            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("El perimetro es: " + Math.Round(perimetro, 2));
            Console.WriteLine("El area es: " + Math.Round(area, 2));

        }
    }
}
