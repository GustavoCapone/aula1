/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 28/09/2022
 * Time: 11:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula41
{
	struct Carro{
		public String marca;
		
		public String modelo;
		
		public String cor;
		
		public Carro(String marca, string modelo, string cor){
			this.marca=marca;
			this.modelo=modelo;
			this.cor=cor;
		}
		
		public void info(){
			Console.WriteLine("MARCA:{0}",this.marca);
			
			Console.WriteLine("MODELO:{0}",this.modelo);
			
			Console.WriteLine("COR:{0}",this.cor);
		}
	}
	
	
	
	
	/*****************************/class Program
	{
		public static void Main(string[] args)
		{
			Carro c1;
			Carro c2= new Carro("Honda","HRv","Rosa");
			Carro c3= new Carro("CHEVROLE","prisma","laranja");
			
			c1.marca="VW";
			c1.modelo="GOLF";
			c1.cor ="AMARELO";
			
			Console.WriteLine("MARCA:{0}",c1.marca);
			
			Console.WriteLine("MODELO:{0}",c1.modelo);
			
			Console.WriteLine("MODELO:{0}",c1.cor);
			
			//*******************************************************
			Console.WriteLine("************************************************");
			//*******************************************************
			
			
			
			Console.WriteLine("MARCA:{0}",c2.marca);
			
			Console.WriteLine("MODELO:{0}",c2.modelo);
			
			Console.WriteLine("COR:{0}",c2.cor);
			
			//*******************************************************
			Console.WriteLine("************************************************");
			//*******************************************************
			
			c3.info();
			
			
			
		}
	}
}