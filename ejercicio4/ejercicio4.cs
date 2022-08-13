using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class ejercicio4
    {
        static void Main(string[] args)
        {
            int inicio = 1852;
            int fin = 2023;
            Console.WriteLine("AÑOS BISIESTOS: ");
            for (int i = inicio; i <= fin; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
