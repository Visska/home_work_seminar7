/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

int[, ] CreateMatr()
{
    int rowNumb = new Random().Next(2, 5);
    int colNumb = new Random().Next(2, 5);
    int[, ] matrix = new int[rowNumb, colNumb];
    for (int i = 0; i < rowNumb; i++)
    {
        for (int j = 0; j < colNumb; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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

int FindRowElemnt (int numberElement, int cow)
{
    int numberRow = 0;
    while (numberElement > 0)
    {
        numberElement = numberElement - cow;
        numberRow++;
    }
    return numberRow;
}

void CheckAndPrintElement(int numberElement, int[,] array)
{
    int row = array.GetLength(0);
    int cow = array.GetLength(1);
    if (numberElement <= row * cow)
    {
        int rowElement = FindRowElemnt(numberElement, cow);
        int cowElement = numberElement % cow;
        if (cowElement == 0) 
        {
            cowElement = cow;
        }
        Console.WriteLine($"Элемент с номером {numberElement} это {array[rowElement-1,cowElement-1]} {rowElement},{cowElement};  количество строк -> {row}, количество столбцов -> {cow}");
    }
    else{
        Console.WriteLine("Элемента с таким номером неn");
    }
}

Console.Clear();
int[,] array = CreateMatr();
Console.WriteLine("Задан двумерный массив: ");
printMatr(array);
Console.Write("Введите номер элемента: ");
int numberElement = Convert.ToInt32(Console.ReadLine());
CheckAndPrintElement(numberElement, array);