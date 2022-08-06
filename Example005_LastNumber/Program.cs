using static System.Console;
Clear();
WriteLine("Введите трехзначное число: ");
int number = int.Parse(ReadLine());
if (number>99 && number<1000)
{
    int LastNumber = number % 10;
WriteLine($"Последняя цифра: {LastNumber}");
}
else WriteLine("Число не трехзначное");


