// Тарнарный оператор

using static System.Console;
Clear();
Write("ВВедите число A ");
int a = Convert.ToInt32(ReadLine());
Write("ВВедите число B ");
int b = Convert.ToInt32(ReadLine());

string answer = a>b? "a>b": a<b? "a<b":"a=b";
//WriteLine(n % 2 == 0 ? "yes" :  "no");
WriteLine(answer);
