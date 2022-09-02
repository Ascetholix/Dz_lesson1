//11. Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98


int n = new Random().Next(100, 1000);
Console.WriteLine(n);

int div = n / 10;

int modDiv = div % 10;

int modN = n % 10;

int result = div - modDiv + modN;


Console.WriteLine($"Деление {div}");
Console.WriteLine($"Остаток {modDiv}");
Console.WriteLine($"Остаток {modN}");
Console.WriteLine($"Результат {result}");