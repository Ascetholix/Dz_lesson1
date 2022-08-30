//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите  число ");
int num = Convert.ToInt32(Console.ReadLine());

int even;

if (num % 2 == 0)
{
    even = num;
    Console.WriteLine($"Чило {even} четное ");
}
if (num % 2 == 1)
{
    even = num;
    Console.WriteLine($"Чило {even} нечетное ");
}
