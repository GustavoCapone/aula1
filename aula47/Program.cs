/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 03/10/2022
 * Time: 09:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula47
{
	class Mat{
		public static double pi=3.14;
		
		public static double dobro(double n){
			return n*3;
		}
	}
	
	
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			double vpi = Mat.pi;
			double num=10;
			
			Console.WriteLine("{0}",Mat.dobro(num));
			Console.WriteLine(vpi);
		}
	}
}