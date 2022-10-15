// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillMass(int[,] array)
{
    int i = 0;
    while (i < array.GetLength(0))
    {
        int j = 0;
        while (j < array.GetLength(1)) 
        {
            array[i,j] = new Random().Next(1, 10);
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

Console.Write("Введите количество строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Matrix1 = new int [m,n];

Console.Write("Введите количество строк второй матрицы: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());
int[,] Matrix2 = new int [k,l];

FillMass(Matrix1);
PrintMass(Matrix1);
Console.WriteLine();
FillMass(Matrix2);
PrintMass(Matrix2);
Console.WriteLine();

if (Matrix1.GetLength(1) == Matrix2.GetLength(0))
{
    int[,] matrix3 = new int [Matrix1.GetLength(0), Matrix2.GetLength(1)];
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int b = 0; b < Matrix1.GetLength(1); b++)
            {
                matrix3[i, j] += Matrix1[i, b] * Matrix2[b, j];
            }
            Console.Write(matrix3[i, j] + " ");
        }
    Console.WriteLine();
    }
}
else 
Console.WriteLine("Произведение этих матриц не существует");