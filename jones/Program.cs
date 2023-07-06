/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 04/10/2022
 * Time: 15:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace jones
{
	 public class Pes{
		
		public string nome;
		
		public string sobrenome;
		
		
		
		
		}
	
	
	class Program
	{
		public static List<Pes> Pessoa = new List<Pes>();
			
		
		
		
		
		public static void Main(string[] args)
		{
			
			
			string pesquisa;
			string nome;
			string sobrenome;
			string escolha;
			string escolha2;
			
			
			
		INICIO:
			
			Console.WriteLine("Bem vindo ao Clube Star! " +"\n"+ "Oq o senhor deseja fazer?");
			Console.WriteLine("________________________________");
			Console.WriteLine(" (1)Cadastrar Usuario           |");
			Console.WriteLine(" (2)Listagem de Usuarios        |");
			Console.WriteLine(" (3)Pesquisar Usuario           |");
			Console.WriteLine(" (4)Sair!!!!!                   |");
			Console.WriteLine("________________________________|");
			//Console.Write("Press any key to continue . . . ");
			//Console.ReadKey(true);
			
			escolha =  Console.ReadLine();
			
			switch(escolha){
				case "1":
					break;
				case "2":
					break;
				case "3":
					break;
				case "4":
					break;
			}
//************************************CADASTRO DE CLIENTES**************************************************
		INICIOCADASTRO:

			Console.Clear();
			if(escolha == "1") {
				
				Pes pes = new Pes();
				
				Console.Write("Digite Seu Primeiro Nome: ");
				nome = Console.ReadLine();
				Console.Write("Digite seu Sobrenome: ");
				sobrenome = Console.ReadLine();
				
				
				if (sobrenome != pes.sobrenome || nome != pes.nome) {
					pes.sobrenome = sobrenome;
					pes.nome = nome;
					Pessoa.Add(pes);
				} else {
					Console.WriteLine("Erro Cliente ja existente");
				}
				Console.Clear();
				Console.WriteLine("O Usurio foi cadastrado!  Deseja criar outro Usuario? (S) ou (s) para Sim || " +
				"(N) ou (n) para Não");
			
				escolha2 = Console.ReadLine();
				
				switch (escolha2) {
					case "S":
					case "s":
						break;
					case "n":
					case "N":
						break;
				}
				if (escolha2 == "S" || escolha2 == "s") {
					goto INICIOCADASTRO;
				}
				else{
					Console.Clear();
				goto INICIO;
				}
			}
			//********************** FIM CADASTRO DE CLIENTES***************************************************
			
			//********************** LISTAGEM DE PESSOAS********************************************************
			
			else if(escolha == "2"){

				foreach(Pes oloko in Pessoa){
				Console.WriteLine(oloko.nome+" "+oloko.sobrenome);
				Console.WriteLine("precione qualquer tecla para voltar ao inicio!");
				Console.ReadKey();
				goto INICIO;
				}		
			}
			//********************** FIM LISTAGEM DE PESSOAS*****************************************************
			
			//********************** PESQUISA POR USUARIO********************************************************
			
			
			else if(escolha == "3"){
				
			
				Console.Clear();
				Console.WriteLine("Digite o nome do Usuario que Você esta procurando: ");
				Console.Write("Digite o nome: ");
				pesquisa = Console.ReadLine();
				
				
				
				if(Pessoa.Exists(p => p.nome.Equals(pesquisa)) ){
				Console.WriteLine("A pessoa esta aqui {0}", pesquisa);
				
				}else{
					Console.WriteLine("nao existe");
				}
				Console.WriteLine("precione qualquer tecla para voltar ao inicio!");
				Console.ReadKey();
				goto INICIO;
			}
			//**********************FIM PESQUISA POR USUARIO*****************************************************
			}
			
		}
	}

