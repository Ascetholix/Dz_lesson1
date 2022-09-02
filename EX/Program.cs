//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

//Console.Write("Введите  число ");
int n = new Random().Next(100, 1000);
Console.WriteLine(n);

int num1 = n / 10;

int num2 = num1 % 10;

int num3 = n % 10;

int result = num1 - num2 + num3;


Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);
Console.WriteLine(result);

