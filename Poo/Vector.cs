/*
 * Created by SharpDevelop.
 * User: Jhen
 * Date: 18/12/2020
 * Time: 10:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using C = System.Console;

namespace Poo
{
	public class Vector
	{
		private int []V;// aqui estamos declarando 
		private int n;
 		public Vector(int n)
		{
 			this.n = n;
 			V = new int[this.n+1];
 			//aqui estamos creando una matriz con n numero de cantidad 	
 		
 		}
 		// Podemos llenar el vector que hemos creado 
 		
 		public void LlenarVector (){
 			Console.WriteLine("Introduzca {0} numeros : "+n);
 			for(int i = 1; i<= this.n; i++){
 				// tenemos que parciar 
 				V[i] = Int32.Parse(C.ReadLine());
 			}
 		}
 		public void mostrar (){
 			C.WriteLine("V[");
 				for(int i = 1; i<this.n; i++)
 				C.WriteLine(\tV[i] +",");
 			C.WriteLine(V[n]+"]");
 			
 		}
	}
}
