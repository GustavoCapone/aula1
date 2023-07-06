/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 05/09/2022
 * Time: 11:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n1, n2,n3,n4;
			n1= 10;
			n2 = 20;
			n3 = 30;
			double compra = 7.50;
			double venda;
			double lucro= 0.37;
			string produto="hd";
			
			venda=compra+(compra*lucro);
			
			
			Console.WriteLine("Produto........:{0,10}",produto);
			Console.WriteLine("Produto........:{0,11:c}",compra);
			Console.WriteLine("Produto........:{0,12:p}",lucro);
			Console.WriteLine("Produto........:{0,13:c}",venda);
			Console.WriteLine("A reposta é: "+ n1 +", "+ n2 +", "+ n3);
			Console.WriteLine("\nn1={0},\n n2={1},\t n3={2} ",n1,n2,n3);
			
	
			
			
		}
	}
}