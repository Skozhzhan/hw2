// Задача 10: Напишите программу, которая на вход принимает трёхначное число и на выходе показывает вторую цифру этого чила.
int randomNum = new Random().Next(100, 1000);
Console.WriteLine(randomNum);
int num = (randomNum % 100 - randomNum % 10) / 10;
Console.WriteLine(num);
