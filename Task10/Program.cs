// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Write three-digital number ");
int num = int.Parse(Console.ReadLine());

int a = num % 100;
int b = num % 10;
int c = (a-b)/10;

Console.WriteLine(c);