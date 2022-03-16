/*
 * Created by SharpDevelop.
 * User: Daniela
 * Date: 25/10/2018
 * Time: 15:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ElTrilero
{
	class Program
	{
		public static void Main(string[] args)
		{
		    int numUsuario;
		    Console.WriteLine("Escribe el número secreto entre 1 y 5");
		    
		    int numAleatorio;
		    numAleatorio = DameNumeroAleatorio (1, 5);
		    
		    int numsecreto = numAleatorio;
		    
		    int contador = 0;
		    bool elShowSigue = true;
		    while (elShowSigue) 
		    {
		   		 int num = UsuarioEscribeNum();
		   		 if (num == numsecreto)
		   		 {
		   		 	elShowSigue = false;
		   		 	Console.WriteLine("Bingo");
		   		 	Console.WriteLine("Tu número de intentos fallidos: "+contador);
		   		 }
		   		 else
		   		 {
		   		 	elShowSigue = true;
		   		 	contador = contador+1;
		   		 	Console.WriteLine("No es el numero");
		   		 }	
		    }
				
		    Console.WriteLine("Fin del juego");			
			Console.ReadKey(true);
		}
		
		
		static int UsuarioEscribeNum()
		{
		    int lecturaInt;
		    lecturaInt = Convert.ToInt32(Console.ReadLine());
		    return lecturaInt;
		}
		
		static int DameNumeroAleatorio(int desde, int hasta)
		{
		    Random rnd = new Random();		    
		    return rnd.Next(desde,hasta);		    	
		}
		
		
	}
}