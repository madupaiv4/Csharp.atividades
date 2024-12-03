using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace teste
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "notas.txt";
            string opcao;

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Adicionar nota de aluno");
                Console.WriteLine("2. Exibir todas as notas");
                Console.WriteLine("3. Buscar nota de aluno");
                Console.WriteLine("4. Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarNota(filePath);
                        break;

                    case "2":
                        ExibirNotas(filePath);
                        break;

                    case "3":
                        BuscarNota(filePath);
                        break;

                    case "4":
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != "4");
        }


        static void AdicionarNota(string filePath)
        {
            Console.WriteLine("\n Adicionando notas... \n ");
            Console.WriteLine("Digite o nome do(a) aluno(a): ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a nota do(a) aluno(a): ");
            string nota = Console.ReadLine();


            using (StreamWriter writer = new StreamWriter(filePath, true))
            {

                writer.WriteLine($"{nome}: {nota}");

            }

            Console.WriteLine("\nDados adicionados com sucesso!");
            Console.ReadKey();
            Console.Clear();
        }

        static void ExibirNotas (string filePath)
        {
            Console.WriteLine("\n Notas do sistema \n ");
            if (File.Exists(filePath))
            {
                string[] linhas = File.ReadAllLines(filePath);

                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            else
            {
                Console.WriteLine("Arquivo não encontrado");
            }
            Console.ReadKey();
            Console.Clear();

        }

        static void BuscarNota (string filePath)
        {
            Console.WriteLine("\n Buscando alunos... \n ");
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            bool encontrado = false;

            if ( File.Exists(filePath))
            {
                using(StreamReader reader = new StreamReader(filePath))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        if (linha.StartsWith(nome + ":"))
                        {
                            Console.WriteLine(linha);
                            encontrado = true;
                            break;
                        }
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("Aluno não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Nenhuma nota registrada.");
            }
            Console.ReadKey();
            Console.Clear();
        }





    } 

}
