/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 03/10/2022
 * Time: 09:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula46
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
		
		public static int fat(int n){
			int res;
			if(n<=1){
				res=1;
			}else{
				res=n*fat(n-1);
			}
			return res;
		}
		
	}
	
	
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			
			Calc calcu=new Calc();
			
			var res=Calc.fat(5);
			
			Console.WriteLine("{0}",res);
		}
	}
}