/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 21/09/2022
 * Time: 08:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula38
{
	class Carro{
		

			//("""get""") seria uma propriedade de leitura, estou obtendo um valor da propriedade;
			//("""set""") seria uma propriedade de escrita;
			//("""get e set""") tanto de escrita como de leitura;
			
			//modos de falar ("reed onli", "raid onli", "reed e raid");
		
		
		
		private int velMax;
		
		public int vm{
			get{
				return velMax;
			}
			set{
				//""""value"""" e o valor que a variavel recebe!;
				if(value < 0){
					vm=0;
				}
				else if(value>300){
					vm=300;
				}
				
				else{
					vm =value;
				}
			}
			
		}
		
		public Carro(){
			//this.velMax=120;
			//ou
			vm = 120;
		}
		
		/*public static void vm(int velMax){
			this.velMax=velMax;
		}*/
	}
	
	
	
	
	
	class Program
	{
		public static void Main(string[] args)
		{
			Carro c1 =new Carro();
			
			
			
			Console.WriteLine("Velocidade {0}",c1.vm);
		
			
		}
	}
}