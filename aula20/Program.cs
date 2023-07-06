/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 09/09/2022
 * Time: 11:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula20
{
	
	
	
	class Program
	{
		
		
		public static void Main(string[] args)
		{
			
			string senha ="123";
			string senhauser;
			int tentativas=0;
			char escolhasair ='s';
			
			
			do{
				do{
					
					Console.WriteLine("digite a senha: ");
					senhauser=Console.ReadLine();
					tentativas++;
					if(senha == senhauser){
					Console.WriteLine("O programa foi encerrado!! Deseja fazer outro processo?");
					Console.WriteLine("|S ou s|Sim      |N ou n|Não");
					escolhasair = char.Parse(Console.ReadLine());
					}
					
					
				} while(senha != senhauser && tentativas <= 3);

				if (tentativas > 3){
					Console.WriteLine("O programa foi encerrado!! Deseja fazer outro processo?");
					Console.WriteLine("|S ou s|Sim      |N ou n|Não");
					escolhasair = char.Parse(Console.ReadLine());
					
				}
				else{
					Console.WriteLine("senha correta!. tentativas: {0}",tentativas);
				}
					
				}while(escolhasair == 's');
				
				
				
			}
			
			
		}/*escolhasair = char.Parse(Console.ReadLine());
					if(escolhasair == 'S' || escolhasair == 's'){
						goto inicio;
					}
					else{ //if(escolhasair == 'N' || escolhasair == 'n'){
						Console.WriteLine("Você escolheu nao");
					}*/
	}