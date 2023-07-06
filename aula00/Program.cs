/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 13/09/2022
 * Time: 10:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula00
{
	class Program
	{
		public static void Main(string[] args)
		{
			string Alcantara, Bernadete, Crosineide, Dorivaldo;
			double num1,num2;
			double tmp1 =0;
			double tmp2 =0;
			string escolha;
			double soma;
			double subtracao;
			double multiplicacao;
			double divisao;
			char escolha2 = 's';
			string escolha3;
			
			
			INICIO:
			Console.WriteLine("CALCULADORA");
			Console.WriteLine("");
			Console.WriteLine("Escolha o tipo de calculo que deseja fazer.");
			Console.WriteLine("soma , divisao, subtração, multiplicação: Digite o sinal da conta.");
			escolha = Console.ReadLine();
			
			if(escolha != null){	
			Console.Clear();
			Console.WriteLine("Agoa digite os numeros desejados.");
			Console.WriteLine("Digite o primeiro numero: ");
			tmp1 = Convert.ToDouble(Console.ReadLine());
			
			
			//Console.Clear();
			Console.WriteLine("Digite o segundo numero: ");
			tmp2 = Convert.ToDouble(Console.ReadLine());
			
			soma = tmp1 + tmp2;
			subtracao = tmp1 - tmp2;
			multiplicacao = tmp1 * tmp2;
			divisao = tmp1 / tmp2;
			
			
				if(escolha == "+"){
					Console.WriteLine("A soma de {0} com {1} e igual à: {2}",tmp1,tmp2,soma);
				}
				else if(escolha.Equals("-")){
					Console.WriteLine("A Subtração de {0} com {1} e igual à: {2}",tmp1,tmp2,subtracao);
				}
				else if(escolha.Equals("*")){
					Console.WriteLine("A multiplicação de {0} com {1} e igual à: {2}",tmp1,tmp2,multiplicacao);
				}
				else if(escolha.Equals("/")){
					Console.WriteLine("A Divisão de {0} com {1} e igual à: {2}",tmp1,tmp2,divisao);
				}
				
			
			}else{
				Console.WriteLine("Aconteceu um erro!!!!");
				
			}
			
			Console.WriteLine("Deseja refazer o seu calculo? ");
			Console.WriteLine("|s ou S| Sim  ou Não |n ou N|");
			escolha3 = Console.ReadLine();
			switch(escolha2){
				case's':
				case 'S':
					break;
				case 'n':
				case 'N':
					break;
					
			}
			if(escolha3.Equals ("s") || escolha3 == ("S")){
				goto INICIO;
			}
			else{
				Console.WriteLine("Você escolheu fechar o programa!!!");
				
			}
			
			Console.WriteLine("Precione qualquer tecla para sair.");
			Console.ReadKey();
			
			
			Console.WriteLine("----------------------------------------------\n--------------------------------" +
			                  "\n-----------------------------------\n----------------------------------");
			String usuario;
			string senha;
			String usuario1;
			string senha1;
			
			Console.WriteLine("Crie um usuario e senha: ");
			Console.WriteLine("Nome Usuario: ");
			usuario = Console.ReadLine();
			Console.WriteLine("Senha: ");
			senha = Console.ReadLine();
			
			do
			{
					Console.WriteLine(" Agora Digite o seu usuario e a senha para passar para a proxima fase: ");
					Console.WriteLine("Digite o usuario:");
					usuario1= Console.ReadLine();
					Console.WriteLine("Digite a senha:");
					senha1 = Console.ReadLine();
					
				
					
			} while(usuario != usuario1 || senha != senha1);
				Console.WriteLine("sucesso!!!!!");
				
				
				
			
		}
	}
}