// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Write number ");
int num = int.Parse(Console.ReadLine());

string str = num.ToString();

if (str.Length > 2)
Console.WriteLine(str[2]);
else
{
    Console.WriteLine("Write another number");
}