// 26
// Принимает число,выдает количество цифр в числе

using static System.Console;
Clear();
WriteLine("Введите число");
int number = int.Parse(ReadLine());
int count = GetCount(number);
WriteLine($"В числе {number} {count} цифр");

int GetCount(int number)
{
  int result = 0;
  for(int i=1; i<=number;i=i*10)
  {
    result++;
  }
  return result;
}