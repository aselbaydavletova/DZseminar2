// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// System.Console.WriteLine("Введите трехзначное число");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// System.Console.WriteLine("вторая цифра этого числа -> " + stringNumber[1]);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// System.Console.WriteLine("Введите число");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2)
// {
//     System.Console.WriteLine("Третья цифра -> " + anyNumberText[2]);
// }
// else
// {
//     System.Console.WriteLine("-> третьей цифры нет");
// }

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// System.Console.WriteLine("Введите цифру, обозначающую день недели ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// void CheckingTheDayOfTheWeek (int dayNumber)
// {
//     if (dayNumber == 6 || dayNumber == 7)
//     {
//         System.Console.WriteLine("(этот день выходной) -> да");
//     }
//     else if (dayNumber < 1 || dayNumber > 7)
//     {
//         System.Console.WriteLine("это вообще не день недели");
//     }
//     else
//     System.Console.WriteLine("(этот день не выходной) -> нет");
// }
// CheckingTheDayOfTheWeek(dayNumber);