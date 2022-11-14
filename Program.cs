// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите первое N:");
// int N = int.Parse(Console.ReadLine()!);
// int M = 1;
// Console.WriteLine(PrintNumber(M, N));


// string PrintNumber(int end, int start)
// {
//     if (start > end)
//     {
//         return start + " " + PrintNumber(start - 1, end);
//     }
//     if (end == start)
//     {
//         return end.ToString();
//     }
//     return end + " " + PrintNumber(end - 1, start);
// }


// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// РЕШЕНИЕ


// Console.WriteLine("Введите число M: ");
// int M = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumber(M, N));

// int PrintNumber(int start, int end)
// {
//     if (start == end){
//         return start;
//     }
//     if (start > end){
//         return end + PrintNumber(start, end + 1);
//     }
//     return start + PrintNumber(start + 1, end);
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите число M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumber(M, N));

// int PrintNumber(int start, int end)
// {
//     if (start == 0)
//     {
//         return end + 1;

//     }
//     else if ((start != 0) && (end == 0))
//     {
//         return PrintNumber(start - 1, 1);
//     }
//     else 
//     {
//         return PrintNumber(start - 1, PrintNumber(start, end - 1));
//     }
// }