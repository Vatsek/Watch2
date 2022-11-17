// Задача 49: Задайте двумерный массив. Найдите элементы, у которых 
// оба индекса нечётные, и замените эти элементы на их квадраты.

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];

Fill2DArrayRandomNumbers(numbers);
Write2DArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if(i % 2 != 0 && j % 2 != 0)
            numbers[i, j] *= numbers[i, j];
    }
}
Console.WriteLine();
Write2DArray(numbers);

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


// for (int i = 1; i < numbers.GetLength(0); i+=2)
// {
//     for (int j = 1; j < numbers.GetLength(1); j+=2)
//     {
//         numbers[i, j] *= numbers[i, j];
//     }
// }

