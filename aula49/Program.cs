/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 03/10/2022
 * Time: 12:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula49
{
	class Program
	{
		public static void Main(string[] args)
		{
			int res=0;
			if(args.Length > 0){
				Console.WriteLine("argumentos {0}", args.Length);
				for(int i =0;i< args.Length; i++){
					//----------------------------
					res+= Int32.Parse(args[i]);
					//----------------------------
					
					//Console.WriteLine(" argumento: {0} escrita :{1}",i, args[i]);
				}
				//----------------------------
				Console.WriteLine("soma ----------{0}",res);
				//----------------------------
			}else{
				Console.WriteLine("sem argumentos");
			}
			Console.WriteLine("a");
			
		}
	}
}