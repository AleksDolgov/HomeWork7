/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] IniMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] matrix)
{
    double summ = 0;
    double mean = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ = summ + matrix[i, j];
        }
        mean = summ / matrix.GetLength(1);
        Console.WriteLine($"Среднее арифметическое {i} строки равно {mean}");
        summ = 0;
    }
}

Console.WriteLine("Введите число строк:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов:");
int n = int.Parse(Console.ReadLine());

int[,] matrix = IniMatrix(m, n);

Console.WriteLine($"Матрица размером {m}x{n}:");

PrintMatrix(matrix);

ArithmeticMean(matrix);

