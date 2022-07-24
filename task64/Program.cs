// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// M = 1; N = 9. -> "3, 6, 9" M = 13; N = 20. -> "15, 18"

void MultipleOfThree(int m, int n)
{
    if (m > n) return;
    if (m % 3 == 0) Console.Write($"{m}, ");
    MultipleOfThree(m + 1, n);
}

Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
MultipleOfThree(m, n);

