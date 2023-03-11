// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задача 64");
Console.WriteLine();

Console.WriteLine(PrintNumbersRev(8, 1));

/// <summary>
/// Возвращает строку чисел в обратном порядке в промежутке двух заданных
/// </summary>
/// <param name="start">Конец промежутка, оно же начало возврата</param>
/// <param name="end">Начало промежутка, оно же конец возврата</param>
/// <returns>
/// Строка с целыми числами в промежутке,
/// в обратном порядке, через запятую
/// </returns>
string PrintNumbersRev(int start, int end)
{
    if (start < end) return "Нет подходящих чисел";
    if (start == end) return end.ToString();
    return (start + ", " + PrintNumbersRev(start - 1, end));
}




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задача 66");
Console.WriteLine();

Console.WriteLine(SumNumbers(4, 8));

/// <summary>
/// Суммирует целые числа в промежутке
/// </summary>
/// <param name="start">Начало промежутка, включается в сумму</param>
/// <param name="end">Конец промежутка, включается в сумму</param>
/// <returns>Сумма чисел в промежутке</returns>
int SumNumbers(int start, int end)
{
    if (start > end) return 0;
    if (start == end) return end;
    return (start + SumNumbers(start + 1, end));
}



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задача 68");
Console.WriteLine();

Console.WriteLine(FuncAkkerman(3, 2));

/// <summary>
/// Считается функция Аккермана для n и m
/// </summary>
/// <param name="n"></param>
/// <param name="m"></param>
/// <returns>Значение функции</returns>
int FuncAkkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return FuncAkkerman(n - 1, 1);
    else
      return FuncAkkerman(n - 1, FuncAkkerman(n, m - 1));
}