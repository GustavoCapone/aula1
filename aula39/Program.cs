/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 21/09/2022
 * Time: 11:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula39
{
	class Carro{
			//("""get""") seria uma propriedade de leitura, estou obtendo um valor da propriedade;
			//("""set""") seria uma propriedade de escrita;
			//("""get e set""") tanto de escrita como de leitura;
			
			//modos de falar ("reed onli", "raid onli", "reed e raid");
			
			private int[] velMax=new int[5]{20,60,80,100,120};

		public int this[int i]{
			get{
				return velMax[i];
			}
			set{
				//""""value"""" e o valor que a variavel recebe!;
				if(value < 0){
					velMax[i]=0;
				}
				else if(value>300){
					velMax[i]=300;
				}
				
				else{
					velMax[i]=value;
				}
			}	
		}	
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Carro c1 =new Carro();
			
			
			c1[4]=200;
			Console.WriteLine("Velocidade {0}",c1[4]);
		
			
		}
	}
}