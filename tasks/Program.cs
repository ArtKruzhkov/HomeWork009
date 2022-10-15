// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// Console.WriteLine("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// string AllDigits(int n, int minValue)
// {
//     if(n == minValue)
//     {
//         return n.ToString();
//     }
//     return (n + "," + AllDigits(n - 1, minValue));
// }
// Console.WriteLine(AllDigits(n, 1));


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.WriteLine("Enter M: ");
// int m= int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int SumElements(int M, int N)
// {
//     int sum = 0;
//     if(M == N)
//     {
//         sum = N;
//         return sum;
//     }
//     else
//     {
//         sum = M;
//         return (sum + SumElements(M + 1, N));
//     }
// }
// int Sum = SumElements(m, n);
// Console.WriteLine($"Sum for elements between M and N = {Sum}");


// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// Console.WriteLine("Enter M: ");
// int m= int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// int Akkerman(int M, int N)
// {
//     if(M == 0)
//     {
//         return N + 1;
//     }
//     if((M != 0)&&(N == 0))
//     {
//         return Akkerman(M - 1, 1);
//     }
//     if((M > 0)&&(N > 0))
//     {
//         return Akkerman(M - 1, Akkerman(M, N - 1));
//     }
//     return Akkerman(M, N);
// }
// int akk = Akkerman(m, n);
// Console.WriteLine($"Akkerman({m},{n}) = {akk}");