using System;

namespace caixaEletronico
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Caixa eletrônico");
			Console.WriteLine("----------------");			
			
			int valor, notas200, notas100, notas50, notas20, notas10, notas5, notas2, moedas1;
			
			Console.Write("Valor para saque: R$");
			valor = int.Parse(Console.ReadLine());
			
			if(valor >= 200){
				notas200 = valor / 200;
				valor %= 200;
				
			}
			else{
				notas200 = 0;
			}
			
			if(valor >= 100){
				notas100 = valor / 100;
				valor %= 100;
				
			}
			else{
				notas100 = 0;
			}
			
			if(valor >= 50){
				notas50 = valor / 50;
				valor %= 50;
				
			}
			else{
				notas50 = 0;
			}
			
			if(valor >= 20){
				notas20 = valor / 20;
				valor %= 20;
				
			}
			else{
				notas20 = 0;
			}
			
			if(valor >= 10){
				notas10 = valor / 10;
				valor %= 10;
				
			}
			else{
				notas10 = 0;
			}
			
			if(valor >= 5){
				notas5 = valor / 5;
				valor %= 5;
				
			}
			else{
				notas5 = 0;
			}
			
			if(valor >= 2){
				notas2 = valor / 2;
				valor %= 2;
				
			}
			else{
				notas2 = 0;
			}
			
			if(valor >= 1){
				moedas1 = valor / 1;
				valor %= 1;
				
			}
			else{
				moedas1 = 0;
			}
			
			Console.WriteLine("--- Cédulas a serem sacadas ---");
			Console.WriteLine("Notas de R$200:"+ notas200);
			Console.WriteLine("Notas de R$100:" + notas100);
			Console.WriteLine("Notas de R$50:" + notas50);
			Console.WriteLine("Notas de R$20:" + notas20);
			Console.WriteLine("Notas de R$10:" + notas10);
			Console.WriteLine("Notas de R$5:" + notas5);
			Console.WriteLine("Notas de R$2:" + notas2);
			
			if (moedas1 >= 1){
				Console.WriteLine("Não foi possível sacar R$" + moedas1 + "! O caixa só trabalha com notas");
			}
			
			Console.Write("Pressione qualquer tecla para finalizar o programa . . . ");
			Console.ReadKey(true);
		}
	}
}