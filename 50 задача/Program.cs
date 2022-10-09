
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// [1, 7] -> такого числа в массиве нет

Console.WriteLine ("Введите количетво строк массива");
int a = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите количетво столбцов массива");
int b = Convert.ToInt32 (Console.ReadLine());

int[,] Array = new int[a,b];

void PrintArray (int[,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]}, ");
        }
        Console.WriteLine();
    }
}

void Numbers (int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = Convert.ToInt32(new Random().Next(0, 100));
        }
    }
}

void PrintIndex (int[,] Array)
{
    Console.WriteLine("Введите строку:");
    int i = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите столбец:");
    int j = Convert.ToInt32(Console.ReadLine());

    if ( i <= Array.GetLength(0) && j <= Array.GetLength(1))    Console.WriteLine(Array[i,j]);
    else    Console.WriteLine("Такого числа в массиве нет");
}


Numbers (Array);
PrintArray (Array);
Console.WriteLine();
PrintIndex (Array);