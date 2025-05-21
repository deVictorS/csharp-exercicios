// 2) Um professor tem uma turma com 50 alunos. Ele vai dar no semestre 3 avaliações. Faça um programa que lance a nota de cada aluno nessas avaliações (considere lançar apenas para 5 alunos para agilizar, claro...).

// a.    Mostre a nota total de cada aluno
// b.    Mostre a média da nota da turma em cada uma das provas

using System;

namespace exercicios
{
    public class exercicio2
    {
        public static void Executar()
        {
            int i;
            int j;
            float soma;

            string[] Nomes = new string[2];
            float[,] Notas = new float[2, 3];

            Console.WriteLine("\n---BOLETIM---");

            for (i = 0; i < 2; i++)
            {
                Console.WriteLine($"\nDigite o nome do aluno {i + 1}: ");
                Nomes[i] = Console.ReadLine();


                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine($"\nDigite a nota {j + 1} de {Nomes[i]}");
                    Notas[i, j] = float.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < 2; i++)
            {
                Console.WriteLine($"\nNotas do aluno {Nomes[i]}: ");
                Console.WriteLine("Soma das notas: ");

                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Nota {j + 1}: {Notas[i, j]}");



                }
            }

            


        }
    }
}