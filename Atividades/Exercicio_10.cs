using System;
using Array;
class Exercicio_10

{
    static void Main()
    {
        Console.Write("Digite o número de lançamentos do dado: ");
        int n = int.Parse(Console.ReadLine());

        int[] resultados = new int[n];

        BibliotecaArray.leiaVetor(resultados);

        int[] ocorrencias = new int[6];

        foreach (int resultado in resultados)
        {
            if (resultado >= 1 && resultado <= 6)
            {
                ocorrencias[resultado - 1]++;
            }
            else
            {
                Console.WriteLine("Valor inválido detectado! Os resultados devem ser entre 1 e 6.");
                return;
            }
        }

        Console.Write("Lançamentos do dado: ");
        BibliotecaArray.mostreVetor(resultados);
        Console.WriteLine();

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Face {i + 1}: {ocorrencias[i]} ocorrência(s)");
        }
    }
}
