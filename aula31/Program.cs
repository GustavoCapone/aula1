/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 14/09/2022
 * Time: 12:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula31
{
	class veiculo{//class principal
		public int rodas;
		
		public int velmax;
		
		public bool ligado;
		public void ligar(){
			ligado = true;
		}
		public void desligar(){
			ligado = false;
		}
		public String getligado(){
			if(ligado){
				return "sim";
			}
			else{
				return "não";
			}
		}
	}
	
	class carro:veiculo{//classe derivada
		public String nome;
		public String cor;
		
		public carro(string nome, string cor){
			desligar();
			rodas=4;
			velmax=120;
			this.nome=nome;
			this.cor=cor;
		}
	}
	
	
	class Program //class programa
	{
		public static void Main(string[] args)
		{
			
			carro c1= new carro("Rapidão ", "Vermelho");
			Console.WriteLine("Cor:{0}",c1.cor);
			Console.WriteLine("Nome:{0}",c1.nome);
			Console.WriteLine("Rodas:{0}",c1.rodas);
			Console.WriteLine("Velocidade Max:{0}",c1.velmax);
			Console.WriteLine("Ligado....:{0}",c1.getligado());
		}
	}
}