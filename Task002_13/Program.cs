/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5, 78 -> третьей цифры нет, 32679 -> 6*/

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 10;

if (n >=100 || n <= -100)
{
    if (n > 999 || n < -999)
    {
    while (n / i > 1000 || n / i < -1000) 
    {i = i * 10;}
    Console.WriteLine("3-я цифра заданного числа " + (n / i) % 10);
    Console.WriteLine(n);
    }
    else
    {
        Console.WriteLine("3-я цифра заданного числа " + n % 10);
    }
}

else 
{

   Console.WriteLine("Вы ввели не 3х значное число\nИли некорректное число");
   Console.WriteLine(n);
}