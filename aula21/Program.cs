/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 09/09/2022
 * Time: 13:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula21
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] num=new int[5]{11,22,33,44,55};
				
			
			for(int i=0; i<num.Length; i++ ){
				Console.WriteLine(num[i]);
			}
			
			//foreach(int n in num) {
			//	Console.WriteLine(n);
			//}
		}
	}
}