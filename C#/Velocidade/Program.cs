using System;

namespace velocidade
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("***********************");
			Console.WriteLine("Cálculo de velocidade *");
			Console.WriteLine("***********************");
			
			float velocidade, distancia, tempo;
			
			Console.Write("Informe a distância percorrida em metros:");
			distancia = float.Parse(Console.ReadLine());
			
			Console.Write("Informe o tempo levado em minutos:");
			tempo = float.Parse(Console.ReadLine());
			
			velocidade = distancia / tempo;
			
			Console.WriteLine("Um objeto que percorreu uma distância de " + distancia + " metros em " 
			                  + tempo + " minutos fez o trajeto em uma velocidade de " 
			                  + velocidade + " metros por minuto");
			
			Console.Write("Pressione qualquer tecla para sair . . . ");
			Console.ReadKey(true);
		}
	}
}