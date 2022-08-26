//Задача 40: 
//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

using static System.Console;
using System.Linq;
Clear();

WriteLine("Введите 3 стороны стреугольника");
int[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

WriteLine(GetExam(array)?"Это треугольник":"Это не треугольник");

bool GetExam(int[] array)
{
    return ((array[0]+array[1]>array[2]) && (array[1]+array[2]>array[0]) && (array[2]+array[0]>array[1]));  
}