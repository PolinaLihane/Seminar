using static System.Console;
Clear();
// 9. Найти число на отрезке, показать наибольшую цифру числа

int GetRandomNumberInRange(int minNumber, int maxNumber)
{
    int result = new Random().Next(minNumber,maxNumber+1);
    return result;  // возврат значения
}
int GetMaxDigitFromNumber(int number)
{
    int result = number/10;
    int secondDigit = number % 10;
    if (result < secondDigit)
    {
        result = secondDigit;
    }
return result;
}
for (int i = 0; i < 10; i++)
{
    int randomNumber = GetRandomNumberInRange(1,99);
int maxDigit = GetMaxDigitFromNumber(randomNumber);
WriteLine($"Наибольшая цифра числа {randomNumber} является {maxDigit}");
}