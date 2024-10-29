using System;
using Array;
internal class Exercicio_3
{
    private static int menorVetor(int[] vetor)
    {

        int menor = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        return menor;
    }

    private static void Main()
    {
        int n;
        Console.WriteLine("digite o tamanho de vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];
        BibliotecaArray.leiaVetor(meuVetor);
        Console.Write("Vetor gerado");
        BibliotecaArray.mostreVetor(meuVetor);
        Console.Write($"\n o menor vetor :|{menorVetor(meuVetor)}| ");
        Console.ReadKey();
    }
}
