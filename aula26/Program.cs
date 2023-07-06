/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 12/09/2022
 * Time: 13:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula26
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite dois valores");
			int n4,n5;
			n4=Convert.ToInt32(Console.ReadLine());
			n5=Convert.ToInt32(Console.ReadLine());
			soma(n4,n5);
			
			
		}
		
		public static void soma(params int[]n)
		{
			int res=0;
			
			if(n.Length < 1){
				Console.WriteLine("Não a valores a serem somados");
			}
			else if (n.Length < 2){
				Console.WriteLine("Valores insuficientes para a soma: {0}",n[0]);
			}
			else{
				for(int i =0; i < n.Length;i++){
					res+=n[i];
				}
				Console.WriteLine("A soma dos valores é:"+res);
			}
			
		}
	}
}