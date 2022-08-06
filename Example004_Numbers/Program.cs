using static System.Console;
Clear();
WriteLine("Add number: ");
int number = int.Parse(ReadLine());
int N = - number;
while (N<=number) 
{
    Write($"{N}, ");
N++;
}
