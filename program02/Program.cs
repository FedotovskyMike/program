/* Написать программу, которая принимает на вход трёхзначное
число и на выходе показывает последнюю цифру этого числа */

int n = int.Parse(Console.ReadLine());

if(n > 99 & n < 1000)
{
  Console.WriteLine(n);
  Console.WriteLine(n % 10);  
}
else
{
    Console.WriteLine("ОШИБКА");
}

