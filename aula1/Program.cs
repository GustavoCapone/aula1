/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 01/09/2022
 * Time: 16:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula1
{
	class Principal
	{
		public static void Main(string[] args)
			//static void Main (String[] args) A diferença e que um e publico para o sistema e o outro não
		{	
			Console.Write("Olá mundo! ");
			for(int i = 0; i < args.Length; i++){
			   Console.WriteLine(args.GetValue(i));
			}
			
			
			
				
				
			//Console.ReadKey(true); //conmando que fala que o o programa vai sair so depois de apertar uma tecla
		}
	}
}