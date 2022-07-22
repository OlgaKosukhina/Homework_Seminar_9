/* Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

string GetNumbers(int m, int n)
{

    if (n == m) return n.ToString();

    else
    {
        return m + ", " + GetNumbers(m + 1, n);
    }

}

Console.WriteLine("Insert number M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Insert number N:");
int numberN = int.Parse(Console.ReadLine());
Console.Write($"{GetNumbers(numberM, numberN)}");