/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 12/09/2022
 * Time: 10:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula23
{
	class Program
	{
		public static void Main(string[] args)
		{
			int v1,v2,r;
			v1=Convert.ToInt32(Console.ReadLine());
			v2=Convert.ToInt32(Console.ReadLine());
			r=soma(v1,v2);
			Console.WriteLine("A soma dos valores {0} mais {1} é igual a: {2}",v1,v2,r);
		
		}
		static int soma(int n1,int n2){
			int res = n1+n2;
			
			
			Console.WriteLine("Ola");
			
			return res;
			
		}
		
	}
}