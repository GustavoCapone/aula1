/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 09/09/2022
 * Time: 07:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula16
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Double n1,n2,n3,n4,n5;
			Double[] n=new double[5]; //primeira posição sempe 0.
			//Double[] num=new double[3]{55,77,99};
			Double[] num={55,77,88,99,66,33}; //[ 6 ]
			String [] veiculos= new string[3];
			
			veiculos[0] ="carro";
					veiculos[1] ="moto";
					veiculos[2] ="onibus";
					
					
			n[0] = 11;
			n[1] = 22;
			n[2] = 33;
			n[3] = 44;
			n[4] = 55;
			Console.WriteLine(n[0]+"  "+num[2]+"   "+ num[5]+"   "+ veiculos[2]);
		}
	}
}