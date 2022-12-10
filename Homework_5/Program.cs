// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void Print2Array(int[,] arr) // Вывод двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(($"{arr[i, j]} "));
        }
        Console.WriteLine();
    }
}

Console.Write("Введите массив размера n x n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n, n];
int rows = 0;
int columns = -1;
int value = 1;
int driveRows = 0; // движение по строке (-1 = вверх; 1 = вниз)
int driveColumns = 1; // движение по столбцам  (-1 = влево; 1 = вправо)

while (value <= Math.Pow(n, 2))
{
    if (rows + driveRows >= 0      
        && rows + driveRows < n
            && columns + driveColumns >= 0
                && columns + driveColumns < n  // проверка условия на выход из за границ массива
                    && arr[rows + driveRows, columns + driveColumns] == 0) // проверка условия на пустую ячейку
    {
        rows += driveRows;
        columns += driveColumns;
        arr[rows, columns] = value;
        value += 1;
    }
    else if (driveColumns == 1)
    {
        driveColumns = 0;
        driveRows = 1;
    }
    else if (driveRows == 1)
    {
        driveRows = 0;
        driveColumns = -1;
    }
    else if (driveColumns == -1)
    {
        driveColumns = 0;
        driveRows = -1;
    }
    else if (driveRows == -1)
    {
        driveRows = 0;
        driveColumns = 1;
    }
}

Print2Array(arr);
