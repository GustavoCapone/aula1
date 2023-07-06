/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 15/09/2022
 * Time: 14:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula32
{
	class veiculo{//class principal
		private int rodas;
		
		public int velmax;
		
		public bool ligado;
		
		public veiculo(int rodas){
			this.rodas=rodas;
		}
		public void ligar(){
			ligado = true;
		}
		public void desligar(){
			ligado = false;
		}
		public String getligado(){
			return (ligado?"Sim":"Não");
			
			if(ligado){
				return "sim";
			}
			else{
				return "não";
			}
		}
		public int getrodas(){
			return rodas;
		}
		public void setrodas(int rodas){
			if(rodas<0){
				this.rodas=0;
			}else if(rodas>20){
				this.rodas=20;
			}
			else{
				this.rodas=rodas;
			}
		}
	}
	
	class carro:veiculo{//classe derivada
		public String nome;
		public String cor;
		
		public carro(string nome, string cor):base(4){
			desligar();
			
			velmax=120;
			this.nome=nome;
			this.cor=cor;
		}
	}
	class carroCombate:carro{
		public int municao;
		public carroCombate():base("Carro de combate","verde"){
			municao=100;
			setrodas(6);
		}
	}
	
	
	class Program //class programa
	{
		public static void Main(string[] args)
		{
			
			carro c1= new carro("Rapidão ", "Vermelho");
			carroCombate cc1 = new carroCombate();
			c1.ligar();
			
			
			Console.WriteLine("Cor:{0}",c1.cor);
			Console.WriteLine("Nome:{0}",c1.nome);
			Console.WriteLine("Rodas:{0}",c1.getrodas());
			Console.WriteLine("Velocidade Max:{0}",c1.velmax);
			Console.WriteLine("Ligado....:{0}",c1.getligado());
			
			Console.WriteLine("------------------------------------");
			
			Console.WriteLine("Cor:{0}",cc1.cor);
			Console.WriteLine("Nome:{0}",cc1.nome);
			Console.WriteLine("Rodas:{0}",cc1.getrodas());
			Console.WriteLine("Velocidade Max:{0}",cc1.velmax);
			Console.WriteLine("Ligado....:{0}",cc1.getligado());
			Console.WriteLine("munição....:{0}",cc1.municao);
		}
	}
}