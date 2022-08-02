/*
Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
*/

double [, ] CreateMatr(int rowNum, int colNum){
    double[, ] matrix = new double[rowNum, colNum];
    for (int i = 0; i < rowNum; i++)
    {
        for (int j = 0; j < colNum; j++)
        {
            matrix[i, j] = new Random().NextDouble() * 100;
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

void PrintMatr(double[, ] matrix)
{
    Console.Write(" \t");
    for (var i = 0; i < matrix.GetLength(1); i++)
    {
        printGreen(i);
    }
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        printGreen(i);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0:F1}", matrix[i, j]);
            if (j < matrix.GetLength(1) - 1)
            {
                Console.Write("\t");
                
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
PrintMatr(CreateMatr(numberM, numberN));