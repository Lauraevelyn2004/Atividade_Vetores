using System;
using Array;
internal class Exercicio_9

{
    private static void Main()
    {
        int n, num, cont = 0;
        Console.WriteLine("qual o tamanho do vetor?");
        n = int.Parse(Console.ReadLine());
        int[] vet = new int[n];
        BibliotecaArray.geraVetor(vet);
        Console.WriteLine("qual o numero a ser verificado?");
        num = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (vet[i] == num)
            {
                Console.WriteLine($"o numero {num} apareceu na posição {i}");
                cont++;
            }
        }
        Console.WriteLine($"o numero {num} apareceu {cont} vezes!");
    }
}