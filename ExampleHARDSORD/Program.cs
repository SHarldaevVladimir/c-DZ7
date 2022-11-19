// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10
// Console.Write("Введите количество строк: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество стобцов: ");
// int n = int.Parse(Console.ReadLine()!);
// int[,] array = CreateArray(m, n);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine();
// sortingArray(array);
// PrintArray(array);


// int[,] CreateArray(int rows, int columns)
// {

//     int[,] array = new int[rows, columns];
//     Random random = new Random();
//     for (var i = 0; i < rows; i++)
//     {
//         for (var j = 0; j < columns; j++)
//         {
//             array[i, j] = random.Next(0, 100);
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] input)
// {
//     for (var i = 0; i < input.GetLength(0); i++)
//     {
//         for (var j = 0; j < input.GetLength(1); j++)
//         {
//             Console.Write(input[i, j]);

//             if (j != input.GetLength(1) - 1)
//                 Console.Write(" ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] sortingArray(int[,] input)
// {
//     int t = 0;
//     for (var i = 0; i < input.GetLength(0); i++)
//     {


//         for (var j = 0; j < input.GetLength(1); j++)
//         {
//             for (var k = i + 1; k < input.GetLength(1); k++)
//             {
//                 for (var m = j + 1; m < input.GetLength(1); m++)
//                 {

//                     if (input[i, j] > input[i, m])
//                     {
//                         t = input[i, j];
//                         input[i, j] = input[i, m];
//                         input[i, m] = t;

//                     }
//                      if (input[i, j] > input[k, j])
//                     {
//                         t = input[i, j];
//                         input[i, j] = input[k, j];
//                         input[k, j] = t;

//                     }
//                 }
//             }

//         }
//     }
//     return input;

// }

