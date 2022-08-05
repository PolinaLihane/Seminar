using static System.Console;
// задача 0
Clear();
Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());
int sqr = number * number;
int sqr1 = Convert.ToInt32(Math.Pow(number,2));
WriteLine($"Квадрат числа {number} = {Convert.ToInt32(Math.Pow(number,2))}");
WriteLine($"Квадрат числа {number} = {sqr1}");
