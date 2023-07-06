/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 14/09/2022
 * Time: 11:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

class calculos{
	public double v1;
	public double v2;
	
	public calculos(double v1,double v2){
		this.v1=v1;
		this.v2=v2;
	}
	
	
	public double somar(){
		return v1+v2;
	}
}

namespace aula30
{
	class Program
	{
		public static void Main(string[] args)
		{
			calculos c=new calculos(10,2);
			
			Console.WriteLine(c.somar());
		}
	}
}