// Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 - 5
// 78 - третьей цифры нет
// 32679 - 6

int num = new Random().Next(-99999, 99999);

if ((num < 100) & (num > -100)) Console.Write($"{num} - третьей цифры нет");

if (((num < 1000) & (num > 100)) | ((num > -1000) & (num < -100)))
{
    int thirdNum = num % 10;
    if ((thirdNum > -10) & (thirdNum < - 1))
    thirdNum *= -1;
    Console.Write($"{num} - {thirdNum}");
} 
if (((num < 10000) & (num > 1000)) | ((num > -10000) & (num < -1000)))
{
    int numOst = num % 100;
    int thirdNum2 = numOst / 10;
    if ((thirdNum2 > -10) & (thirdNum2 < - 1))
    thirdNum2 *= -1;
    Console.Write($"{num} - {thirdNum2}");
} 
if (((num < 100000) & (num > 10000)) | ((num > -100000) & (num < -10000)))
{
    int numOst2 = num % 1000;
    int thirdNum3 = numOst2 / 100;
    if ((thirdNum3 > -10) & (thirdNum3 < - 1))
    thirdNum3 *= -1;
    Console.Write($"{num} - {thirdNum3}");
}