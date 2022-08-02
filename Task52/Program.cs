/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/

int[, ] CreateMatr()
{
    int[, ] matrix = new int[4, 4];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
    return matrix;
}

void printGreen(int number)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{number}\t");
    Console.ResetColor();
}

void printMatr(int[, ] array)
{
    Console.Write(" \t");
    for (var i = 0; i < array.GetLength(1); i++)
    {
        printGreen(i);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printGreen(i);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
            if (j < array.GetLength(1) - 1)
            {
                Console.Write("\t");
            }
        }
        Console.WriteLine();
    }
}

void AvgElementCow(int[, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double avgElement = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            avgElement = avgElement + array[j, i];
        }
        Console.WriteLine(i + 1 + " столбец: " + avgElement/array.GetLength(0));
    }
}

Console.Clear();
int[, ] matrixNumber = CreateMatr();
printMatr(matrixNumber);
AvgElementCow(matrixNumber);