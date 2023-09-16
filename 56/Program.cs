//Задача 56:Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int column = InputNum("Введите размеры столбцов массива: ");
int row = InputNum("Введите размеры строк массива: ");
int[,] table = new int[column, row];
if (column == row)
    Console.WriteLine("Задан не прямоугольный массив"); // Не понимаю как остановить программу на этом шаге.

void NRMSE(int[,] array)  // NRMSE = полное имя метода NumberRowMinSumElements
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
            minRow += table[0, i];
        }
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
            if (sumRow < minRow)
            {
                minRow = sumRow;
                minSumRow = i;
            }
            sumRow = 0;
        }
        Console.Write($"Строка с минимальной суммой элементов: {minSumRow + 1}");
    }

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    }


FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NRMSE(table);