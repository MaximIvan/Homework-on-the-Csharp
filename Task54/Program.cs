// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Massive = new int [m,n];
FillMass(Massive);
PrintMass(Massive);
Console.WriteLine();
//int[,] SortMassive(int[,] Massive)
{
    for (int i = 0; i < Massive.GetLength(0); i++)
    {
        for (int j = 0; j < Massive.GetLength(1); j++)
        {
            for (int k = j + 1; k < Massive.GetLength(1); k++)
            {
                if (Massive[i, j] < Massive[i, k])
                {
                    int temp = Massive[i, j];
                    Massive[i, j] = Massive[i, k];
                    Massive[i, k] = temp;
                }
            }
            Console.Write(Massive[i, j] + " ");
        }
    Console.WriteLine();
    }
}
    
