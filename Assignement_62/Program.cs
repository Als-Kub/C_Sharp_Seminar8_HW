// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int[,] array = new int[4, 4];

MakeSpiralArray(array);

PrintArray(array);


void MakeSpiralArray(int[,] array)
{
    int counter = 0;
    int row = 0;
    int column = 0;
    int steps = array.GetLength(0);
    int changeIndexRow = 0;
    int changeIndexColumn = 1;
    int turn = 0;

    while (counter < array.Length)
    {
        array[row, column] = counter + 1;
        counter++;
        steps--;
        if (steps == 0)
        {
            steps = array.GetLength(0) - 1 - turn/2;
            int temp = changeIndexRow;
            changeIndexRow = changeIndexColumn;
            changeIndexColumn = -temp;
            turn++;
        }

        row += changeIndexRow;
        column += changeIndexColumn;
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10)
            Console.Write(array[i, j] + "  ");
            else
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

