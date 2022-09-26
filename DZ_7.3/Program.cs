// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите количество строк m");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов n");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);

CalculatelArray(array);

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


void CalculatelArray(int[,] array)
{

    for (int j = 0; j < n; j++)
    {
        double sum = 0;
        for (int i = 0; i < m; i++) sum = (array[i, j] + sum);
        Console.WriteLine($"Среднее арифметическое элементов в столбце {j + 1} = {Math.Round(sum / m, 2)}");
    }
}