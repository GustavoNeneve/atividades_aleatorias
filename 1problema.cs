using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static void Main()
    {
    int player1R, player2R;
    string vencedor;
    Console.WriteLine("Player1 digite 1 para pedra, 2 para papel, 3 para tesoura");
    player1R = int.Parse(Console.ReadLine());
    Console.WriteLine("Player2 digite 1 para pedra, 2 para papel, 3 para tesoura");
    player2R = int.Parse(Console.ReadLine());
   	
        
    	if(player1R == player2R)
    	{
        vencedor = "foi empate";
        Console.WriteLine(vencedor);
    	}else{
		    if(player1R == 1)
      			{
        		if(player2R == 2)
       		    {
    			    vencedor = "Player2";
        			Console.WriteLine("Pedra vs Papel: o vencedore é "+vencedor);        			
                }else
                    {
          			vencedor = "Player1";
                	Console.WriteLine("Pedra vs Tesoura: o vencedore é "+vencedor);
        			}
                }
                    
            if (player1R == 2)
                {
                if (player2R == 3)
                {
                    vencedor = "Player2";
          			Console.WriteLine("Papel vs Tesoura: o vencedore é "+vencedor);
                }else
                    {
                    vencedor = "Player1";
             		Console.WriteLine("Papel vs Tesoura: o vencedore é "+vencedor);
                    }
                }
            if (player1R == 3)
                {
                if (player2R == 1)
                {
                vencedor = "Player2";
            	Console.WriteLine("Tesoura vs Pedra: o vencedore é "+vencedor);
        		}else
                {
                vencedor = "Player1";
              	Console.WriteLine("Tesoura vs Papel: o vencedore é "+vencedor);
                }
                }    
            
            
        }
    }
}
