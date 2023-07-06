/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 30/09/2022
 * Time: 07:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula44
{
	class Calc{
		
		
		public int soma(params int[]n){
			int s =0;
			for(int i=0;i<n.Length;i++){
				s+=n[i];
			}
			return s;
			
			
		}
		public double soma(params double[]n){
			double s =0;
			for(int i=0;i<n.Length;i++){
				s+=n[i];
			}
			return s;
			
			
		}
		
	}
	
	
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			
			Calc calc=new Calc();
			
			var res=calc.soma(10,15);
			
			Console.WriteLine("{0}",res);
		}
	}
}