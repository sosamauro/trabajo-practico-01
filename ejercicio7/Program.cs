using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length of the arguments: " + args.Length);
            Console.WriteLine("Arguments:");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
