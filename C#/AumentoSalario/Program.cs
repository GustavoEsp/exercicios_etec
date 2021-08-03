using System;

namespace aumentoSalario
{
	class Program
	{
		public static void Main(string[] args)
		{
			int salario, novosalario, diferenca;
			string cargo, porcentagem;
			
			Console.WriteLine("Aumento de salário");
			
			Console.Write("Salario atual: R$");
			salario = int.Parse(Console.ReadLine());
			
			Console.Write("Cargo: [Gerente, Engenheiro, Técnico, Outro] ");
		 	cargo = Console.ReadLine();
			
			if(cargo == "Gerente" || cargo == "gerente"){
				porcentagem = "(10%)";
				novosalario = salario + (salario * 10 / 100);		
			}
			else if(cargo == "Engenheiro" || cargo == "engenheiro"){
				porcentagem = "(20%)";
				novosalario = salario + (salario * 20 / 100);
			}
			else if(cargo == "Técnico" || cargo == "técnico"){
				porcentagem = "(30%)";
				novosalario = salario + (salario * 30 / 100);
			}
			else{
				porcentagem = "(40%)";
				novosalario = salario + (salario * 40 / 100);
				
			}
			diferenca = novosalario - salario;
			Console.WriteLine("Salário antigo: R$" + salario);
			Console.WriteLine("Salário novo: R$" + novosalario);
			Console.WriteLine("Diferença: R$" + diferenca + porcentagem);
			
			Console.Write("Pressione qualquer tecla para finalizar . . . ");
			Console.ReadKey(true);
		}
	}
}