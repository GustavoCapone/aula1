/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 12/09/2022
 * Time: 11:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula24
{
	class Program
	{
		public static void Main(string[] args)
		{	
			int num=5;
			dobrar(ref num);
			Console.WriteLine(num);
		}
		public static void dobrar(ref int valor){
			valor*=2;
		}
	}
}