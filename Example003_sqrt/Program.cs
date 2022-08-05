using static System.Console;
// является ли число квадратом для второго?
WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(ReadLine());
int number2 = Convert.ToInt32(ReadLine());
if (number1 == number2 * number2) WriteLine("да");
else WriteLine("нет");

