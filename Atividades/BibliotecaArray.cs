using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class BibliotecaArray
    {
        public static void leiaVetor(int[] vetor)
        {//função ler vetor

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"[{i}]:");
                vetor[i] = int.Parse(Console.ReadLine());
            }

        }//fim função ler vetor
        public static void leiaVetor(double[] vetor)
        {//função ler vetor double

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"[{i}]:");
                vetor[i] = double.Parse(Console.ReadLine());
            }

        }//fim função ler vetor double

        public static void geraVetor(int[] vetor)
        {//gerador aleatório
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100);
            }
        }//fim função ler vetor

        public static void geraVetor(double[] vetor)
        {//gerador aleatório double
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100) + random.NextDouble();
            }
        }//fim função ler vetor double

        public static void mostreVetor(int[] vetor)
        {//função mostrar o vetor
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"|{vetor[i]}");

            }

        }//fim função mostrar o vetor

        public static void mostreVetor(double[] vetor)
        {//função mostrar o vetor double
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"|{vetor[i]:F2}");

            }

        }//fim função mostrar o vetor double
    }
}