/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 08/09/2022
 * Time: 16:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula15
{
	class Program
	{
		public static void Main(string[] args)
		{
			int tempo = 0;
			char escolha;
			
			inicio:
			Console.Clear();
			
			Console.WriteLine("Goianesia/go a Sao paulo/sp");
			Console.WriteLine("Escolha o transporte: [a]aviao | [b]Carro | [c]Onibus ");
			
			escolha =char.Parse(Console.ReadLine());
			
			switch(escolha){
				case 'a':
				case 'A':
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
		
				
				Console.WriteLine("Calcular outro transporte? [s/n]");
				escolha=Char.Parse(Console.ReadLine());
				if(escolha == 's' || escolha =='S'){
					goto inicio;
				}
				else{
					Console.Clear();
					Console.WriteLine("fim do programa");
				}
			}
		}
	}
}