/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 05/10/2022
 * Time: 14:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace aula56
{
	class Program
	{
		public static void Main(string[] args)
		{
			//List<string> carros2= new List<string>();
			List<string> carros= new List<string>();
			string[] carros2=new string[7];
			
			
			carros.Add("gol");
			carros.Add("golf");
			carros.Add("polo");
			carros.Add("sedan");
			
			//carros2.AddRange(carros);
			
			foreach(string carro in carros){
				Console.WriteLine(carro);
			}
			foreach(string carro2 in carros2){
				Console.WriteLine(carro2);
			}
			
			if(carros.Contains("gol")){
				Console.WriteLine("esta na lista");
			}
			else{
				Console.WriteLine("não esta!");
			}
			
			//carros2.Clear();
			
			carros.CopyTo(carros2,1);
			
			
			
			string c="HIV";
			int pos=0;
			pos=carros.IndexOf(c);
			Console.WriteLine(c,pos);
			
		}
	}
}