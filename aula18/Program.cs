/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 09/09/2022
 * Time: 09:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula18
{
	class Program
	{
		public static void Main(string[] args)
		{	
			int[] a2=new int [10];
			
				for(int a1 = 0; a1 < a2.Length; a1++){
				a2[a1]=a1;
				
			}
			for(int a1 = 0; a1 < a2.Length; a1++){
				Console.WriteLine("valor de a2 pos{0}: {1}",a1,a2[a1]);
			}
		}
	}
}