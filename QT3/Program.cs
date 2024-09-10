﻿/*-------------------------------------------------------------------
Questão 3: Gerenciamento de Inventário com Limite e Tipos de
Itens
Contextualização
Em um RPG, o jogador gerencia um inventário com diferentes tipos de itens, cada um com sua
quantidade específica. O inventário tem um limite máximo de itens que pode conter.
Comando:
Crie um programa em C# que:
1. Pergunte ao jogador quantos tipos diferentes de itens ele deseja armazenar no
inventário.
2. Para cada tipo de item, pergunte o nome do item e quantos itens desse tipo ele possui.
3. Pergunte ao jogador qual é a capacidade máxima do inventário.
O programa deve calcular e mostrar a quantidade total de itens no inventário e verificar se está
dentro da capacidade máxima, informando se está excedido ou não.
@Lista: 03 - Laços de repetição
@Autor: ALICE ROCHA
@Data: 10/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    public static void Main(String[] args)
    {
        int tipos, quantidade = 0, capacidade, total = 0;
        Console.WriteLine("Tipos de item: ");
        int.TryParse(Console.ReadLine(), out tipos);

        for (int i = 0; i < tipos; i++)
        {
            Console.WriteLine($"Nome do item {i + 1}:");
            Console.ReadLine();
            Console.WriteLine("Quantidade deste item no inventário: ");
            int.TryParse(Console.ReadLine(), out quantidade);
            total += quantidade;
        }
        Console.WriteLine("Capacidade máxima: ");
        int.TryParse(Console.ReadLine(), out capacidade);

        if (total > capacidade)
        {
            System.Console.WriteLine($"Total: {total} itens. Excede a capacidade.");
        }
        else if (total < capacidade)
        {
            System.Console.WriteLine($"Total: {total} itens. Dentro da capacidade.");
        }
        else if (total == capacidade)
        {
            System.Console.WriteLine($"Total: {total} itens. Dentro da capacidade");
        }
        
    }
}