/*
Задача 3: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
Не использовать строки для расчета.
*/

Console.WriteLine("Write number");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    while(number > 999)
    {
        number /= 10;
    }
    System.Console.WriteLine(number % 10);
}