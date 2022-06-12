/* Напишите программу, которая на вход принимает два числа и проверят,
является ли первое число квадратом второго */
int n = int.Parse(Console.ReadLine());

int a = int.Parse(Console.ReadLine());

Console.WriteLine(n + "первое число");

Console.WriteLine(a + "вторе число");

if (a * a == n)

{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}