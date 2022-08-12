// 10. вывести случайное 3х значное число, удалить в нем 2ю цифру
using static System.Console;
Clear();

int number = new Random().Next(100,999);

int resultOne = number/100;
int resultTwo = number % 10;

WriteLine($"Исключаем из числа {number} вторую цифру и получаем {resultOne}{resultTwo}");
