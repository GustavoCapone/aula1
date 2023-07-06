/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 12/09/2022
 * Time: 16:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

public class jogador{
	public int energia;
	
	
	public bool vivo;
	
	
	public String nome;
	
	
	public jogador(){
	energia=200;
	vivo=true;
	nome="Jogador";
	}
	
	
	
	public jogador(String n){
		energia =100;
		vivo=true;
		nome= n;
	}
	
	public jogador(String n, int e){
		energia =e;
		vivo=true;
		nome= n;
	}
	
	public jogador(String n, int e, bool v){
		energia =e;
		vivo=v;
		nome= n;
	}
	
	public void info()
	{
		Console.WriteLine("O nome do jogar {0}", nome);
		Console.WriteLine("O status do jogador {0}", vivo);
		Console.WriteLine("A energia do jogador {0}", energia);
	}
	
	public void info(int n)
	{
		Console.WriteLine("O nome do jogar {0}", nome);
		Console.WriteLine("O status do jogador {0}", vivo);
		Console.WriteLine("A energia do jogador {0}", energia);
	}
}

namespace aula28
{
	class Program
	{
		public static void Main(string[] args)
		{
			String nome1;
			Console.WriteLine("digite o nome do jogador1");
			nome1=Console.ReadLine();
			jogador j0 = new jogador(nome1);
			jogador j1 = new jogador();
			jogador j2 = new jogador("LebronJames",100);
			jogador j3 = new jogador("MichaelJackison",0,false);
			
			
			Console.WriteLine("nome do jogador0: {0} e sua energia e de: {1} e seus Status e de: {2}",j0.nome,j0.energia,j0.vivo);
			//Console.WriteLine("nome do jogador2: {0} e sua energia e de: {1} e seus Status e de: {2}",j2.nome,j2.energia,j2.vivo);
			//Console.WriteLine("nome do jogador3: {0} e sua energia e de: {1} e seus Status e de: {2}",j3.nome,j3.energia,j3.vivo);
			j1.info();
			j2.info();
			j3.info();
		}
	}
}