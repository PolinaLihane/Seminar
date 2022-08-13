// 18.
// По номеру четверти показывает диапозон координат в этой четверти(х,у)

using static System.Console;
Clear();

WriteLine("Введите номер четверти");
int number = int.Parse(ReadLine());

switch (number)
{
    case 1:
    {
    WriteLine("y>0,x>0");
    break;
    }
     case 2:
    {
    WriteLine("y>0,x<0");
    break;
    }
     case 3:
    {
    WriteLine("y<0,x<0");
    break;
    }
     case 4:
    {
    WriteLine("y<0,x>0");
    break;
    }
    default:
    {
    WriteLine("Ошибка");
    break;
    }
}