// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillMass(int[,] array)
{
    int i = 0;
    while (i < array.GetLength(0))
    {
        int j = 0;
        while (j < array.GetLength(1)) 
        {
            array[i,j] = new Random().Next(0, 11);
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

Console.Write($"Среднее арифметическое каждого столбца: ");
for (int j = 0; j < Massive.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < Massive.GetLength(0); i++)
    {
        sum += Massive[i, j];
    }
    double avg = 0;
    avg = Math.Round(sum / Massive.GetLength(0), 1);
    Console.Write("{0, 4}", $"{avg}; ");
}

