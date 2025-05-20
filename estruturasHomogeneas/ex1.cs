// //1) Faça um programa que leia o valor dos elementos de um vetor de inteiros com 10 posições. Depois que os dados forem fornecidos o programa deverá:

// a.    Mostrar o maior e o menor valor do vetor
// b.    Mostrar quantos números pares e quantos números ímpares existem no vetor
// c.    Mostrar a média aritmética dos valores do vetor

using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;

            int[] Valores = new int[10]; //Declara o vetor e seu respectivo tamanho

            Console.WriteLine("\n---INSERÇÃO DE DADOS---");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nDigite o elemento {i + 1} do vetor: ");
                Valores[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
