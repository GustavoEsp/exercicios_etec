using System;

namespace sistemaRadar
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("-----");
			Console.WriteLine("Sistema de Radar");
			Console.WriteLine("-----");
			
			float ponto1, ponto2, tempo, velocidadeMedia;
			
			Console.Write("Radar 1 está localizado no km:");
			ponto1 = float.Parse(Console.ReadLine());
			
			Console.Write("Radar 2 está localizado no km:");
			ponto2 = float.Parse(Console.ReadLine());
			
			Console.Write("Horas gastas no percurso:");
			tempo = float.Parse(Console.ReadLine());
			
			velocidadeMedia = (ponto2 - ponto1)/ tempo;
			
			if(velocidadeMedia > 80){
				Console.WriteLine("A velocidade média do veículo é de " + velocidadeMedia +
				                  "km/h. Ultrapassando o limite de 80km/h. O veículo será multado!");
			}
			else{
				Console.WriteLine("A velocidade média do veículo é de " + velocidadeMedia  + 
				                  "km/h. Estando dentro do limite de 80km/h. O veículo não será multado!");
			}
			
			Console.Write("Pressione qualquer tecla para sair . . . ");
			Console.ReadKey(true);
		}
	}
}