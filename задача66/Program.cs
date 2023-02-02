// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int PrintSumNumbers(int m, int n)
{
    
if(m==n) return m;
else return n + PrintSumNumbers(m, n-1);

}
const int M=1;
const int N=15;
Console.WriteLine(PrintSumNumbers(M, N));




