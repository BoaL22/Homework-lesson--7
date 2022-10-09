
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк массива: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a,b];


void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}, ");
        }
        Console.WriteLine();
    }
}

void NumbersArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 100);
        }
    }
}

void Average (int[,] array)
{    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double avarage = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            avarage = avarage + array[j, i];
        }
        avarage = avarage / array.GetLength(0);
        Console.Write($"Среднее арифметическое {i + 1} столбца = {avarage}");
        Console.WriteLine();
    }
}

NumbersArray (array);
PrintArray (array);
Average (array);