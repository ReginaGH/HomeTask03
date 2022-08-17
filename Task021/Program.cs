// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
//  между ними в 3D пространстве: 1) A (3,6,8); B (2,1,-7), -> 15.84. 2) A (7,-5, 0); B (1,-1,9) -> 11.5
Console.WriteLine("Введиты координаты x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиты координаты y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиты координаты z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиты координаты x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиты координаты y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиты координаты z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());
double s = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
Console.WriteLine(s);
