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
            Console.WriteLine("inserta en número el nivel de la pirámide, mayor a cero");

            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(" \t ");
                //primera parte
                for (int j = 1; j <= (N - i) + 1; j++)
                {
                    Console.Write("* ");
                }
                //segunda parte
                int numeroFila = i;
                Boolean bandera = true;
                for (int j = 1; j <= (i * 2) - 1; j++)
                {
                    Console.Write(numeroFila + " ");
                    if (bandera)
                    {
                        numeroFila--;
                        if (numeroFila == 1)
                        {
                            bandera = false;
                        }
                        continue;
                    }
                    numeroFila++;
                    //else
                    //{
                    //    numeroFila ++;
                    //}
                }
                for (int j = 1; j <= (N - i) + 1; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine(" ");

            }
        }
    }
}
