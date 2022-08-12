// 12.
//Принимаем 2 числа, проверяет является ли второе кратным первому. 
//Если 2 не кратно 1 то выводит остаток от деления
using static System.Console;
Clear();
WriteLine("Введите первое число");
int FirstNumber = int.Parse(ReadLine());
WriteLine("Введите второе число");
int SecondNumber = int.Parse(ReadLine());

int result = FirstNumber % SecondNumber;
if (result == 0)
{
    WriteLine($"Число {FirstNumber} является кратным {SecondNumber}") ;
}
else
{
   int remainder = FirstNumber % SecondNumber;
 WriteLine($"Остаток от деления {remainder}") ;
}

