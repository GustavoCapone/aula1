/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 06/09/2022
 * Time: 10:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula9
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a,b,c,d;
			a = 1;
			b = 2;
			c = 3;
			d = 4;
			//<<
			//
			a = a<<1;
			b=b>>4;
			c=c<<3;
			Console.WriteLine(a+" "+c+" ");
		}
	}
}