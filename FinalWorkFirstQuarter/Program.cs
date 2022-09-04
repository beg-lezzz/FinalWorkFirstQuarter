﻿Console.Clear();

//метод запроса информации у пользователя (число)
int UserNumData(string inputString)
{
    Console.Write(inputString + ": ");
    string numString = Console.ReadLine();
    if (Int32.TryParse(numString, out int num) == true && num > 0)                                       //проверяем, что введено положительное число для строк
    {
        return num;
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
        System.Environment.Exit(1);
        return 0;
    }
}

//метод запроса информации у пользователя (непустая строка)
string UserStringData(string inputString)
{
    Console.Write(inputString + ": ");
    string userString = Console.ReadLine();
    if (userString == String.Empty)
    {
        Console.WriteLine("Ошибка ввода");
        System.Environment.Exit(1);
    }
    
    return userString;
}

//Метод для заполнения одномерного массива с клавиатуры
string[] FillArray(int arrLength)
{
    string[] stringArray = new string[arrLength];

    for (int i = 0; i < arrLength; i++)
    {
        stringArray[i] = UserStringData($"Введите {i + 1}-й элемент массива");
    }

    return stringArray;
}