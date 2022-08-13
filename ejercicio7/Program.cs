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
            // Para ejecutar la aplicación hay que escribir en la terminal:
            // .\ejercicio7.exe cadena1 cadena2

            if (args.Length == 2)
            {
                // Se crea una lista que contendrá las palabras ingresadas
                List<string> cadenas = new List<string>();

                // Se añade cada argumento a la lista de palabras
                foreach (Object obj in args)
                {
                    // Se añaden las cadenas a la lista
                    cadenas.Add(obj.ToString());
                }

                // Se ordenan los elementos de las 2 cadenas por orden alfabético.
                string cadena1 = String.Concat(cadenas[0].OrderBy(c => c));
                string cadena2 = String.Concat(cadenas[1].OrderBy(c => c));

                // Se comparan las 2 cadenas ordenadas
                if (cadena1 == cadena2)
                {
                    Console.WriteLine("Las cadenas son anagramas.");
                }
                else
                {
                    Console.WriteLine("Las cadenas no son anagramas.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese 2 cadenas de caracteres");
            }
        }
    }
}
