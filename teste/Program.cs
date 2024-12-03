using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            Console.WriteLine("Digite o nome do(a) aluno(a): ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a nota do(a) aluno(a): ");
            string nota = Console.ReadLine();


            using (StreamWriter writer = new StreamWriter(filePath, true))
            {

                writer.WriteLine($"{nome}: {nota}");

            }

            Console.WriteLine("Dados adicionados com sucesso!");

        }

        static void ExibirNotas (string filePath)
        {
            if(File.Exists(filePath))
            {
                string[] file = FileReadAllLines(filePath);

                foreach (string linha in file)
                {
                    Console.WriteLine(linha);
                }
            }
            else
            {
                Console.WriteLine("Arquivo não encontrado");
            }


        }

        static void BuscarNota (string filePath)
        {
            Console.Write("Digite o nome do aluno:");
            string nome = Console.ReadLine();
            bool encontrando = false;

            if ( File.Exists(filePath))
            {
                using(StreamReader reader = nem StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine) != null)
                    {
                        if (line.StartsWith(nome + ":"))
                        {
                            Console.WriteLine(line);
                            encontrado = true;
                            break;
                        }
                    }
                }
                if (!encotrado)
                {
                    Console.WriteLine("Aluno não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Nenhuma nota registrada.");
            }
           
        }





    } 

}
