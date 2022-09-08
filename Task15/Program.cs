// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Write number ");
int num = int.Parse(Console.ReadLine());

if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5)
{
    Console.WriteLine("This day is a work day");
}

else if (num == 6 || num  == 7)
{
    Console.WriteLine("This day is a day-off");
}

else 
{
    Console.WriteLine("Write number from 1 to 7");
}