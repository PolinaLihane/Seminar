// Задача 42: 
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

using static System.Console;
Clear();

WriteLine("Введите число");
int number=int.Parse(ReadLine()!);
WriteLine(Convert.ToString(number,2));
WriteLine(Transfer(number));
WriteLine(DecToNum(number,2));

string Transfer(int number)
{
    string newnumber="";
    while (number>0)
    {
        newnumber=number%2+newnumber;
        number=number/2;
    }
    return newnumber;
}

string DecToNum(int decNumber, int otherSystem) // перевод в любую систему
{
string res="";
string nums="0123456789ABCDEF";
while(decNumber>0)
{
int ost=decNumber%otherSystem;
res=nums[ost]+res;
decNumber/=otherSystem;
}
return res;
}