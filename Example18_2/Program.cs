// 18/2
// Принимает координаты точки(х у) они не равны 0и выдает номер четверти 

//int quarter =x>0 &&v>0? 1:x<0 && y>0? 2:x<0 &&y<0?3:4;
//WriteLine($"искомая четверть {quarter}")
using static System.Console;
Clear();

WriteLine("Ведите координату Х ");
int X = int.Parse(ReadLine());
WriteLine("Ведите координату Y ");
int Y = int.Parse(ReadLine());

if ((X>0) && (Y>0))
{
    WriteLine("1 четверть");
}
if ((X>0) && (Y<0))
{
    WriteLine("2 четверть");
}
if ((X<0) && (Y>0))
{
    WriteLine("4 четверть");
}
if ((X<0) && (Y<0))
{
    WriteLine("3 четверть");
}
if ((X=0) && (Y=0))
{
    WriteLine("четверти не существует");
}