// //1) Faça um programa que leia o valor dos elementos de um vetor de inteiros com 10 posições. Depois que os dados forem fornecidos o programa deverá:

// a.    Mostrar o maior e o menor valor do vetor
// b.    Mostrar quantos números pares e quantos números ímpares existem no vetor
// c.    Mostrar a média aritmética dos valores do vetor

using System;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices; //Mostrar o maior elemento do vetor

namespace exercicios
{
    public class exercicio1
    {
        public static void Executar()
        {
            
            int i;

            int q = 0;

            int x = 0;

            double y = 0;

            int[] Valores = new int[10]; 

            Console.WriteLine("\n---INSERÇÃO DE NÚMEROS---");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nDigite o elemento {i + 1} do vetor: ");
                Valores[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"Elemento {i + 1} vale: {Valores[i]}");
            }

            int maior = Valores.Max();
            int menor = Valores.Min();
            Console.WriteLine($"\nO maior número é {maior} e o menor {menor}");

            for (i = 0; i < 10; i++)
            {
                if (Valores[i] % 2 == 0)
                {
                    q++;
                }

                else if (Valores[i] % 2 != 0)
                {
                    x++;
                }
            }
            Console.WriteLine($"O vetor possui {q} elementos pares e {x} elementos ímpares");

            for (i = 0; i < 10; i++)
            {
                y += Valores[i];

            }
            Console.WriteLine($"A média aritmética dos valores é: {y / 10}");
        }
    }
}
