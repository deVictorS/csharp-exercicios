// Faça um programa com um menu de opções que possa cadastrar o nome, o preço unitário, a quantidade em estoque e a data de validade (mês e ano) de 30 produtos. 
// Depois dos dados serem informados, o programa deve conter uma opção que, por meio de uma função, possa listar os produtos acima de um determinado valor fornecido pelo usuário.
// Repita o programa anterior, agora considerando que a data de validade é de um tipo estruturado e formado pelos campos mês e ano.

using System;

namespace exercicios
{
    public class exercicio4
    {
        struct Produtos
        {
            public string nome;
            public string preco;
            public string qtde;
            public Validade data;

        }

        struct Validade
        {
            public string dia;
            public string mes;
            public string ano;
        }

        public static void Executar()
        {
            Produtos[] xProd = new Produtos[2];

            string opcao;
            

            do
            {
                Console.WriteLine("\n---PRODUTOS---");
                Console.WriteLine("1 - CADASTRAR PRODUTO");
                Console.WriteLine("2 - PROCURAR PRODUTO PELO VALOR");
                Console.WriteLine("0 - SAIR");

                opcao = Console.ReadLine();

                switch (opcao)
                {

                    case "1":

                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine("\nNome do produto: ");
                            xProd[i].nome = Console.ReadLine();

                            Console.WriteLine("Preço: ");
                            xProd[i].preco = Console.ReadLine();

                            Console.WriteLine("Quantidade: ");
                            xProd[i].qtde = Console.ReadLine();

                            Console.WriteLine("Data de validade - dia: ");
                            xProd[i].data.dia = Console.ReadLine();

                            Console.WriteLine("Data de validade - mês: ");
                            xProd[i].data.mes = Console.ReadLine();

                            Console.WriteLine("Data de validade - ano: ");
                            xProd[i].data.ano = Console.ReadLine();

                         
                        }

                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine($"\nProduto {i + 1}:");
                            Console.WriteLine($"Nome: {xProd[i].nome}");
                            Console.WriteLine($"Preço: R${xProd[i].preco}");
                            Console.WriteLine($"Quantidade {xProd[i].qtde}");
                            Console.WriteLine($"Data de validade: {xProd[i].data.dia}/{xProd[i].data.mes}/{xProd[i].data.ano}");
                        }

                        break;

                    case "2":
                        Console.WriteLine("Digite o preço do produto: ");
                        string precoBusca = Console.ReadLine();
                        bool encontrado = false;

                        for (int i = 0; i < 2; i++)
                        {
                            if (xProd[i].preco == precoBusca)
                            {
                                Console.WriteLine($"\nProdutos encontrados: {xProd[i].nome} - Valor: R${xProd[i].preco} - Quantidade: {xProd[i].qtde} - Data de validade: {xProd[i].data.dia}/{xProd[i].data.mes}/{xProd[i].data.ano}");
                                encontrado = true;
                            }
                        }
                        break;



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