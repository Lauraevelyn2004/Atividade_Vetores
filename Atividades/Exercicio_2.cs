using System;
using Array;
internal class Exercicio_2
{
     private  static int maiorVetor(int[] vetor)
     {

            int maior = vetor[0];

            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
            }

            return maior;
     }

      private  static void Main()
      {
            int n;
            Console.WriteLine("digite o tamanho de vetor: ");
            n = int.Parse(Console.ReadLine());
            int[] meuVetor = new int[n];
            BibliotecaArray.leiaVetor(meuVetor);
            Console.Write("Vetor gerado");
            BibliotecaArray.mostreVetor(meuVetor);
            Console.Write($"\n o maior vetor :|{maiorVetor(meuVetor)}| ");
            Console.ReadKey();
      }
}
