using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static void Main()
  {
    int qtdJogadores;
    int pontuacaoJogador;
    int totalVencedores = 0;
    
    
    Console.WriteLine("Quntos jogadores tem");
    qtdJogadores = int.Parse(Console.ReadLine());
    
    for (int i= 0; i < qtdJogadores; i++)
    {
      Console.WriteLine("quantos pontos fez o jogador "+(i+1));
      pontuacaoJogador = int.Parse(Console.ReadLine());
      //Console.WriteLine(qtdJogadores+" Hello C# "+i);
      
      if (pontuacaoJogador >= 100)
      {
        totalVencedores= totalVencedores+1;
       
      }
    }
    
    Console.WriteLine("O total de vencedores é "+totalVencedores);
    
      
  }
}
