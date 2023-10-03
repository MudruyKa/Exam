/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


Console.Clear();

{
    // Вводим исходный массив строк с клавиатуры
    Console.WriteLine("Введите строки, разделенные пробелами:");
    string input = Console.ReadLine();
    string[] inputStrings = input.Split();

    // Инициализируем пустой массив для результата, <= 3 символов
    string[] resultStrings = new string[0];

    // Проходим по каждой строке в исходном массиве
    foreach (string str in inputStrings)
    {
        // Если длина строки меньше или равна 3 символам, добавляем ее в результат
        if (str.Length <= 3)
        {
            Array.Resize(ref resultStrings, resultStrings.Length + 1);
            resultStrings[resultStrings.Length - 1] = str;
        }
    }

    // Выводим результат
    Console.WriteLine("Результат:");
    foreach (string str in resultStrings)
    {
        Console.WriteLine(str);
    }
}
