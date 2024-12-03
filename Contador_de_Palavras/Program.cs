using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_Palavras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "texto.txt";
   
            AdicionarTexto(filePath);
            ExibirTexto(filePath);
            Contador(filePath);
        }

        static void AdicionarTexto(string filePath)
        {
            Console.Write("Adicione o texto a ser contado: ");
            string texto = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(texto);
            }
        }
        static void ExibirTexto(string filePath)
        { 
            string[] linhas = File.ReadAllLines(filePath);

            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);

                Console.ReadKey();
                Console.Clear();
            }     
        }

        static void Contador(string filePath)
        {
            string[] palavras = filePath.Split(' ');
            int totalPalavras = palavras.Length;

            Console.WriteLine(totalPalavras);

        }
    }
}
