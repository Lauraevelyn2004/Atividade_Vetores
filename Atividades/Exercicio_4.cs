using System;
using Array;
internal class Exercicio_4
{
    private static int imparVetor(int[] vetor)
    {

        int impar = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] %2 != 0 )
            {
                impar++;
            }
        }
        return impar;

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
        Console.Write($"\n a quantidade de vetor impar: {imparVetor(meuVetor)} ");
        Console.ReadKey();
    }
}
