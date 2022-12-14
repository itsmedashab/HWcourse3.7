// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

int m, n;
Console.Write($"Введите количество строк в массиве: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите количество столбцов в массиве: ");
int.TryParse(Console.ReadLine()!, out n);

double[,] array = new double[m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(100) / 10.0;
        Console.Write($"{array[i, j]}     ");
    }
    Console.Write($"\n");
}
Console.Write($"\n");