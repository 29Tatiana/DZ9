// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetNaturalNumbers(N));

string GetNaturalNumbers(int N)
{
    if (N == 1)
        return "1";
    return N + ", " + GetNaturalNumbers(N - 1);
}
