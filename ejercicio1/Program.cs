﻿using System;
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
			var numero = 0; 
			Console.WriteLine("Ingrese un numero: ");
			numero = Int16.Parse(Console.ReadLine());
			/*if (numero == 1)
			{
				Console.WriteLine("UNO");
			}
			else if (numero == 2)
			{
				Console.WriteLine("DOS");
			}
			else if (numero == 3)
			{
				Console.WriteLine("TRES");
			}
			else if (numero == 4)
			{
				Console.WriteLine("CUATRO");
			}
			else if (numero == 5)
			{
				Console.WriteLine("CINCO");
			}
			else if (numero == 6)
			{
				Console.WriteLine("SEIS");
			}
			else if (numero == 7)
			{
				Console.WriteLine("SIETE");
			}
			else if (numero == 8)
			{
				Console.WriteLine("OCHO");
			}
			else if (numero == 9)
			{
				Console.WriteLine("NUEVE");
			}
			else
			{
				Console.WriteLine("OTRO...");
			} */
			switch (numero) 
			{
				case 1: Console.WriteLine("UNO");
				break;
				case 2: Console.WriteLine("DOS");
				break;
				case 3:
				Console.WriteLine("TRES");
				break;
				case 4:
				Console.WriteLine("CUATRO");
				break;
				case 5:
				Console.WriteLine("CINCO");
				break;
				case 6: 
				Console.WriteLine("SEIS");
				break;
				case 7:
				Console.WriteLine("SIETE");
				break;
				case 8:
				Console.WriteLine("OCHO");
				break;
				case 9:
				Console.WriteLine("NUEVE");
				break;
				default: Console.WriteLine("OTRO");
				break;
			}

		}
	}
}
