/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 12/09/2022
 * Time: 14:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

public class jogador{
	public int energia;
	public bool vivo;
	public String nome;
	public jogador(String n){
		energia =100;
		vivo=true;
		nome= n;
	}
	~jogador(){
		Console.WriteLine("O jogador {0} foi deletado",nome);
	}
}

namespace aula27
{
	
	class Program
	{
	
		public static void Main(string[] args)
		{
			String nome1;
			Console.WriteLine("digite o nome do jogador2");
			nome1=Console.ReadLine();
			jogador j1 = new jogador("LebronJames");
			jogador j2 = new jogador(nome1);
			jogador j3 = new jogador("MichaelJackison");
			
			
			Console.WriteLine("nome do jogador1: {0} e {1}",j1.nome,j1.energia);
			Console.WriteLine("nome do jogador2: {0}",j2.nome);
		}
	}
}