using System;

class Exercicio_12

{
    static void Main()
    {
        float[] notas = new float[5];
        Console.WriteLine("Digite cinco notas separadas por espaço:");

        string[] entradas = Console.ReadLine().Split(' ');

        for (int i = 0; i < 5; i++)
        {
            notas[i] = float.Parse(entradas[i].Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
        }

        for (int i = 0; i < notas.Length - 1; i++)
        {
            for (int j = 0; j < notas.Length - 1 - i; j++)
            {
                if (notas[j] > notas[j + 1])
                {
                    float temp = notas[j];
                    notas[j] = notas[j + 1];
                    notas[j + 1] = temp;
                }
            }
        }

        float notaFinal = notas[1] + notas[2] + notas[3];
        Console.WriteLine($"A nota final é: {notaFinal:F1}");
    }
}
