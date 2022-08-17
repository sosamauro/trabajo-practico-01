using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tamaño = 8;
            var cadena = "";

            for (var i = 1; i <= tamaño; i++)
            {
                var c = 1;
                cadena = "";
                for (int j = 1; j <= i; j++)
                {
                    cadena = cadena + " " + c;
                    c = c * (i - j) / j;
                }
                Console.WriteLine(cadena);
            }



        }
    }
}
