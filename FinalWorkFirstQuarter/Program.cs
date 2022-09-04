// метод запроса информации у пользователя (число)
int UserNumData(string inputString)
{
    Console.Write(inputString + ": ");
    string numString = Console.ReadLine();
    // проверяем, что введено положительное число для строк
    if (Int32.TryParse(numString, out int num) == true && num > 0)
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

// метод запроса информации у пользователя (непустая строка)
string UserStringData(string inputString)
{
    Console.Write(inputString + ": ");
    string userString = Console.ReadLine();
    // проверяем, что строка не пуста и туда введен символ
    if (userString == String.Empty)
    {
        Console.WriteLine("Ошибка ввода");
        System.Environment.Exit(1);
    }
    
    return userString;
}

// Метод для заполнения одномерного массива с клавиатуры
string[] FillArray(int arrLength)
{
    string[] stringArray = new string[arrLength];
// запускаем цикл для запроса у пользователя такого количества элементов, которое он ввел ранее
    for (int i = 0; i < arrLength; i++)
    {
        stringArray[i] = UserStringData($"Введите {i + 1}-й элемент массива");
    }

    return stringArray;
}

// метод для создания нового масиива 3-х значных элементов исходного массива
string[] FillThreeDigitsArray(string[] stringArray)
{
    int counter = 0;
    string[] outArray = new string[stringArray.Length]; 
    // запускаем цикл для перебора всех элементов массива, определения тех, у которых длина меньше или равна 3 и записи их в новый массив
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            outArray[counter] = stringArray[i];
            counter++;
        }
    }
    // меняем длину массива до количества найденных в основном массиве элементов, длина которых меньше, либо равна 3
    Array.Resize(ref outArray, counter);
    return outArray;
}

// Метод для печати одномерного массива
void PrintArray(string[] stringArray)
{
    // запускаем цикл для последовательного вывода всех элементов входного массива до предпоследнего через запятую
    for (int i = 0; i < stringArray.Length - 1; i++)
    {
        Console.Write(stringArray[i] + ", ");
    }
    // вывод последнего элемента массива без запятой
    Console.WriteLine(stringArray[stringArray.Length - 1]);
}

// основной метод для вызова последовательности остальных методов
void MainMethod()
{
    Console.Clear();
    // заполняем массив
    string[] outArray = FillArray(UserNumData("Задайте число элементов массива"));
    Console.Clear();
    // выводим первоначальный массив
    Console.WriteLine("Первоначальный массив: ");
    PrintArray(outArray);
    Console.WriteLine();
    // вывод массива с элементами, у которых длина меньше или равна 3
    Console.WriteLine("Массив с элементами 3 и менее символов: ");
    PrintArray(FillThreeDigitsArray(outArray));
}

MainMethod();