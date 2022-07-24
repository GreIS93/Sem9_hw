// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfIntegers(int m, int n)
{
    int sum=0;
    if (m > n) return sum;
    else return sum=m+SumOfIntegers(m+1,n);
}

Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(SumOfIntegers(m, n));