using System;
using Array;
internal class Exercicio_7

{
    private static void Main()
    {
        int n;
        Console.WriteLine("qual o tamanho dos vetores?");
        n = int.Parse(Console.ReadLine());
        int[] x = new int[n], y = new int[n], z = new int[n];
        Console.WriteLine("digite para que os vetores sejam: lidos(l) gerados(g)");
        char par;
        par = char.Parse(Console.ReadLine());
        if (char.ToUpper(par) == 'G')
        {
            BibliotecaArray.geraVetor(y); ;
            BibliotecaArray.geraVetor(x); ;
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("valor de x");
                x[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("valor de y");
                y[i] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"vetor x:|{x[i]}| \nVetor y:|{y[i]}| \n");
            z[i] = x[i] * y[i];
            Console.WriteLine($"resultado de x.y(posicao {i}):|{z[i]}| \n");
        }
    }
}
