// 16.
// Принимаем 2 числа и проверяем является ли одно квадратом другого

using static System.Console;
Clear();

void CheckMultiple(int OneNumber, int TwoNumber)
{
if (OneNumber * OneNumber == TwoNumber)
{
    WriteLine($"Да");
}
else
{
    WriteLine("Нет");
}
}
WriteLine("Введите первое число");
int OneNumber = int.Parse(ReadLine());
WriteLine("введите второе число");
int TwoNumber = int.Parse(ReadLine());

if (OneNumber < TwoNumber)
{
    CheckMultiple(OneNumber,TwoNumber);
} 
else
{
   CheckMultiple(TwoNumber,OneNumber); 
}