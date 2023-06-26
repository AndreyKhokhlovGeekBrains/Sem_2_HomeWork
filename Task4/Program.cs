// Дополнительное:
// Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. Напишите программу, 
// которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000(999 - последнее). 
// (каждый эл-т массива – сгенерирован случайно)
// Пример для 1 элемента массива: 591, сумма: 5+9+1 = 15; произведение: 5*9*1 = 45; 45 / 15 - делится НАЦЕЛО, число "интересное"
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]

int[] myArray = new int[10]; // Создаем массив с 10 элементами

int GetNum1(int myInt)
{
    int num1 = myInt / 100;
    return num1;
}

int GetNum2(int myInt)
{
    int num2 = myInt % 100 / 10;
    return num2;
}

int GetNum3(int myInt)
{
    if (myInt < 100)
    {
        int num3 = -1;
        return num3;
    }
    else
    {
        int num3 = myInt % 10;
        return num3;
    }
}

int GetReminder(int num)
{
    if (GetNum1(num) == 0 || GetNum2(num) == 0 || GetNum3(num) == 0)
    {
        int myCheck = 1;
        return myCheck;
    }
    else if (GetNum3(num) == -1)
    {
        int myCheck =
        (GetNum1(num) * GetNum2(num))
        %
        (GetNum1(num) + GetNum2(num));
        return myCheck;
    }
    else
    {
        int myCheck =
        (GetNum1(num) * GetNum2(num) * GetNum3(num))
        %
        (GetNum1(num) + GetNum2(num) + GetNum3(num));
        return myCheck;
    }
}

int index = 0;

while (index < myArray.Length)
{
    int randNum = new Random().Next(10, 1000);

    if (GetReminder(randNum) == 0)
    {
        myArray[index] = randNum;
        Console.WriteLine(myArray[index]);
        index++;
    }
}
