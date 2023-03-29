// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает,что третьей цифры нет.
Console.Clear(); 
Console.Write("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine());
int result = -1;
if(number>=100)
   {
     while(number>999)
    {
       number/=10;
    }
   result = number % 10; 
   }

if(result == -1)
     {
     Console.WriteLine("третьей цифры нет");
     }
else
     Console.WriteLine ($"третье число={result}"); 