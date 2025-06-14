// Faça um programa que possa ser usado por uma clínica para cadastrar: 30 pacientes, a data da consulta, a hora de sua realização,
// o nome de um paciente e o nome do médico que o atenderá. Depois de os dados serem informados, o programa deve conter uma opção que,
// o usuário fornecendo o nome do médico, liste toda a agenda dele.
// Considere que o atributo Data da consulta seja também estruturado, formado pelos campos Dia, Mês e Ano.

using System;

namespace exercicios
{
    public class exercicio5
    {
        class Paciente
        {
            public string medico;
            public string nome;
            public string hora;
            public Data data;
        }

        class Data
        {
            public string dia;
            public string mes;
            public string ano;
        }


        public static void Executar()
        {
            Paciente[] Pac = new Paciente[4];

            string opcao;

            do
            {
                Console.WriteLine("\n---AGENDA---");
                Console.WriteLine("1 - MARCAR CONSULTA");
                Console.WriteLine("2 - PROCURAR CONSULTA");
                Console.WriteLine("0 - SAIR");

                opcao = Console.ReadLine();

                switch (opcao)
                {

                    case "1":

                        for (int i = 0; i < 4; i++)
                        {
                            Pac[i] = new Paciente();
                            Pac[i].data = new Data();

                            Console.WriteLine("\nMédico: ");
                            Pac[i].medico = Console.ReadLine();

                            Console.WriteLine("\nPaciente: ");
                            Pac[i].nome = Console.ReadLine();

                            Console.WriteLine("\nHorário: ");
                            Pac[i].hora = Console.ReadLine();

                            Console.WriteLine("\nDia: ");
                            Pac[i].data.dia = Console.ReadLine();

                            Console.WriteLine("\nMês: ");
                            Pac[i].data.mes = Console.ReadLine();

                            Console.WriteLine("\nAno: ");
                            Pac[i].data.ano= Console.ReadLine();

                        }

                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine($"\nÍndice {i + 1}:");
                            Console.WriteLine($"Médico: {Pac[i].medico}");
                            Console.WriteLine($"Paciente: {Pac[i].nome}");
                            Console.WriteLine($"Horário: {Pac[i].hora}");
                            Console.WriteLine($"Data: {Pac[i].data.dia}/{Pac[i].data.mes}/{Pac[i].data.ano}");
                        }

                        break;

                    case "2":
                        Console.WriteLine("Digite o nome do médico: ");
                        string medicoBusca = Console.ReadLine();
                        bool encontrado = false;

                        for (int i = 0; i < 4; i++)
                        {
                            if (Pac[i].medico == medicoBusca)
                            {
                                Console.WriteLine($"\nConsultas agendadas-> Paciente {Pac[i].nome} - Horário: {Pac[i].hora} - Data: {Pac[i].data.dia}/{Pac[i].data.mes}/{Pac[i].data.ano}");
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