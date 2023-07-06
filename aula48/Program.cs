/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 03/10/2022
 * Time: 10:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula48
{
	delegate double Operador(double n1, double n2);
	
	public class Mat{
		public static double somar(double n1,double n2){
			return n1+n2;
		}
		
		
		public static double dobrar(double n){
			return n*2;
		}
		
		public static double multi(double n1,double n2){
			return n1*n2;
		}
		
		
	}
	class Program
	{
		public static void Main(string[] args)
		{
			
			double resultado;
			
			Operador d1=new Operador(Mat.somar);
			
			resultado = d1(10,50);
			Console.WriteLine(resultado);
			
			d1 =new Operador(Mat.multi);
			
			resultado=d1(10,50);
			Console.WriteLine(resultado);
		}
	}
}