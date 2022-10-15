// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();

Console.WriteLine("Enter number of rows in the matrix A: ");
int rowNumbersA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number of columns in the matrix A: ");
int columnNumbersA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number of rows in the matrix B: ");
int rowNumbersB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number of columns in the matrix B: ");
int columnNumbersB = int.Parse(Console.ReadLine()!);


int[,] matrixA = new int[rowNumbersA, columnNumbersA];

int[,] matrixB = new int[rowNumbersB, columnNumbersB];


bool MatrixMultiplyPossible(int rowNumbers, int columnNumbers)
{
    if (columnNumbersA == rowNumbersB)
        return true;
    else
        return false;
}


if (MatrixMultiplyPossible(rowNumbersA, rowNumbersB))
{

    FillArray(matrixA);

    FillArray(matrixB);

    int[,] martixMultiplyAtoB = CalcMultiplyMatrix(matrixA, matrixB);

    Console.WriteLine("Matrix A:");
    PrintMatrix(matrixA);
    Console.WriteLine();

    Console.WriteLine("Matrix B:");
    PrintMatrix(matrixB);
    Console.WriteLine();

    Console.WriteLine("Matrix AxB:");
    PrintMatrix(martixMultiplyAtoB);
}

else

    Console.WriteLine("It is not possibe to multiply these two matrices");



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

int[,] CalcMultiplyMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] multiplyMatix = new int[rowNumbersA, columnNumbersB];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                multiplyMatix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return multiplyMatix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
