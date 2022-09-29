// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A = new Random().Next(1, 10);
int B = new Random().Next(1, 10);

Console.Write($"{A}, {B} -> ");

int count = 2;
int res = A;
if (count > B) Console.Write(res);
else
{
    while (count <= B)
    {
        res = res * A;
        count ++;
    }
    Console.Write(res);
}
