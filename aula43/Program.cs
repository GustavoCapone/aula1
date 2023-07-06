/*
 * Created by SharpDevelop.
 * User: nti
 * Date: 29/09/2022
 * Time: 14:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula43
{
	
	 class Galinha{
		
		private string nomeGalinha;
		private int numOvo;
		public Galinha(string nomeGalinha){
		this.nomeGalinha=nomeGalinha;
			numOvo=0;
		}
		public Ovo botar(){
			
			numOvo++;
			return new Ovo(numOvo,nomeGalinha);
		}
		
	}
	//***********************************************
	class Ovo{
		private int numOvo;
		
		private string minhaGalinha;
		
		public Ovo(int numOvo,string minhaGalinha){
			this.numOvo=numOvo;
			this.minhaGalinha=minhaGalinha;
			Console.WriteLine("Ovo criado:{0} --- {1}",this.numOvo,this.minhaGalinha);
	}
	}
	//***********************************************
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			Galinha g1=new Galinha("jubiscreuda");
			Galinha g2=new Galinha("locastia");
			Galinha g3=new Galinha("pucatruastar");
			
			g1.botar();
			g1.botar();
			g1.botar();
			g2.botar();
			g1.botar();
			g3.botar();
			g3.botar();
			
			
			Console.WriteLine("************************************************");
			
		}
	}
}