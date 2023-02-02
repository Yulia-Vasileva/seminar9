// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FunAkkermana(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return FunAkkermana(m - 1, 1);
    else
      return FunAkkermana(m - 1, FunAkkermana(m, n - 1));
}

const int M=3;
const int N=3;
Console.WriteLine(FunAkkermana(M, N));