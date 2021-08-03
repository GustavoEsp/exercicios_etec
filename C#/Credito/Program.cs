using System;

namespace credito
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Crédito");
			Console.WriteLine("-------");
			
			float saldoMedio, credito = 0;
			
			Console.Write("Saldo médio do ano passado: R$");
			saldoMedio = float.Parse(Console.ReadLine());
			
			if(saldoMedio <= 200){
				credito = 0;
			}
			else if(saldoMedio >= 201 & saldoMedio <= 400){
				credito = saldoMedio * 20 / 100;
			}
			else if(saldoMedio >= 401 & saldoMedio <= 600){
				credito = saldoMedio * 30 / 100;
			}
			else{
				credito = saldoMedio * 40 / 100;
			}
				
			Console.WriteLine("- Crédito disponível: R$" + credito);
		
			Console.Write("Pressione qualquer tecla para sair . . . ");
			Console.ReadKey(true);
		}
	}
}