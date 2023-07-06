/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 09/09/2022
 * Time: 11:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula19
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] num=new int [10];
			
			int i=10;
			
			while(i<num.Length){
				num[i]=20;
				Console.WriteLine(num[i]);
				i++;
			}
			Console.WriteLine("fim!!!");
		}
	}
}