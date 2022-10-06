// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] mass (int x)
{
    int[] a = new int[x];
    Console.Write("[");
    for(int i = 0; i < a.Length; i++)
    {   
        a[i] = new Random().Next(-1000, 1000);
        Console.Write($"{a[i]}, ");
    }
    Console.Write("] -> ");
    return a;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] a = mass(size);
int sum = 0;
for (int i = 1; i < size; i = i + 2) sum += a[i]; // внимательнее с условием задания!!! У меня решено 
Console.Write(sum);                               // с ошибкой. нечетные позиции и индексы разные вещи!!!