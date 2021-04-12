/*
 * Date: 05/04/2021
 * Time: 11:24
 * Created By: Gustavo
 */
using System;

namespace media
{
	class Program
	{
		public static void Main(string[] args)
		{
			int nota1, nota2, nota3, nota4, media;
			Console.WriteLine("Calculo de média");
			Console.WriteLine("----------------");
			
			Console.Write("Insira a primeira nota: ");
			nota1 = Console.Read();
			Console.Write("Insira a primeira nota: ");
			nota2 = Console.Read();
			Console.Write("Insira a terceira nota: ");
			nota3 = Console.Read();
			Console.Write("Insira a quarta nota: ");
			nota4 = Console.Read();
			
			media = (nota1 + nota2 + nota3 + nota4) / 4;
			Console.WriteLine(media);
			
				
			
			// TODO: Implement Functionality Here
			
			Console.Write("Pressione qualquer tecla para continuar... ");
			Console.ReadKey(true);
		}
	}
}
