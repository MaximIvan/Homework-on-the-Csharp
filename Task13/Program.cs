// Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 - 5
// 78 - третьей цифры нет
// 32679 - 6

int num = new Random().Next();

if ((num < 100) & (num > -100)) Console.Write($"{num} - третьей цифры нет");
int currentNum = num;
while ((currentNum >= 1000) | (currentNum <= -1000))   // if (((num < 1000) & (num > 100)) | ((num > -1000) & (num < -100)))
{                                                      //{
    currentNum /= 10;                                  //   int thirdNum = num % 10;       
}                                                      //   if ((thirdNum > -10) & (thirdNum < - 1))
int thirdNum = currentNum % 10;                        //   thirdNum *= -1;
if ((thirdNum > -10) & (thirdNum < - 1))               //   Console.Write($"{num} - {thirdNum}");
thirdNum *= -1;                                        //} 
Console.Write($"{num} - {thirdNum}");                  //if (((num < 10000) & (num > 1000)) | ((num > -10000) & (num < -1000)))
                                                       //{
                                                       //    int numOst = num % 100;
                                                       //    int thirdNum2 = numOst / 10;
                                                       //    if ((thirdNum2 > -10) & (thirdNum2 < - 1))
                                                       //    thirdNum2 *= -1;
                                                       //    Console.Write($"{num} - {thirdNum2}");
                                                       //} 
                                                       //if (((num < 100000) & (num > 10000)) | ((num > -100000) & (num < -10000)))
                                                       //{
                                                       //    int numOst2 = num % 1000;
                                                       //    int thirdNum3 = numOst2 / 100;
                                                       //    if ((thirdNum3 > -10) & (thirdNum3 < - 1))
                                                       //    thirdNum3 *= -1;
                                                       //    Console.Write($"{num} - {thirdNum3}");
                                                       //}
                                         
                                         
    
    