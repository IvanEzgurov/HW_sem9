//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int CoutNaturalSum(int m, int n)
{
    if (m > n)
    return 0 ;
    if (m == n)
    return n;
    return n + CoutNaturalSum(m, n - 1);
}
if (CoutNaturalSum(m, n) > 0)
{
    Console.WriteLine($"Сумма чисел от {m} до {n} равна {CoutNaturalSum(m, n)} ");
}
else Console.WriteLine($"неверная последовательность чисел");