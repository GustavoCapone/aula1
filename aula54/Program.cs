/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 04/10/2022
 * Time: 14:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace aula54
{
	class Program
	{
			public static void Main(string[] args)
		{
		
		Dictionary <int,string> veiculos = new Dictionary<int, string>();
		
		veiculos.Add(10,"Carro");
		veiculos.Add(5,"Aviao");
		veiculos.Add(1,"Moto");
		veiculos.Add(0,"Barco");
		veiculos.Add(20,"Mobilete");
		
		
		Console.WriteLine("Tamanho do dicionary:{0}",veiculos.Count);
		//***************************************************
		if(veiculos.ContainsKey(20)){
			Console.WriteLine("OK");
		}
		else {
			Console.WriteLine("NO ok");
		}
		
		//****************************************************
		veiculos.Remove(20);
		//****************************************************
		
		if(veiculos.ContainsValue("Mobilete")){
			Console.WriteLine("OK");
		}
		else {
			Console.WriteLine("NO ok");
		}
		//****************************************************
		foreach(KeyValuePair <int, string> v in veiculos){
			Console.WriteLine(v);
		}
		
		
		//****************************************************
		
		}
	}
}