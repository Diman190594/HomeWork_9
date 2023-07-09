// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
/*
int NaturalNumber(int n, int m)
{
    if (n == m) return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int n = Prompt("Input N: ");
if (n < 1)
{
    Console.WriteLine("enter a positive number");
    return;
}

Console.WriteLine(NaturalNumber(n, 1));
*/
//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumOfElements(int n, int m)
{
    if (n == m) return n;
    else return SumOfElements(n + 1, m) + n;
}

int n = Prompt("Input N: ");
int m = Prompt("Input M: ");

Console.WriteLine(SumOfElements(n, m));