// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и
// удаляет вторую цифру этого числа.
// Не использовать строки для расчета.

int random = new Random().Next(100, 1000);
System.Console.WriteLine(random);

System.Console.WriteLine($"{random/100}{random%10}");
