//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.



Console.Write("Введите первоу число ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третее число ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num2 > num1)
{
    max = num2;
}
if (num3 > num2)
{
    max = num3;
}
Console.WriteLine($"Число {max} больше ");