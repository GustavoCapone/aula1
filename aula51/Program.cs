/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 04/10/2022
 * Time: 13:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula51
{
	class Program
	{
		public static void Main(string[] args)
		{
		int n1,n2,res;
			res = n1=n2=0;
			
			n1=20;
			n2 =4;
			
			try{
			res= n1 / n2; //Tratamento de erro com (catch) nao e possivel dividir por zero!
			Console.WriteLine("A divisão de {0} / com {1} é igual = {2}!", n1,n2,res);
			throw new Exception("Gustavo");
			}catch(Exception e){
				Console.WriteLine("erro!!   " + e.Message);
				Console.WriteLine("erro!!   " + e.GetType());
			}finally{
				Console.WriteLine("FIM!!!!");
			}
			
			
		}
	}
}