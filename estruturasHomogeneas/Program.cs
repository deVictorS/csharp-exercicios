using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            do
            {
                Console.WriteLine("---MENU DE EXERCÍCIOS---");
                Console.WriteLine("1 - EXERCÍCIO 1");
                Console.WriteLine("2 - EXERCÍCIO 2");
                Console.WriteLine("3 - EXERCÍCIO 3");
                Console.WriteLine("0 - SAIR");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("---EXECUTANDO EXERCÍCIO 1---");
                        exercicio1.Executar();
                        break;

                    case "2":
                        Console.WriteLine("---EXECUTANDO EXERCÍCIO 2---");
                        exercicio2.Executar();
                        break;

                    // case 3:
                    //     Console.WriteLine("---EXECUTANDO EXERCÍCIO 3---");
                    //     exercicio3.Executar();
                    //     break;  

                    case "0":
                        Console.WriteLine("\n---ENCERRANDO O PROGRAMA---");
                        break;

                }

            }
                            while (opcao != "0") ;
                Console.WriteLine("\n---PROGRAMA FINALIZADO---");
        }

    }
}
