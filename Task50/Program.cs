// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

void FillMass(int[,] array)
{
    int i = 0;
    while (i < array.GetLength(0))
    {
        int j = 0;
        while (j < array.GetLength(1)) 
        {
            array[i,j] = new Random().Next(-10, 11);
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

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Massive = new int [m,n];
FillMass(Massive);
PrintMass(Massive);
Console.Write("Введите индекс строки искомого элемента: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца искомого элемента: ");
int collums = Convert.ToInt32(Console.ReadLine());

if (rows > Massive.GetLength(0)-1 | collums > Massive.GetLength(1)-1) 
{
    Console.WriteLine($"[{rows}, {collums}] -> числа с такими индексами нет в массиве");
}
else 
{
    Console.WriteLine($"по индексам [{rows}, {collums}] массива находится число -> {Massive[rows, collums]}");
}
