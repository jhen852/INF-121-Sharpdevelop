﻿/*
 * Created by SharpDevelop.
 * User: Jhen
 * Date: 18/12/2020
 * Time: 10:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using C = System.Console;
namespace Poo
{
	class Program
	{
		public static void Main(string[] args)
		{
			C.WriteLine("Creando un vector");
			int n;
			Vector V1;
			n = Int32.Parse(C.ReadLine());
			V1 = new Vector(n);
			V1.LlenarVector();
			V1.mostrar();
			
			// sumar los elementos 
			C.WriteLine("Sumar elementos");
			//debemos asignarle una variable y esa variable despues imprimir 
			int suma = V1.sumarElementos();
			C.WriteLine("La suma de los numeros de los vectores es "+suma);
			Console.ReadKey(true);
		}
	}
}