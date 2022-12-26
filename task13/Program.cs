// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число ");
string number = Console.ReadLine();
int integer = Convert.ToInt32(number);
if (number.Length == 2 || number.Length == 1)
    Console.WriteLine("третьей цифры нет");
else
if (integer > 0)
    Console.WriteLine(number[2]);
else
{
    if (number.Length == 3 || number.Length == 2)
        Console.WriteLine("третьей цифры нет");
    else
        Console.WriteLine(number[3]);
}