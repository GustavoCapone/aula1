/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 15/09/2022
 * Time: 15:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula33
{
	class veiculo{				//base
		
		public int velatual;
		
		
		
		private int velmax;
		
		
		
		protected bool ligado;
		
		
		public veiculo(int velmax){
			velatual=0;
				this.velmax=velmax;
			ligado=false;
			
		}
		
		public bool getligado(){
			return ligado;
		}
		
		public int getvelmax(){
			return velmax;
		}
			
	}
	
	class carro:veiculo{ //derivado veiculo
		
		public string nome;
		
		public carro(string nome, int vm):base(vm){
			this.nome=nome;
			ligado = true;
			
		}
		
	}
	class Program
	{
		public static void Main(string[] args)
		{
			carro carro = new carro("long", 140);
			
			Console.WriteLine("Nome: {0} velocida max{1} esta ligado ou desligado? {2}",carro.nome,carro.getvelmax(),carro.getligado());
		}
	}
}