// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк m");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов n");
int n = int.Parse(Console.ReadLine()!);

double[ , ] array=new double[m,n];

FillArray(array);
PrintArray(array);

void FillArray(double[ , ] array)
{
for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] =new Random().Next(-100,100) + new Random().NextDouble();
            array[i, j]  = Math.Round(array[i, j], 1);
        }
    }

}

void PrintArray(double[ , ] array)
{
    for (int i = 0; i < m; i++)  
    {
        for (int j = 0; j < n; j++)  
        {
            Console.Write($"{array[i, j], 3  } ");
        }
        Console.WriteLine();
    }
}