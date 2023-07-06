/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 05/10/2022
 * Time: 13:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace aula55
{
	class Program
	{
		public static void Main(string[] args)
		{
			LinkedList<string> pessoas = new LinkedList<string>();
			//no inicio
			pessoas.AddFirst("joao");
			pessoas.AddFirst("kate");
			pessoas.AddFirst("michael");
			//no fim
			pessoas.AddLast("kardono");
			
			//pessoas.Clear();
			if(pessoas.Find("kate")==null){
				Console.WriteLine("nao encontrado");
			}else{
				Console.WriteLine("achado");
			}
			pessoas.Remove("kate");
			
			
			LinkedListNode<string> noe;
			noe=pessoas.FindLast("joao");
			
			//apos
			pessoas.AddAfter(noe,"pocarrondas");
			
			foreach(string p in pessoas){
				Console.WriteLine(p);
				//antes
				pessoas.AddBefore(noe,"joao");
			Console.WriteLine(p);
			
			
			
			
			}
			
			
			
		}
	}
}