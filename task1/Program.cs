/*Задача 1: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа. 
Не использовать строки для расчета
*/
Console.WriteLine("Write number");
int number = Convert.ToInt32(Console.ReadLine());

// Проверка на трехназначность не нужна так как в условиях сказанно, что число на входе будет 3-ех значное
// но я ее на всякий напишу

if( number > 999 || number < 100)
{
    System.Console.WriteLine("Wrong number");
}
else
{
    System.Console.WriteLine($"2nd num is {(number/10)%10}");
}