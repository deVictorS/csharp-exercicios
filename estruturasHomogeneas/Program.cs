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
                Console.WriteLine("\n---MENU DE EXERCÍCIOS---");
                Console.WriteLine("---ESTRUTURAS  HOMOGENEAS---");
                Console.WriteLine("1 - EXERCÍCIO 1");
                Console.WriteLine("2 - EXERCÍCIO 2");
                Console.WriteLine("3 - EXERCÍCIO 3");
                Console.WriteLine("---ESTRUTURAS  HETEROGÊNEAS---");
                Console.WriteLine("4 - EXERCÍCIO 4");
                Console.WriteLine("---CLASSES E OBJETOS---");
                Console.WriteLine("5 - EXERCÍCIO 5");
                Console.WriteLine("---ATRIBUTOS, CLASSES E MÉTODOS---");
                Console.WriteLine("5 - EXERCÍCIO 6");
                Console.WriteLine("---VISIBILIDADE E ACESSIBILIDADE---");
                Console.WriteLine("7 - EXERCÍCIO 7");
                Console.WriteLine("---CONSTRUTORES DE CLASSE---");
                Console.WriteLine("8 - EXERCÍCIO 8");
                Console.WriteLine("\n0 - SAIR");

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

                    case "3":
                        Console.WriteLine("---EXECUTANDO EXERCÍCIO 3---");
                        exercicio3.Executar();
                        break;

                    case "4":
                        Console.WriteLine("---EXECUTANDO EXERCÍCIO 4---");
                        exercicio4.Executar();
                        break;

                    case "5":
                        Console.WriteLine("---EXECUTANDO EXERCÍCIO 5---");
                        exercicio5.Executar();
                        break;

                    case "6":
                        Console.WriteLine("---EXECUTANDO EXERCÍCIO 6---");
                        exercicio6.Executar();
                        break;

                    // case "7":
                    //     Console.WriteLine("---EXECUTANDO EXERCÍCIO 7---");
                    //     exercicio7.Executar();
                    //     break;    

                    // case "8":
                    //     Console.WriteLine("---EXECUTANDO EXERCÍCIO 8---");
                    //     exercicio8.Executar();
                    //     break;    
       
   

                    case "0":
                        Console.WriteLine("\n---ENCERRANDO O PROGRAMA---");
                        break;

                }

            }
                while (opcao != "0");
                Console.WriteLine("\n---PROGRAMA FINALIZADO---");
        }

    }
}
