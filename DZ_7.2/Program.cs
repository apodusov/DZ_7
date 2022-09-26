// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



Console.WriteLine("Введите количество строк m");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов n");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];

FillArray(array);

PrintArray(array);

Console.WriteLine("Введите номер строки i");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер столбца j");
int b = int.Parse(Console.ReadLine()!);

FindElement(array);


void FillArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);

        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (a == i + 1 && b == j + 1) Console.WriteLine($"Элемент с номером [{i + 1},{j + 1}] = {array[i, j]}");

        }
    }
    if (a > m || b > n) Console.WriteLine("такого числа в массиве нет");
}