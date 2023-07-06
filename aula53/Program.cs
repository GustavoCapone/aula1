/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 04/10/2022
 * Time: 14:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula53
{
	public static class Area{
		public static float quad(float bas, float alt){
			
			if(bas == 0 || alt == 0){
				throw new Exception("Base e altura não podem ser igual a ZERO !!");
			}
			return bas*alt;
		}
		
	}
	
}
	//NAMESPACE SERVE PARA ORGANIZAÇÃO; 
namespace aula535{
	
public static class Area{
		public static float quad(float bas, float alt){
			
			if(bas == 0 || alt == 0){
				throw new Exception("Base e altura não podem ser igual a ZERO !!");
			}
			return bas*alt;
		}
		
	}
	
}

	
	class Program
	{
		public static void Main(string[] args)
		{
			float area=0;
			
			try{
				area= aula53.Area.quad(10,5);
				Console.WriteLine("Area do quad : {0}", area);
			}catch(Exception e){
				Console.WriteLine("erro!!   " + e.Message);
				Console.WriteLine("erro!!   " + e.GetType());
			}finally{
				Console.WriteLine("FIM!!!!");
			}
		}
	}
