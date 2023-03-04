// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
//ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//sgrt((x1-x2)^2 + (y1-y2)^2 + z1-z2)^) 
//double s = Math.Sqrt()

Console.Clear();
Console.Write("Введите координату точки x1: ");
Double x1 = Double.Parse(Console.ReadLine());
Console.Write("Введите координату точки y1: ");
Double y1 = Double.Parse(Console.ReadLine());
Console.Write("Введите координату точки z1: ");
Double z1 = Double.Parse(Console.ReadLine());

Console.Write("Введите координату точки x2: ");
Double x2 = Double.Parse(Console.ReadLine());
Console.Write("Введите координату точки y2: ");
Double y2 = Double.Parse(Console.ReadLine());
Console.Write("Введите координату точки z2: ");
Double z2 = Double.Parse(Console.ReadLine());

Double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2 , 2)+ Math.Pow(z1-z2 , 2));
Console.WriteLine ($"d={d:f2}");
