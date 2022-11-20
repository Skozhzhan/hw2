// Напишите программу, котораяя выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// Вариант решения с делением - не разобралась до конца, но мне кажется направление верное
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int k = Convert.ToInt32(Console.ReadLine());
// if (num <= 99)
// {
//     Console.WriteLine($"Третьей цифры нет");
// }
// else
// {
//     while (num >= 100)
//     {
//         k = num / 10;
//     }
//     int result = k % 10;
//     Console.WriteLine(result);
// }

Console.WriteLine("Введите любое число: ");
string num = Console.ReadLine();

if (num.Length >= 3)

{
    Console.WriteLine($"Третья цифра введенного числа: {num[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}