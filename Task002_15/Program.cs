/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да, 7 -> да, 1 -> нет*/

Console.WriteLine("Введите цифру от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 6 || n == 7)
{
    Console.WriteLine("Geat Weekend");
    Console.WriteLine(n);
}
else
{
    Console.WriteLine("Sorry, yot must go for a work\nIt is weekday");
    Console.WriteLine(n);
}
if (n < 1 || n > 7)
{
    Console.WriteLine("Try again\nThere are 7 days in a week");
}