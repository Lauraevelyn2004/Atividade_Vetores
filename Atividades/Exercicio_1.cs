using System;
using Array;
internal class Exercicio_1
{
    private static int somaVetor(int[] vetor)
    {
        //percorrer o vetor e somar, retorne a soma
        int soma = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }

        return soma;
    }

    private static void Main()
    {
        int n;
        Console.WriteLine("digite o tamanho de vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];
        BibliotecaArray.geraVetor(meuVetor);
        Console.WriteLine("Vetor gerado");
        BibliotecaArray.mostreVetor(meuVetor);
        Console.WriteLine($"\nSoma dos vetores:{somaVetor(meuVetor)} ");
        Console.ReadKey();
    }
}