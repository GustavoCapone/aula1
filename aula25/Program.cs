/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 12/09/2022
 * Time: 12:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula25
{
	class Program
	{
		public static void Main(string[] args)
		{
			int d1, div,quoc,rest;
			d1=10;
			div=5;
			quoc=divide(d1,div,out rest);
			
			Console.WriteLine("{0}/{1}: quociente={2} e o resto {3}",d1,div,quoc,rest);
		}
		public static int divide(int dividendo,int divisor,out int resto){
			int quociente;
			quociente = (dividendo / divisor);
			resto=dividendo%divisor;
			return quociente;
			
		}
	}
}