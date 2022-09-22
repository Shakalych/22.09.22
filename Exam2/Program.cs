//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = EnterNumbers("Введите число M: ");
int N = EnterNumbers("Введите число N: ");
Console.WriteLine("Сумма чисел от " + M + " до " + N + " = " + SummFromMtoN(M, N));

int EnterNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}


int SummFromMtoN(int start, int end)
{
    if (start == end) return end;
    int summ = start;
    start++;
    return summ + SummFromMtoN(start, end);
}
