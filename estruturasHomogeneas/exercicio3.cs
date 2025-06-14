// 3) Faça um programa que possa cadastrar o nome e o telefone de 30 funcionários de uma empresa. Depois dos dados serem informados 
// o programa deve conter uma opção que sirva para o usuário pesquisar sequencialmente um funcionário e encontrar o seu telefone.
using System;

namespace exercicios
{
    public class exercicio3
    {
        public static void Executar()
        {
            int i;
            int j;

            string[] Funcionario = new string[2];
            int[] Telefone = new int[2];

            string option;

            do
            {
                Console.WriteLine("\n---LISTA DE FUNCIONÁRIOS---");
                Console.WriteLine("1 - CADASTRAR FUNCIONÁRIO");
                Console.WriteLine("2 - BUSCAR POR FUNCIONÁRIO");
                Console.WriteLine("0 - SAIR");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        for (i = 0; i < 2; i++)
                        {
                            Console.WriteLine($"Digite o nome do funcionário {i + 1}: ");
                            Funcionario[i] = Console.ReadLine();

                            Console.WriteLine($"Digite o número do funcionário {Funcionario[i]}");
                            Telefone[i] = int.Parse(Console.ReadLine());

                        }
                        break;

                    case "2":

                        string busca;

                        do
                        {

                            Console.WriteLine("Digite o nome do funcionário ou 0 para sair: ");
                            busca = Console.ReadLine();
                            bool encontrado = false;

                            for (i = 0; i < 2; i++)
                            {
                                if (Funcionario[i].Equals(busca, StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine($"\nFuncionário {Funcionario[i]} encontrado. Telefone: {Telefone[i]}");
                                    encontrado = true;
                                    break;
                                }
                            }
                            break;

                        }
                        while (busca != "0");
                        break;

                    case "0":
                        Console.WriteLine("\nFINALIZANDO O PROGRAMA. . .");
                        break;

                }


            }
            while (option != "0");
            Console.WriteLine("PROGRAMA ENCERRADO.");


        }
    }
}