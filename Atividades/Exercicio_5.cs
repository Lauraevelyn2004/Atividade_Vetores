using System;
using Array;
internal class Exercicio_5
{ //Vetor DNA
    private static void Main()
    {
        string dna;
        Console.WriteLine("entre com as bases");
        dna = Console.ReadLine();
        int n = dna.Length;
        char[] complementar = new char[n];

        for (int i = 0; i < n; i++)
        {
            switch (dna[i])
            {
                case 'T':
                    complementar[i] = 'A';
                    break;
                case 'A':
                    complementar[i] = 'T';
                    break;
                case 'C':
                    complementar[i] = 'G';
                    break;
                case 'G':
                    complementar[i] = 'C';
                    break;
            }
        }
        Console.WriteLine("***DNA***");
        Console.WriteLine(dna);
        for (int i = 0; i < n; i++)
        {
            Console.Write(complementar[i]);
        }
        Console.ReadKey();
    }

}