/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 29/09/2022
 * Time: 14:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula42
{
	struct Carro{
		
		public String modelo;
		
		public String cor;
		
		
		
		public void info(){
			Console.WriteLine("MODELO:{0}",this.modelo);
			
			Console.WriteLine("MARCA:{0}",this.cor);
			Console.WriteLine("---------------------------------");
		}
	}
	
	
	
	
	/*****************************/class Program
	{
		public static void Main(string[] args)
		{
			
			int[] numeros = new int[10];
			
			Carro[] carros=new Carro[5];
			
			carros[0].modelo="HRV";
			carros[0].cor="vermelho";
			
			carros[1].modelo="GOLF";
			carros[1].cor="rosa-choque";
			
			carros[2].modelo="Amarock";
			carros[2].cor="Prata";
			
			carros[3].modelo="POLO";
			carros[3].cor="preto";
			
			carros[4].modelo="Civic";
			carros[4].cor="Laranja";
			
			//*******************************************************
			Console.WriteLine("************************************************");
			//Pode chamar dessa forma ou chamar um "for" igual temos no proximos exemplo.
			
			
			
			carros[0].info();
			carros[1].info();
			carros[2].info();
			carros[3].info();
			carros[4].info();
			
			//*******************************************************
			Console.WriteLine("************************************************");
			//*******************************************************
			
			for(int i=0;i<carros.Length;i++){
				carros[i].info();
			}
			
			
			
		}
	}
}