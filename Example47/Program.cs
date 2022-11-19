// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] CreateArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
Random random = new Random();
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.NextDouble() * 20 - 10;
        }
        }    return array;
}

void PrintArray(double[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}",input[i, j]);

            if (j != input.GetLength(1) - 1)
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество стобцов: ");
int n = int.Parse(Console.ReadLine()!);
var array = CreateArray(m,n);
PrintArray(array);