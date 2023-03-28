// Задача 1: Задайте значение N. Напишите программу, которая выведет 
//все четные натуральные числа в промежутке от m до N . Выполнить с помощью рекурсии.
//M, N = 5, 8 -> "6, 8"
//M, N = 2, 4 -> "2, 4"
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

void PrintNumbers(int m, int n)
{
    if(m > n){
    return;
    }
    if(m % 2 == 0)
    Console.Write($"{m} ");
    m++;
    PrintNumbers(m, n);
    
}
PrintNumbers (m, n);
