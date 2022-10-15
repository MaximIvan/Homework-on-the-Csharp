// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

void FillMass(int[,] array)
{
    int i = 0;
    while (i < array.GetLength(0))
    {
        int j = 0;
        while (j < array.GetLength(1)) 
        {
            array[i,j] = new Random().Next(0, 15);
            j++;
        }
    i++;
    }
}
void PrintMass(int[,] collection)
{
    int i = 0;
    while (i < collection.GetLength(0))
    {
        int j = 0;
        while (j < collection.GetLength(1))
        {
            Console.Write($"{collection[i, j]} ");
            j++;
        }
    Console.WriteLine();
    i++;
    } 
}

void MinSumRow (int[,] matrix)
{
    int[] SumRow = new int[matrix.GetLength(0)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRow[i] += matrix[i, j];
        }
    }
    int temp = SumRow[0];
    int NumberRow = 0;
    for (int i = 0; i < SumRow.Length; i++)
    {
        if (SumRow[i] < temp)
        {
            temp = SumRow[i];
            NumberRow = i + 1;
        }
    }   
    Console.WriteLine($"Минимальная сумма элементов в строке: {NumberRow += 1}");
    Console.WriteLine("Минимальная сумма элементов = " + temp);
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Massive = new int [m,n];
FillMass(Massive);
PrintMass(Massive);
Console.WriteLine();
MinSumRow(Massive);

