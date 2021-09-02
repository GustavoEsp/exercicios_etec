using System;

namespace parOuImpar
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] listaPar = new int[10];
			int[] listaImpar = new int[10];
			int somaPares = 0;
			int somaImpares = 0;
			int indiceVetor = 0;
	
			Console.WriteLine("Par ou Ímpar");
			Console.WriteLine("------------");
			
			for(int contador = 0; contador < 10; contador++)
			{
				Console.Write("Informe o " + (contador+1) + "° número: ");
				int num = int.Parse(Console.ReadLine());
			
				if(num % 2 == 0)
				{
					listaPar[contador] = num;
					listaImpar[contador] = 0;
					somaPares += num;
				}
				else
				{
					listaPar[contador] = 0;
					listaImpar[contador] = num;
					somaImpares += num;
				}
			}
			
			Console.WriteLine("---------------------");
			Console.WriteLine("Par	-	Ímpar");
			
			while(indiceVetor < 10)
			{
				Console.WriteLine(listaPar[indiceVetor] + "	-	" + listaImpar[indiceVetor]);
				indiceVetor++;
			}
			
			Console.WriteLine("---------------------");
			
			Console.WriteLine("- Soma dos números Pares: " + somaPares);
			Console.WriteLine("- Soma dos números Ímpares: " + somaImpares);
			
			Console.Write("\nPressione qualquer tecla para sair . . . ");
			Console.ReadKey(true);
		}
	}
}