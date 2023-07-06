/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 04/10/2022
 * Time: 12:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula50
{
	
	class Program
	{
		public static void Main(string[] args)
		{
			
			int n1,n2,res;
			res = n1=n2=0;
			
			n1=20;
			n2 =0;
			
			try{
			res= n1 / n2; //Tratamento de erro com (catch) nao e possivel dividir por zero!
			}catch(Exception e){
				Console.WriteLine("erro!!   " + e.Message);
				Console.WriteLine("erro!!   " + e.GetType());
			}
			
			Console.WriteLine("A divisão de {0} / com {1} é igual = {2}!", n1,n2,res);
		}
	}
}