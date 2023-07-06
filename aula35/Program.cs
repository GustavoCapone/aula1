/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 15/09/2022
 * Time: 16:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula35
{
	class base1{
		public base1(){
			Console.WriteLine("construtor da classe base");
		}
		virtual public void info(){//-------------------------------------
			Console.WriteLine("base");
			
			
		}
	}
	class derivada1:base1{
		public derivada1(){
			Console.WriteLine("construtor da classe derivada1");
		}
		override public void info(){//-----------------------------------
			Console.WriteLine("derivada1");
		}
		
	}
	
	class derivada2:derivada1{
		public derivada2(){
			Console.WriteLine("construtor da classe  derivada2");
		}
		override public void info(){//-----------------------------------
			Console.WriteLine("derivada2");
		}
	}
	
	
	
	
	class Program
	{
		public static void Main(string[] args)
		{
			base1 Ref;
			
			derivada1 derivada10 = new derivada1();
			derivada2 derivada20 = new derivada2();
			derivada10.info();
			derivada20.info();
			Ref = derivada10;
			Ref.info();
		}
	}
}