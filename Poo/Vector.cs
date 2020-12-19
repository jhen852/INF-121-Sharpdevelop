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
 			Console.WriteLine("Introduzca {0} numeros ",n);
 			for(int i = 1; i<= this.n; i++){
 				// tenemos que parciar 
 				C.Write("\tV["+i+"] = ");
 				V[i] = Int32.Parse(C.ReadLine());
 			}
 		}
 		public void mostrar (){
 			C.Write("V[");
 				for(int i = 1; i<this.n; i++)
 				C.Write(V[i] +",");
 			C.WriteLine(V[n]+"]");
 			
 		}
 		//sumar elementos 
 		
 		public int sumarElementos(){
 			int suma = 0;
 			for(int i = 1; i<=n;i++){
 				suma = suma+ V[i];
 			}
 			return suma;
 		}
 		
	}
}
