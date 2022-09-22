﻿/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

int m = EnterNumbers("Введите число m: ");
int n = EnterNumbers("Введите число n: ");
Console.WriteLine("A (m, n) = " + FunctionAckerman(m, n));

int EnterNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}


int FunctionAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FunctionAckerman(m - 1, 1);
    else return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
}
