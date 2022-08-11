using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
	class Program
	{
		static void Main(string[] args)
		{
			var limiteInferior = 0;
			var limiteSuperior = 0;
			var suma = 0;
			var promedio = 0.0;

			Console.WriteLine("Ingrese limite inferior: ");
			limiteInferior = Int16.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese limite superior: ");
			limiteSuperior = Int16.Parse(Console.ReadLine());

			suma = limiteInferior;

			/*for (int i = limiteInferior + 1; i <= limiteSuperior; i++) 
			{
				suma = suma + i;
			}*/
			int i = limiteInferior;
			while (i < limiteSuperior)
			{
				i++;
				suma = suma + i;
			}

			promedio = (limiteInferior + limiteSuperior) / 2;
			Console.WriteLine("suma: " + suma);
			Console.WriteLine("promedio: " + promedio);
			Console.WriteLine("maximo: " + limiteSuperior);
			Console.WriteLine("minimo: " + limiteInferior);


		}
	}
}
