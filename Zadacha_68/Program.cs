/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/


int GetAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
        if ((m > 0) && (n == 0))
        return GetAkkerman(m - 1, 1);
    else
    {
        return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
    }
}


Console.WriteLine("Insert number M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Insert number N:");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine($"{GetAkkerman(numberM, numberN)}");