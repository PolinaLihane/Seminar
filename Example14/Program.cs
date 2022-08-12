// 14.
// Принимает число и проверяет кратно ли одновлеменно и 7 и 23

using static System.Console;
Clear();

WriteLine("Введите число");
int number = int.Parse(ReadLine());
if ((number % 7 == 0) && (number % 23 == 0))
{
    WriteLine($"Число {number} кратно и 7 и 23");
}
else
{
    WriteLine($"Число {number} не кратно и 7 и 23");
}