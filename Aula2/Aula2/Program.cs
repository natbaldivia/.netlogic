using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
	class Program
	{
		static void Main(string[] args)
		{
			

		}


	}

		private static void licaodecasa1()
		{
			Console.WriteLine("Digite um numero");
			int numeroa = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite mais um numero");
			int numerob = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite só mais um número");
			int numeroc = int.Parse(Console.ReadLine());
			if (numeroa > numerob)
			{
				Console.WriteLine("O maior é " + numeroa);
			}
			else
			{
				if (numerob > numeroc)
				{
					Console.WriteLine("O maior é " + numerob);
				}
				else
				{
					Console.WriteLine("O maior é " + numeroc);
				}
				if (numeroa > numeroc)
				{
					Console.WriteLine("O maior é " + numeroa);
				}
				else
				{
					Console.WriteLine("O maior é " + numeroc);
				}
			}
			Console.ReadLine();
		}

		private static void exerciciodouble()
		{
			double a = 5;
			double b = 2;
			Console.WriteLine(a / b);
			Console.WriteLine(a % b);
			Console.ReadLine();
		}

		private static void exercicioifelse()
		{
			Console.WriteLine("Digite um numero");
			int numeroa = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite mais um numero");
			int numerob = int.Parse(Console.ReadLine());
			if (numeroa > numerob)
			{
				Console.WriteLine("O maior é " + numeroa);
			}
			else
			{
				if (numeroa == numerob)
				{
					Console.WriteLine("São iguais");
				}
				else
				{
					Console.WriteLine("O maior é " + numerob);
				}
			}
			Console.ReadLine();
		}

		private static void exercicioif()
		{
			bool variavelbooleana = false;
			if (5 != 5)
			{
				Console.WriteLine("A variavel é verdadeira");
			}
			else
			{
				Console.WriteLine("A variável é falsa");
			}
			Console.ReadLine();
		}

		private static void Exerciciovariavel()
		{
			Console.WriteLine("Digite um número");
			float numeroa = float.Parse(Console.ReadLine());
			Console.WriteLine("Digite mais um número");
			float numerob = float.Parse(Console.ReadLine());
			float resultado = numeroa / numerob;
			Console.WriteLine("O resultado da divisão é " + resultado);
			Console.ReadLine();
		}
	}
}
