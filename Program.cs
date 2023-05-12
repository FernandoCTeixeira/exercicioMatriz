using System;

namespace Exercicio1 {
    /*Fazer um programa para ler dois números inteiros M e N, e depois ler
uma matriz de M linhas por N colunas contendo números inteiros,
podendo haver repetições. Em seguida, ler um número inteiro X que
pertence à matriz. Para cada ocorrência de X, mostrar os valores à
esquerda, acima, à direita e abaixo de X, quando houver, conforme
exemplo*/
    class Program {

        static void Main(string[] args) {

            Console.Write("Enter the number of lines: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of column: ");
            int n = int.Parse(Console.ReadLine());

            int[,] vect = new int[m, n];

            Console.WriteLine();
            for (int i = 0; i < m; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    vect[i, j] = int.Parse(values[j]);
                }
            }


            Console.WriteLine();
            Console.Write("Enter the values of x: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (vect[i, j] == x) {
                        Console.WriteLine();
                        Console.WriteLine($"Position {i},{j}");
                        if (j > 0) {
                            Console.WriteLine($"Left: {vect[i, j-1]}");
                        }
                        if (j < n-1) {
                            Console.WriteLine($"Right: {vect[i, j+1]}");
                        }
                        if (i > 0) {
                            Console.WriteLine($"Up: {vect[i-1, j]}");
                        }
                        if (i < m-1) {
                            Console.WriteLine($"Down: {vect[i+1, j]}");
                        }
                    }
                }
            }
        }
    }
}
