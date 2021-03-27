using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantidade de linhas: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++) {
                Console.Write($"Digite {n} números: ");
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }
            Console.Write("Digite um número para pesquisa: ");
            int pesquisa = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                   if (pesquisa == matriz[i,j]) {
                        Console.WriteLine($"Posição: {i},{j}:");
                        
                        int p = j - 1;
                        if (p >= 0) {
                            Console.WriteLine($"Esquerda: {matriz[i, p]}");
                        }
                        p = j + 1;
                        if (p < n) {
                            Console.WriteLine($"Direita: {matriz[i, p]}");
                        }

                        p = i - 1;
                        if (p >= 0) {
                            Console.WriteLine($"Acima: {matriz[p, j]}");
                        }
                        p = i + 1;
                        if (p < m) {
                            Console.WriteLine($"Abaixo: {matriz[p, j]}");
                        }
                    }
                }
            }
        }
    }
}
