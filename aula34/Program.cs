/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 15/09/2022
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula34
{
	class base1{
		public base1(){
			Console.WriteLine("construtor da classe base");
		}
	}
	class derivada1:base1{
		public derivada1(){
			Console.WriteLine("construtor da classe derivada1");
		}
		
	}
	
	class derivada2:derivada1{
		public derivada2(){
			Console.WriteLine("construtor da classe  derivada2");
		}
		
	}
	
	
	
	
	class Program
	{
		public static void Main(string[] args)
		{
			derivada2 derivada2 = new derivada2();
		}
	}
}