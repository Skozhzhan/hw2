// Напишите программу, котораяя выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// Вариант решения строкой
//Console.WriteLine("Введите любое число: ");
//string num = Console.ReadLine();
//if (num.Length >= 3)
//{
//    Console.WriteLine($"Третья цифра введенного числа: {num[2]}");
//}
//else
//{
//    Console.WriteLine("Третьей цифры нет");
//}


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num > 999)

    {
        num /= 10;
    }
    int result = num % 10;
    Console.WriteLine(result);
}

