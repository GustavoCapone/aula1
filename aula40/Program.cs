/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 21/09/2022
 * Time: 11:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula40
{
	public interface Fazenda{
		
		void plantar();
		
		void regar();
		
		void info();
		
	}
	public interface Plantacao{
		int sementes(int quant);
		void pivo();
		
	}
	//--------------------------------------------------------
	class Trabalho:Fazenda,Plantacao{
		public int sementa;
		private bool plantaras;
		
		public Trabalho(){
			sementa=100;
		}
		
		
		public int sementes(int quant){
			this.sementa=quant;
			return sementa;
		}
		
		
		public void pivo(){
			
		}
		
		
		
		public void plantar(){
			
		}
		public void regar(){
			
		}
		public void info(){
		}
		
		
		
		/*
		
		public int semente;
		
		public bool plantado;
		
		public Trabalho(){
			setSementes(100);
		}
		//--------------------------------------------------------
		public void setSementes(int qtde){
			this.sementes=qtde;
		}
		
		public bool pivo(){
			this.pivo=true;
		}
		
		public int plantar(){
			
		}
		public bool regar(){
			this.regar=false;
		}
		public bool info(){
			
		}
		
		*/
	}
	
	//--------------------------------------------
	class Program
	{
		public static void Main(string[] args)
		{
			Trabalho t1 = new Trabalho();
			
			Console.WriteLine(t1.sementa);
		}
	}
}