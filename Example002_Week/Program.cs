using static System.Console;
// день недели по числу, почему в конце ошибка?
Write("Введите число: ");
int day = Convert.ToInt32(ReadLine());
if (day == 1) {WriteLine("Понедельник");}
if (day == 2) {WriteLine("Вторник");}
if (day == 3) {WriteLine("Среда");}
if (day == 4) {WriteLine("Четверг");}
if (day == 5) {WriteLine("Пятница");}
if (day == 6) {WriteLine("Суббота");}
if (day == 7) {WriteLine("Воскресенье");}
else WriteLine("Ошибка");