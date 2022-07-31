// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49

Console.Clear();
Console.WriteLine("Введите кол-во строк и столбцов массива: "); int arrowSize = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента: "); int maxNumb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значчение элемента: "); int minNumb = int.Parse(Console.ReadLine());
Console.WriteLine("Массив со случайными значениями 1: ");
int[,] array = GetArray(arrowSize, maxNumb, minNumb);
int[,] GetArray(int arrowSize, int maxNumb, int minNumb)
{
    int[,] array = new int[arrowSize, arrowSize];
    for (int i = 0; i < arrowSize; i++)
    {
        for (int j = 0; j < arrowSize; j++)
        {
            array[i, j] = new Random().Next(minNumb, maxNumb + 1);
        }
    }
    return array;
}
int[,] array1 = GetArray1(arrowSize, maxNumb, minNumb);
int[,] GetArray1(int arrowSize, int maxNumb, int minNumb)
{
    int[,] array1 = new int[arrowSize, arrowSize];
    for (int i = 0; i < arrowSize; i++)
    {
        for (int j = 0; j < arrowSize; j++)
        {
            array1[i, j] = new Random().Next(minNumb, maxNumb + 1);
        }
    }
    return array1;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void PrintArray1(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void PrintSumArray(int[,] array, int[,] array1)
{
    int[,] sumArray = new int[array.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            sumArray[i,j] = array[i,j] * array1[i,j];
            Console.Write(sumArray[i,j] +"\t");
        }
        Console.WriteLine();
    }
}
PrintArray(array);
Console.WriteLine("-----------------------------------");
Console.WriteLine("Массив со случайными значениями 2: ");
PrintArray1(array1);
Console.WriteLine("-----------------------------------");
Console.WriteLine("Результат: ");
PrintSumArray(array, array1);