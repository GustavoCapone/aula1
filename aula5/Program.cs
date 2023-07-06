/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 05/09/2022
 * Time: 10:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula5
{
	class Program
	{
		public static void Main(String[]args)
		{
			// & = and / e
			// | = or / ou
			
			bool resposta = (5>=3)|(10<5);
			bool resposta1 = (9<8)|(10<6);
			bool resposta2 = (9>8)&&(10<6);
			bool resposta3 = (9>8)&&(10>6);
			Console.WriteLine(resposta);
			Console.WriteLine(resposta1);
			Console.WriteLine(resposta2);
			Console.WriteLine(resposta3);
		}
	}
}