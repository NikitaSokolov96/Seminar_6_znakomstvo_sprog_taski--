// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 

// двумерного массива.

// // Например, задан массив:

// // 1 4 7 2

// // 5 9 2 3

// // 8 4 2 4

// // В итоге получается вот такой массив:

// // 1 2 4 7

// // 2 3 5 9

// // 2 4 4 8

void Main(string[] args)
        {
 
            var matrix = new int[3, 4];
            var rnd = new Random();
 
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(10, 99);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
 
            var arr = matrix.Cast<int>().OrderByDescending(a => a).ToArray();
 
            int c = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[j, k] = arr[c];
                    Console.Write(matrix[j, k] + " ");
                    c++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

Main(args);