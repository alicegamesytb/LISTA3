/*-------------------------------------------------------------------
Questão 1: Coleção de Itens Raros com Variações de Baús
Contextualização:
Em um jogo de exploração, o jogador pode abrir diferentes tipos de baús em uma masmorra.
Cada tipo de baú possui uma variação na quantidade de itens raros que pode conter.
Comando:
Crie um programa em C# que simule a coleta de itens raros a partir de diferentes tipos de baús.
O programa deve:
1. Perguntar ao jogador quantos baús ele deseja abrir.
2. Perguntar ao jogador quantos tipos diferentes de baús existem no jogo.
3. Para cada tipo de baú, perguntar quantos baús desse tipo o jogador deseja abrir.
Para cada baú aberto, dependendo do tipo, gerar aleatoriamente a quantidade de itens raros
obtidos:
• Tipo A: 0 a 3 itens
• Tipo B: 1 a 5 itens
• Tipo C: 2 a 6 itens
• (Adapte conforme o número de tipos definidos pelo jogador)
O programa deve calcular e exibir a quantidade total de itens raros obtidos após abrir todos os
baús
@Lista: 03 - Laços de repetição
@Autor: ALICE ROCHA
@Data: 10/09/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main()
    {
        Random random = new Random();
        int qttotal, qttipos, qtabrir;

        System.Console.WriteLine($"Digite a quantidade total de baús:");
        int.TryParse(Console.ReadLine(), out qttotal);
        System.Console.WriteLine($"Quantos tipos de baú existem:");
        int.TryParse(Console.ReadLine(), out qttipos);

        for (int i = 1; i <= qttipos; i++)
        {
            System.Console.WriteLine($"No {i}° tipo, quantos serão abertos: ");
            int.TryParse(Console.ReadLine(), out qtabrir);
            while (qttotal - qtabrir < 0)
            {
                System.Console.WriteLine($"Quantidade insuficiente ");
                int.TryParse(Console.ReadLine(), out qtabrir);
            }
            qttotal -= qtabrir;

            for (int j = 1; j <= qtabrir; j++)
            {
                System.Console.WriteLine($"O {j}° baú do {i}° tipoe é: {random.Next(0, 11)}");
            }
        }

        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}