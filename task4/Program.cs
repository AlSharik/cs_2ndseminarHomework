//Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.


// Это первый вариант решения если дни недели могут быть только 1-7

/*
System.Console.WriteLine("Write number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 7 && number >= 1)
{
    if(number == 7 || number == 6)
    {
        System.Console.WriteLine("Yeah, its weekend");
    }
    else
    {
        System.Console.WriteLine("Sorry, but you should go to work");
    }
}
else
{
    System.Console.WriteLine("wrong input");
}
*/
// Второй вариант решение, если дни недели могут любыми целыми положительными числами
System.Console.WriteLine("Write number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1)
{
    if(number % 7 == 0 || number % 7 == 6)
    {
        System.Console.WriteLine("Yeah, its weekend");
    }
    else
    {
        System.Console.WriteLine("Sorry, but you should go to work");
    }
}
else
{
    System.Console.WriteLine("wrong input");
}