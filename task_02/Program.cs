// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Write("Введите координаты X точки А: ");
int[] coordinateA = new int [3];
coordinateA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты Y точки A: ");
coordinateA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты K точки A: ");
coordinateA[2] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координаты X точки B: ");
int[] coordinateB = new int [3];
coordinateB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты Y точки B: ");
coordinateB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты K точки B: ");
coordinateB[2] = Convert.ToInt32(Console.ReadLine());

double betweenX = Math.Pow(coordinateB[0] - coordinateA[0], 2);
double betweenY = Math.Pow(coordinateB[1] - coordinateA[1], 2);
double betweenK = Math.Pow(coordinateB[2] - coordinateA[2], 2);
double result = Math.Sqrt(betweenX + betweenY + betweenK);

System.Console.Write("Расстояние равно: " + Math.Round(result, 4));