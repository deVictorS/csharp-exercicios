// 3) Faça um programa que possa cadastrar o nome e o telefone de 30 funcionários de uma empresa. Depois dos dados serem informados 
// o programa deve conter uma opção que sirva para o usuário pesquisar sequencialmente um funcionário e encontrar o seu telefone.
using System;

namespace exercicios
{
    public class exercicio7
    {
        public static void Executar()
        {
            

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
                        
                        break;

                    case "2":


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