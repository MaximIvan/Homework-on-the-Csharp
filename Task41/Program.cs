// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] M (int k)
{
    int[] num = new int[k];
    for (int i = 0; i < num.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        num[i] = Convert.ToInt32(Console.ReadLine());
    }
    return num;    
}
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = M(size);
int count = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0) count++;
    Console.Write($"{num[i]}, ");
}
Console.Write($"-> {count}");