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
   
            ExibirTexto(filePath);

            int totalPalavras = Contador(filePath);

            Console.WriteLine("Número total de palavras: " + totalPalavras);

            Console.ReadKey();
        }

     
        static void ExibirTexto(string filePath)
        { 
            string[] linhas = File.ReadAllLines(filePath);

            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
                
            }
            Console.ReadKey();
            Console.Clear();
        }

        static int Contador(string filePath)
        {
            string conteudo = File.ReadAllText(filePath);

            string[] palavras = conteudo.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
           
            return palavras.Length;

        }
    }
}
