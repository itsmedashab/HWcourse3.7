// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = new int[5,4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.Write($"\n");
}

int pos;
Console.Write($"Введите позицию искомого элемента: ");
int.TryParse(Console.ReadLine()!, out pos);

int m, n;
if (pos < array.GetLength(0) * array.GetLength(1))
{
    m = pos / array.GetLength(0);
    n = pos - m * array.GetLength(1) - 1;
    Console.Write($"Искомый элемент = {array[m,n]}\n");
}
else Console.Write($"Элемент на данной позиции не существует\n"); 