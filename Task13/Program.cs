// Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 - 5
// 78 - третьей цифры нет
// 32679 - 6

int num = new Random().Next();

if ((num < 100) & (num > -100)) Console.Write($"{num} - третьей цифры нет");
int currentNum = num;
while ((currentNum >= 1000) | (currentNum <= -1000))   // решение через string
{                                                      // string n = Console.ReadLine();
    currentNum /= 10;                                  // int num = Convert.ToInt32(n);      
}                                                      // if (num < 100)
int thirdNum = currentNum % 10;                        // {
if ((thirdNum > -10) & (thirdNum < - 1))               //   Console.WriteLine("Третьей цифры нет");
thirdNum *= -1;                                        // } 
Console.Write($"{num} - {thirdNum}");                  // else if (num < 1000)
                                                       // {
                                                       //   Console.WriteLine(n[2]);
                                                       // }
                                         
                                         
    
    