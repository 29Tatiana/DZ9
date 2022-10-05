// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = InputNumber("Ввод m: ");
int n = InputNumber("Ввод n: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
PrintSum(m, n, temp = 0);

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма = {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);

}