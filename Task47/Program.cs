// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillMass(double[,] array)
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
void PrintMass(double[,] collection)
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

double[,] Massive = new double [m,n];
FillMass(Massive);
PrintMass(Massive);
