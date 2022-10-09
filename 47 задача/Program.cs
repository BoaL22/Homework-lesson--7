// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());

double[,] Array = new double[a,b];

void PrintArray(double[,] Array)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Console.Write($"{Array[i,j]}  ");
        }
        Console.WriteLine();
    }
}
void Numbers(double[,] Array)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Array[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}



Console.WriteLine();

Numbers(Array);
Console.WriteLine();

PrintArray(Array);
Console.WriteLine();