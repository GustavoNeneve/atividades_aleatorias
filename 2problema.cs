using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static void Main()
  {
    int superiorY;
    int superiorX;
    int inferiorY;
    int inferiorX;
    int pontoY;
    int pontoX;
    
    
    Console.WriteLine("x do ponto superior esquerdo");
  	superiorX = int.Parse(Console.ReadLine());
    Console.WriteLine("y do ponto superior esquerdo");
  	superiorY = int.Parse(Console.ReadLine());
    
    Console.WriteLine("x do ponto inferior direito");
  	inferiorX = int.Parse(Console.ReadLine());
    Console.WriteLine("y do ponto inferior direito");
  	inferiorY = int.Parse(Console.ReadLine());
    
    Console.WriteLine("x do ponto a ser testado");
  	pontoX = int.Parse(Console.ReadLine());
    Console.WriteLine("y do ponto a ser testado");
  	pontoY = int.Parse(Console.ReadLine());
    
    if(pontoX >= superiorX && pontoX <= inferiorX)
    {
    	if(pontoY <= superiorY && pontoY >= inferiorY)
    		{
    				Console.WriteLine("O ponto esta dentro do retangulo");
   			}else
    		{
      			Console.WriteLine("O ponto esta fora do retangulo");
    		}

    }else
    {
      Console.WriteLine("O ponto esta fora do retangulo");
    }
    
  }
}