// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Print2Array(int[,] matrix)
{
    Console.WriteLine(String.Empty);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(($"{matrix[i, j]} "));
        }
        Console.WriteLine();
    }
    Console.WriteLine(String.Empty);
}

int[,] Random2Array(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

int SmallSumRow(int[,] arr)
{
    int[] newarr = new int[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        newarr[i] = sum;
    }

    return Array.IndexOf(newarr, newarr.Min());
}

Console.Write("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = Random2Array(m, n);

Print2Array(arr);
Console.WriteLine($"Строка с наименьшей суммой : {SmallSumRow(arr)}");
