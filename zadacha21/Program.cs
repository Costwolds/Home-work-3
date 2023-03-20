//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

 Console.ForegroundColor = ConsoleColor.Green; 
Console.WriteLine("Введите коордитату x1 для точки А");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите коордитату y1 для точки А");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите коордитату z1 для точки А");
int z1 =int.Parse(Console.ReadLine());

Console.WriteLine("ВВедите координату х2 для  точки Б");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите координату у2 для  точки Б");
int y2 =int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите координату z2 для  точки Б");
int z2 =int.Parse(Console.ReadLine());

int result = (int)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"Расстояние между введенными точками равно {result}");

