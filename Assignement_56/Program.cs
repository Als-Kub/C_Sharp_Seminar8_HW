// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
//находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка


Console.Clear();

Console.Write("Enter a size of a rectangular array: ");
int sizeOfArray = int.Parse(Console.ReadLine()!);

int[,] array = new int[sizeOfArray, sizeOfArray];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int[] minRowSum = FindMinRowSum(array);

Console.Write($"Row #: {FindMinRowNumber(minRowSum) + 1}");



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    Random generator = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = generator.Next(0, 10);
        }
    }
}

int[] FindMinRowSum(int[,] array)
{
    int minSum = 0;
    int[] minRowSum = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            minSum += array[i, j];
            minRowSum[i] = minSum;
        }
        minSum = 0;
    }
    
    return minRowSum;
}

int FindMinRowNumber(int[] minRowSum)
{
    int minRowindex = 0;
    for (int i = 0; i < minRowSum.Length; i++)
    {
        if (minRowSum[i] < minRowSum[minRowindex])
        {
            minRowindex = i;
        }
    }
    return minRowindex;
}

