/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 13/09/2022
 * Time: 10:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula29
{
	public static class jogador{
	
		static public int energia;
	
	
		static public bool vivo;
	
	
		static public String nome;
	
	
	static public void iniciar(String n){
	energia=200;
	vivo=true;
	nome=n;
	}
	
	
	static  public void info()
	{
		Console.WriteLine("O nome do jogar {0}", nome);
		Console.WriteLine("O status do jogador {0}", vivo);
		Console.WriteLine("A energia do jogador {0}", energia);
	}
	
}
	
	class inimigo{
		static public bool alerta;
		
		public String nomei;
		
		public inimigo(String n){
			alerta=false;
			nomei=n;
		}
		
		public void infoi(){
			Console.WriteLine(nomei);
			Console.WriteLine(alerta);
			Console.WriteLine("-------------------");
		}
	}

	class Program
	{
		public static void Main(string[] args)
			{
			//String senha= "123";
			
			
			
			
			
			int energia=200;
			char escolha;
			Console.WriteLine("Você esta andando pela praça e te oferecem cigarro, aceitar? ");
			Console.WriteLine("|S|Sim   |N|Não");
			
			escolha =char.Parse(Console.ReadLine());
			
			switch(escolha){
				case's':
				case'S':
					energia = 200-50;
					break;
				case'N':
				case'n':
					energia = 200;
					break;
			}
			Console.WriteLine("Sua energia e de: "+energia);
			Console.WriteLine("-------------------------------------");
			Console.WriteLine("Você esta em um restaurante, Prefere pedir uma comida saldavel ou prefere um sanduiche com oleo? ");
			Console.WriteLine("|S|sanduiche  |N|Saldavel");
			
			escolha =char.Parse(Console.ReadLine());
			
			switch(escolha){
				case's':
				case'S':
					energia= energia -50;
					break;
				case'N':
				case'n':
					energia = energia;
					break;
			}
			Console.WriteLine("Sua energia e de: "+energia);
			Console.WriteLine("-------------------------------------");
			Console.WriteLine("Deseja mihjar no bebado? ");
			Console.WriteLine("|S|Sim   |N|Não");
			
			escolha =char.Parse(Console.ReadLine());
			
			switch(escolha){
				case's':
				case'S':
					energia =energia;
					break;
				case'N':
				case'n':
					energia = energia;
					break;
						
			}
			Console.WriteLine("sua energia e de"+energia);
			Console.WriteLine("-------------------------------------");
			
			//jogador.iniciar("Bruno");
			//jogador.info();
			
			inimigo i1 =new inimigo("Doido");
			inimigo i2 =new inimigo("Alucinado");
			inimigo i3 =new inimigo("LOKO!!!");
			//Console.WriteLine("O bebado esta:");
			//i1.infoi();
			//i2.infoi();
			//i3.infoi();
			
			Console.WriteLine("------------------------------");
			
			if(escolha.Equals('n')||escolha.Equals('N')){
				inimigo.alerta=false;
				Console.WriteLine("O bebado esta:");
				i1.infoi();
				i2.infoi();
				i3.infoi();
				Console.WriteLine("Você foi embora em paz, sua energia e de: {0}",energia);
			}
			else if((escolha.Equals('s')||escolha.Equals('S')) && energia <= 100){
				inimigo.alerta=true;
				Console.WriteLine("O bebado esta:");
					i1.infoi();
					i2.infoi();
					i3.infoi();
				Console.WriteLine("Sua energia e {0}, Antes que você pudesse mijar no bebado ele se levantou," +
"				                  ápos isso foi feito uma luta, aonde você lutou bravamente porem...\nSua energia estava baixa!!",energia);
				Console.WriteLine("Você chegou no hospital espancado e Mijado!!\nE a unica coisa que você se lembra e do rosto do Bebado");
				
			}
			
			else{
				inimigo.alerta=true;
				Console.WriteLine("O bebado esta:");
				i1.infoi();
				i2.infoi();
				i3.infoi();
				Console.WriteLine("Sua energia e {0}, Antes que você pudesse mijar no bebado ele se levantou," +
"				                  nesse momento você e bebado cravaram uma luta epica, aonde você lutou bravamente..." +
"				\nE com seu ultimo suspiro de energia um golpe no bebado foi lançado, ápos ele estar caido em batalha, Voce o humilha mijando nele!!",energia);
			}
			
				
				
			
			
			
			
			
			
			
		}
	
		}
	}
