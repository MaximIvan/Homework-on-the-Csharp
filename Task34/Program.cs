// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] mass (int x)
{
    int[] a = new int[x];
    Console.Write("[");
    for(int i = 0; i < a.Length; i++)
    {   
        a[i] = new Random().Next(100, 1000);
        Console.Write($"{a[i]}, ");
    }
    Console.Write("] -> ");
    return a;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] a = mass(size);
int count = 0;
for (int i = 0; i < size; i++)
{
    if (a[i] % 2 == 0) count++;
}
Console.Write(count);