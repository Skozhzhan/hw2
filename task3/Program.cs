// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Ввелите цифру, обозначающую день недели");
int dayNum = Convert.ToInt32(Console.ReadLine());

if (dayNum == 6 || dayNum == 7)
{
    Console.WriteLine("Этот день - выходной");
}
else
{
    Console.WriteLine("Этот день - невыходной");
}