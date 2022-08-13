using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = 100;
            var lebniz = 0.0;
            var porcentaje = 0.0;
            for (int i = 0; i <= n; i++)
            {
                lebniz += ((Math.Pow((-1), i)) / ((2 * i) + 1));
            }
            porcentaje = (Math.Abs(lebniz - Math.PI) / Math.PI) * 100;
            Console.WriteLine("El porcentaje de error entre la formula de Lebniz y Pi es: " + Math.Truncate(porcentaje) + "%");
        }
    }
}
