﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите натуральное число M: ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
uint n = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine(Acker(m, n));

uint Acker(uint m, uint n)
{
    if (m == 0) return n + 1;
      if (m != 0 && n == 0)return Acker(m - 1, 1);
       return Acker(m - 1, Acker(m, n - 1));
}


