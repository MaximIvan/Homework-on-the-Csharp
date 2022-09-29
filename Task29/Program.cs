// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] massive = new int [8];
int i = 0;
while (i < massive.Length)
{
    massive[i] = new Random().Next(1, 100);
    i++;
}

int pos = 0;
int ind = 5;
while (pos < ind)
{
    Console.Write($"{massive[pos]}, ");
    pos++;
}
Console.WriteLine();

while ((pos >= ind) & (pos < massive.Length))
{
    Console.Write($"{massive[pos]}, ");
    pos++;
}


