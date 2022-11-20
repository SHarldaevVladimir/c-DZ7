// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное.
//  Вывести на экран красивенько таблицей.
//   Перемешать случайным образом элементы массива,
//    причем чтобы каждый ГАРАНТИРОВАННО переместился на другое место и выполнить это за m*n / 2 итераций.
//     И после этого чтоб каждый уже перемещенный элемент не трогали.
// То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.
decimal fRec = 0;
int[,] array = createArray();
printArray(array);
Console.WriteLine();

mixArray(array);
printArray(array);
Console.WriteLine();
Console.Write("Количество итераций - " + fRec);


int[,] createArray()
{
    Console.Write("Введите количество строк: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов: ");
    int n = int.Parse(Console.ReadLine()!);
    int[,] array = new int[m, n];

    Random random = new Random();
    for (var i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
    return array;
}

void printArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);

            if (j != input.GetLength(1) - 1)
                Console.Write(" ");
            if (input[i, j] < 10) Console.Write(" ");

        }
        Console.WriteLine();
    }
}
int[,] mixArray(int[,] data)
{
    int rows = data.GetLength(0);
    int columns = data.GetLength(1);
    if (rows == 0) rows =rows /2;
    else columns = columns/2;
    int count = 1;
    for (int i = 0; i < rows; i++)
    {
        int count2 = 1;
        for (int j = 0; j < columns; j++)
        {
            fRec++;
            int k = data.GetLength(0) - count;
            int m = data.GetLength(1) - count2;
            var temp = data[k, m];
            data[k, m] = data[i, j];
            data[i, j] = temp;
            count2++;
        }
        count++;
    }
    
    return data;
}

