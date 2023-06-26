// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();

if (!int.TryParse(input, out int number))
{
    Console.WriteLine("Введено не число, введите корректное число.");
}
else
{
    int myNum = Convert.ToInt32(input);

    if (myNum > 99)
    {
        Console.WriteLine($"Третья цифра в числе {myNum} = {myNum.ToString()[2]}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}


