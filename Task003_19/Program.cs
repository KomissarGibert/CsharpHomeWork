/* Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите 5-ти значное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <99999 & n >=10000)
{
    int left = n / 1000;
    int number1 = left / 10;
    int number2 = left % 10;
    int right = n % 100;
    int number4 = right / 10;
    int number5 = right % 10;

    if ((number1 == number5) & (number2 == number4))
    {
        Console.WriteLine($"{n} <-- да, это палиндром");
    }
    else
    {
        Console.WriteLine($"{n} <-- это не палиндром");
    }
}
else 
{
    Console.WriteLine($"{n} <-- попробуй ввести 5ти значное число");
}