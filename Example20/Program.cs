// Принимает координаты 2х точек и находит растояние между ними в 2Д
using static System.Console;
Clear();

WriteLine("Введите координаты первой точки ");
int x1 = int.Parse(ReadLine());
int y1 = int.Parse(ReadLine());
WriteLine("Введите координаты второй точки ");
int x2 = int.Parse(ReadLine());
int y2 = int.Parse(ReadLine());

double Distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
WriteLine($"Растояние равно {Distance:f2}");