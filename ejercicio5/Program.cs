using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            var fibo = 1;
            var aux = 1;
            var aux2 = 1;
            Console.WriteLine("Ingrese un valor, por favor: ");
            n = Int16.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i < 3)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    fibo = aux + aux2;
                    aux = aux2;
                    aux2 = fibo;
                    Console.WriteLine(fibo);
                }
            }

        }
    }
}
