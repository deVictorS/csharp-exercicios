// Desenvolva uma classe que, por meio de métodos, realize as seguintes operações dentro de um vetor de números inteiros:
// Criação de um vetor de dimensões fornecidas pelo usuário segundo um método construtor. Se não for fornecido pelo usuário o tamanho deverá ser,
// por padrão, 10;
// Criação de um vetor de dimensões fornecidas pelo usuário e inserção automática de valores aleatórios nesse vetor, segundo um método construtor,
// fornecidos os limites mínimo e máximo; Se não fornecido o tamanho do vetor pelo usuário o tamanho deverá ser 10;
// Listagem de todos os elementos do vetor;
// Inserção de um valor em uma dada posição do vetor;
// Recuperação de um valor indicado por uma posição fornecida pelo usuário;
// Localização do Maior e do Menor número dentro do vetor.
// Teste as rotinas no programa principal (main).

using System;

namespace exercicios
{
    public class exercicio8
    {
        class Vetor
        {
            public int numero;
        }

        class Gerenciar
        {
            private Vetor[] vet;
            private Random random = new Random();
            private int tamanho;
            private int min;
            private int max;
            private int posicao;
            private int maior;
            private int menor;

            private int novoValor;

            public void Tamanho()
            {
                Console.WriteLine("\nDefina o tamanho do vetor: ");
                tamanho = int.Parse(Console.ReadLine());

                vet = new Vetor[tamanho];
            }

            public void Valores()
            {
                Console.WriteLine("\nDigite o elemento mínimo do vetor: ");
                min = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o elemento máximo do vetor: ");
                max = int.Parse(Console.ReadLine());

                Preencher(tamanho, min, max);
            }

            public void Preencher(int tamanho, int min, int max)
            {
                for (int i = 0; i < tamanho; i++)
                {
                    vet[i] = new Vetor();
                    vet[i].numero = random.Next(min, max + 1);
                }
            }

            public void Listar()
            {
                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine($"\nEsses é o elemento {i + 1} do vetor: {vet[i].numero}");
                }
            }

            public void InserirElemento()
            {
                Console.WriteLine("\nDigite a posição do vetor: ");
                posicao = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o novo valor do elemento: ");
                novoValor = int.Parse(Console.ReadLine());

                vet[posicao - 1].numero = novoValor;

                Console.WriteLine($"Elemento da posição {posicao} atualizado {vet[posicao].numero}");
            }

            public void Pesquisar()
            {
                Console.WriteLine("\nDigite a posição do vetor: ");
                int posicao = int.Parse(Console.ReadLine());
                Console.WriteLine($"Este é o elemento da posição {posicao}: {vet[posicao - 1].numero}");
            }

            public void Picos()
            {
                maior = vet[0].numero;
                menor = vet[0].numero;

                for (int i = 1; i < tamanho; i++)
                {

                    if (vet[i].numero > maior)
                    {
                        maior = vet[i].numero;
                    }

                    if (vet[i].numero < menor)
                    {
                        menor = vet[i].numero;
                    }
                }

                Console.WriteLine($"\nMaior elemento do vetor: {maior}");
                Console.WriteLine($"Menor elemento do vetor: {menor}");
            }
        }

        public static void Executar()
        {
            Gerenciar G = new Gerenciar();

            string opcao;

            do
            {
                Console.WriteLine("\n---VETORES---");
                Console.WriteLine("1 - DEFINIR TAMANHO");
                Console.WriteLine("2 - PREENCHER VETOR");
                Console.WriteLine("3 - INSERIR UM ELEMENTO");
                Console.WriteLine("4 - PROCURAR UM ELEMENTO");
                Console.WriteLine("5 - LISTAR VETOR");
                Console.WriteLine("6 - MOSTRAR OS PICOS");
                Console.WriteLine("0 - SAIR");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        G.Tamanho();
                        break;

                    case "2":
                        G.Valores();
                        break;

                    case "3":
                        G.InserirElemento();
                        break;

                    case "4":
                        G.Pesquisar();
                        break;

                    case "5":
                        G.Listar();
                        break;

                    case "6":
                        G.Picos();
                        break;

                    case "0":
                        Console.WriteLine("\n---ENCERRANDO O PROGRAMA---");
                        break;
                }

            } while (opcao != "0");

            Console.WriteLine("\n---PROGRAMA FINALIZADO---");
        }
    }
}
