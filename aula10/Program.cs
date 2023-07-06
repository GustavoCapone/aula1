/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 06/09/2022
 * Time: 10:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula10
{
	class Program
	{
		enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado};
		public static void Main(string[] args)
		{
			DiasSemana ds1 = DiasSemana.Domingo;
			DiasSemana ds2 =(DiasSemana)3;
			int ds3 =(int)DiasSemana.Sexta;
			
			Console.WriteLine("O valor é: "+ ds1 +" "+ ds2 +" "+ ds3 +" ");
		}
	}
}