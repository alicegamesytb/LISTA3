/*-------------------------------------------------------------------
Questão 2: Cálculo de Pontuação por Missão com Níveis de
Dificuldade
Contextualização:
Em um jogo de aventuras, um jogador completa missões com diferentes níveis de dificuldade.
Cada nível de dificuldade afeta a pontuação ganha por inimigo derrotado.
Comando:
Desenvolva um programa em C# que:
1. Pergunte ao jogador quantas missões ele completou.
2. Para cada missão, pergunte qual o nível de dificuldade (Fácil, Médio, Difícil).
3. Para cada missão, pergunte quantos inimigos ele derrotou.
A pontuação por inimigo depende do nível de dificuldade:
• Fácil: 50 pontos por inimigo
• Médio: 100 pontos por inimigo
• Difícil: 150 pontos por inimigo
O programa deve calcular e exibir a pontuação total acumulada pelo jogador.
@Lista: 03 - Laços de repetição
@Autor: ALICE ROCHA
@Data: 10/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    public static void Main(String[] args)
    {
        int pontos = 0, missao, dificuldade, inimigos, i = 0;
        Console.WriteLine("Missões completadas: ");
        int.TryParse(Console.ReadLine(), out missao);

        while (i < missao)
        {
            Console.WriteLine("teste");
            Console.WriteLine($"Dificuldade (missão {i + 1}):\n1 - Fácil (50 pontos por inimigos)\n2 - Médio (100 pontos por inimigos\n3 - Difícil (150 pontos por inimigo)");
            int.TryParse(Console.ReadLine(), out dificuldade);
            Console.WriteLine($"Inimigos derrotados (missão {i + 1}): ");
            int.TryParse(Console.ReadLine(), out inimigos);

            if (dificuldade == 1)
            {
                pontos = pontos + (inimigos * 50);
            }
            else if (dificuldade == 2)
            {
                pontos = pontos + (inimigos * 100);
            }
            else if (dificuldade == 3)
            {
                pontos = pontos + (inimigos * 150);
            }
            i++;
        }

        Console.WriteLine($"{pontos} Pontos");
        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}