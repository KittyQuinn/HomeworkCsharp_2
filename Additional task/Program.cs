// Дополнительная задача (задача со звёздочкой): 
//Напишите программу, которая на вход принмает 3 трехзначных числа и находит среднее арифметическое, 
//далее проверяет больше ли последняя цифра среднего арифметического, чем первая цифра минимума вводимых чисел.

Console.Clear();
Console.WriteLine("Write first 3-digital number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Write second 3-digital number");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Write third 3-digital number");
int num3 = int.Parse(Console.ReadLine());

int AV = (num1+num2+num3)/3;
Console.WriteLine(AV);

int lastOfAV = AV%10;

int min = num1;

if (num2<min & num2<num3) min = num2;
if (num3<min & num3<num1) min = num3;

int firstOfmin = min/100;


if (lastOfAV>firstOfmin)
{
    Console.WriteLine("Yes");
}

else if (lastOfAV==firstOfmin)
{
    Console.WriteLine("Numbers are equal");
}

else
{
    Console.WriteLine("No");

}
