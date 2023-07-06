/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 08/09/2022
 * Time: 11:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula14
{
	class Program
	{
		public static void Main(string[] args)
		{
			int tempo = 0;
			char escolha;
			
			Console.WriteLine("Goianesia/go a Sao paulo/sp");
			Console.WriteLine("Escolha o transporte: [a]aviao | [b]Carro | [c]Onibus ");
			
			escolha =char.Parse(Console.ReadLine());
			
			switch(escolha){
				case 'a':
						tempo = 7;
						break;
				case 'b':
						tempo = 13;
						break;
				case 'c':
						tempo = 19;
						break;
				default:
						tempo = 1;
						break;				
			}
			if(tempo<0){
				Console.WriteLine("transporte indisponivel");
			}
			else{
				Console.WriteLine("transporte disponivel tempo é: {0} Horas",tempo);
			}
		}
	}
}