// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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



int[,] arr1 = Random2Array(2, 2);
int[,] arr2 = Random2Array(2, 2);


int[,] MultiMatrix(int[,] arr1 , int [,]arr2)
{
    int[,] multiArr = new int[arr1.GetLength(0),arr2.GetLength(1)];
    int tmp = 0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            tmp = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                tmp += arr1[i, k] * arr2[k, j];
            }
            multiArr[i, j] = tmp;
        }
    }
    return multiArr;
}

Print2Array(arr1);

Print2Array(arr2);

Print2Array(MultiMatrix(arr1,arr2));

