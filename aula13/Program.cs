/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 08/09/2022
 * Time: 09:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula13
{
	class Program
	{
		public static void Main(string[] args)
		{
			Double n1,n2,n3,n4,rec;
			Console.WriteLine("Digite o valor da primeira nota: ");
			n1 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite o valor da segunda nota: ");
			n2 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite o valor da terceira nota: ");
			n3 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite o valor da quarta nota: ");
			n4 = double.Parse(Console.ReadLine());
			
			Double res = (n1+n2+n3+n4)/4;
			
			if(res >= 60){
				Console.WriteLine("aprovado "+res);
			}
			else if(res >=40){
				Console.WriteLine("Recuperação "+res);
				Console.WriteLine("Digite o valor da nota de recuperção: ");
				rec = double.Parse(Console.ReadLine());
				Double resultadofinal = (rec/2)+res;



				 if(resultadofinal >=60){
					Console.WriteLine("Aprovado de vez!!!! \n Nota sem recuperação: "+ res+
					                  "\n Nota da recuperação: "+rec+"\n Nota geral: "+resultadofinal);		
				}
				else{
					Console.WriteLine("Reprovado de vez!!!! \n Nota sem recuperação: "+ res +
					                  "\n Nota da recuperação: "+rec+"\n Nota geral: "+resultadofinal);	
				}
			}
			
			else{
				Console.WriteLine("Reprovado "+res);
			}
		}
	}
}