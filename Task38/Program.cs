// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] mass (int x)
{
    int[] a = new int[x];
    Console.Write("[");
    for(int i = 0; i < a.Length; i++)
    {   
        a[i] = new Random().Next(0, 1000);
        Console.Write($"{a[i]}, ");
    }
    Console.Write("] -> ");
    return a;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] a = mass(size);
int max = a[0];
int min = a[0];
int res = 0;
for (int i = 1; i < size; i++)
{
    if (a[i] > max) max = a[i];
    if (a[i] < min) min = a[i];
}
Console.Write(res = max - min);