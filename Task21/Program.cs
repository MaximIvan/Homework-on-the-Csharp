// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// чужое решение:
// double[] A = new double[3];
// double[] B = new double[3];

// Console.Write("Введите Х точки А: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y точки А: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Z точки А: ");
// double z1 = Convert.ToDouble(Console.ReadLine());   
// A[0] = x1;
// A[1] = y1;
// A[2] = z1;

// Console.Write("Введите Х точки B: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y точки А: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Z точки А: ");
// double z2 = Convert.ToDouble(Console.ReadLine());   
// B[0] = x2;
// B[1] = y2;
// B[2] = z2;

// double dis = Math.Round(Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)), 2);
// Console.Write($"Расстояние между точками A с координатами ({x1}, {y1}, {z1}) и B с координатами ({x2}, {y2}, {z2}) = {dis}");

// Мое решение:
int[] Num = {-10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
// int[] Num = new int[100];
int x1 = Num[10];
int x2 = Num[14];
int y1 = Num[15];
int y2 = Num[11];
int z1 = Num[4];
int z2 = Num[2];
// int y1 = new Random().Next(-100000, 100000);
// int z1 = new Random().Next(-100000, 100000);
// x1 = 7; y1 = -5; z1 = 0;
// int x2 = new Random().Next(-100000, 100000);
// int y2 = new Random().Next(-100000, 100000);
// int z2 = new Random().Next(-100000, 100000);
// x2 = 1; y2 = -1; z2 = 9;
double dis = Math.Round(Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)), 2);

Console.Write($"Расстояние между точками A с координатами ({x1}, {y1}, {z1}) и B с координатами ({x2}, {y2}, {z2}) = {dis}");

