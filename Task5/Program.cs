// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на 
// главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
int sum = 0;

Fill2DArrayRandomNumbers(numbers);
Write2DArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (i == j)
        {
            sum += numbers[i, j];
        }
    }
}
Console.WriteLine();
Console.WriteLine(sum);

void Fill2DArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}

void Write2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         if (i == j)
//         {
//             sum += numbers[i, j];
//             break;
//         }
//     }
// }


// int rows = ReadInt("Введите количество строк: ");
// int columns = ReadInt("Введите количество столбцов: ");
// int[,] numbers = new int[rows, columns];
// int sum = 0;
// int count = 0;

// Fill2DArrayRandomNumbers(numbers);
// Write2DArray(numbers);

// if(numbers.GetLength(0) < numbers.GetLength(1))
//     count = numbers.GetLength(0);
// else
//     count = numbers.GetLength(1);

// for (int i = 0; i < count; i++)
// {
//     sum += numbers[i, i];
// }

// Console.WriteLine();
// Console.WriteLine(sum);