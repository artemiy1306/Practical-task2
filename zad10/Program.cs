// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
  //и на выходе показывает вторую цифру этого числа.
Console.Clear(); 
Console.Write("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
int result = 0;
number = number / 10;
result = number % 10;
Console.WriteLine($"второе число = {result}");
