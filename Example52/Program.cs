// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {

        for (var j = 0; j < input.GetLength(1); j++)
        {

            Console.Write(input[i, j]);

            if (j != input.GetLength(1) - 1)
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}
void meanNumberColumns(int[,] input)
{
    var k = 0;
    double[] array = new double[input.GetLength(1)];
    for (var j = 0; j < input.GetLength(1); j++)

    {
        for (var i = 0; i < input.GetLength(0); i++)
        {
            array[k] = array[k] + input[i, j];
            
        }
        array[k] = Math.Round(array[k] / (input.GetLength(0)), 2);
        k++;
    }
    Console.WriteLine(string.Join(" ", array));


}
var array = CreateArray(3, 4);
PrintArray(array);
Console.WriteLine("");
meanNumberColumns(array);

// for (short i = 0; i < n; i++)
// {
//     int sum = 0;
//     for (short j = 0; j < n; j++)
//     {
//         sum += arr[j, i];
//     }
//     Console.WriteLine("Sum in {0} column: {1}", i, sum);
// }
