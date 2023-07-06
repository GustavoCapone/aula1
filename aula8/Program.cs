/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 05/09/2022
 * Time: 15:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula8
{
	class Program
	{
		public static void Main(string[] args)
		{
			int ano2,ano1,subtracao;
			
			
			String nome;
			
			Console.WriteLine("Digite seu nome: ");
			nome=Console.ReadLine();
			Console.WriteLine("digite o ano que você nasceu: ");
			ano2=int.Parse(Console.ReadLine());
			Console.WriteLine("Digite o ano que você esta: ");
			ano1=Convert.ToInt32(Console.ReadLine());
			subtracao = (ano1 - ano2);
			Console.WriteLine(nome+" Sua idade é "+ subtracao +"anos");
			
		}
	}
}