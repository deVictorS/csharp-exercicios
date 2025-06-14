// Faça um programa que defina de forma completa uma classe de nome “Veículo” com os atributos
//  “Nome”, “Marca”, “Ano de Fabricação” e “Placa”. Crie métodos capazes de ler os dados de um veículo e mostrar uma listagem de todos os veículos.
// Cadastre em um vetor 30 veículos.

using System;

namespace exercicios
{
    public class exercicio6
    {
        class Veiculos
        {
            public string nome;
            public string marca;
            public string ano;
            public string placa;


            public void Cadastro()
            {
                Console.WriteLine("Nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Marca: ");
                marca = Console.ReadLine();

                Console.WriteLine("Ano: ");
                ano = Console.ReadLine();

                Console.WriteLine("Placa: ");
                placa = Console.ReadLine();

            }

            public void Listar(int i)
            {
                Console.WriteLine($"\n{i + 1}º veículo: ");
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Marca: {marca}");
                Console.WriteLine($"Ano: {ano}");
                Console.WriteLine($"Placa: {placa}");
            }

        }
        public static void Executar()
        {
            Veiculos[] Vei = new Veiculos[2];
            int quantidade = 0;

            string opcao;

            do
            {
                Console.WriteLine("\n---CADASTRO DE VEÍCULOS---");
                Console.WriteLine("1 - CADASTRO");
                Console.WriteLine("2 - LISTAGEM");
                Console.WriteLine("0 - SAIR");

                opcao = Console.ReadLine();

                switch (opcao)
                {

                    case "1":

                        Vei[quantidade] = new Veiculos();
                        Console.WriteLine($"Cadastro do {quantidade + 1}º veículo: ");
                        Vei[quantidade].Cadastro();
                        quantidade++;
                        break;

                    case "2":
                        Console.WriteLine("\n--- LISTA DE VEÍCULOS ----");
                        for (int i = 0; i < quantidade; i++)
                        {
                            Vei[i].Listar(i);
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