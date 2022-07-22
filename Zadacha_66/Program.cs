/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetSum(int m, int n)
{

    if (n == m) return n;

    else
    {
        return m + GetSum(m + 1, n);
    }

}

Console.WriteLine("Insert number M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Insert number N;");
int numberN = int.Parse(Console.ReadLine());
Console.Write($"{GetSum(numberM, numberN)}");