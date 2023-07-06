/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 15/09/2022
 * Time: 16:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula36
{
	abstract class Veiculo{//classe base abstrata
		protected int velMaxima;
		
		protected int velAtual;
		
		protected bool ligado;
		
		public Veiculo(){
			ligado=false;
			velAtual=0;
		}
		
		public void setLigado(bool ligado){
			this.ligado=ligado;
		}
		
		public int getVelAtual(){
			return velAtual;
		}
		abstract public void aceleracao(int multi);
	}

	class Carro:Veiculo{
		
		public Carro(){
			velMaxima=200;
		}
		override public void aceleracao(int multi){
			velAtual+=10*multi;
		}
	}
	
	
	class Program
	{
		public static void Main(string[] args)
		{
			Carro carro1 = new Carro();
			carro1.aceleracao(1);
			
			
			Console.WriteLine(carro1.getVelAtual());
		}
	}
}