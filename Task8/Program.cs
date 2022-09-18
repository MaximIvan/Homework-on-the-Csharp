// Написать программу, которая на вход принимает число (N), 
// а на выходе показывает все четные числа от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int currentNum = 1;

while(currentNum <= num) 
{
    if(currentNum % 2 == 0) Console.WriteLine("Четное число: " + currentNum);
    currentNum += 1;
}
if (num <= 1) Console.WriteLine("Четное число отсутствует");