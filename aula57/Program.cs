/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 07/10/2022
 * Time: 11:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace aula57
{
	class Program
	{
		public static void Main(string[] args)
		{
			string escolha1;
			string escolha2;
			string escolha3;
			//string[] vs={"Carro","Navio","Aviao"}
			Queue<string>veiculos=new Queue<String>();
			
		INICIO:
			
			Console.WriteLine("Digite alguns veiculos!");
			escolha1 = Console.ReadLine();
			escolha2 = Console.ReadLine();
			escolha3 = Console.ReadLine();
			
			veiculos.Enqueue(escolha1);//adiciona no final da fila
			veiculos.Enqueue(escolha2);
			veiculos.Enqueue(escolha3);
			
			string c="carro";
			
			
			
			if(escolha1 != escolha2 && escolha1 != escolha3 && escolha2 != escolha3){
					if(veiculos.Contains(c)){
						Console.WriteLine("Veiculo {0} encontrado",c);
					}
					else{
						Console.WriteLine("veiculo nao encontrado");
					}
			}else{
				Console.WriteLine("Não pode ter mais de um veiculo com o mesmo nome!");
				goto INICIO;
			}
			
			//Console.WriteLine("Primeiro Veiculo "+veiculos.Dequeue());//pega o primeiro veiculo e depois o remove esse elemento.
			//Console.WriteLine("Primeiro elemento  "+ veiculos.Peek());//ele retorna o primeiro elemento porem nao remove o elemento.
			
		
			foreach(string y in veiculos){
				Console.WriteLine("veiculo "+ y);
			}
			//Conta quantas varias estao dentro da Queue.				
			Console.WriteLine("Os veiculos digitados são: "+veiculos.Count);
			
			
			while(veiculos.Count > 0){
				Console.WriteLine(veiculos.Dequeue());
			}
			
			Console.WriteLine("Os veiculos digitados são: "+veiculos.Count);
			
		}
	}
}