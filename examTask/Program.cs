/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
Console.WriteLine("Сколько будет слов?");
int userCount = int.Parse(Console.ReadLine());

string[] userWords = UserWords(userCount);
LengthOfWords(userWords);


string[] UserWords(int 4userCount)
{
    string[] userWords = new string[userCount];
    for (int i = 0; i < userCount; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е слово:");
        userWords[i] = Console.ReadLine();
    }
    return userWords;
}

void LengthOfWords(string[] userWords)
{
    Console.WriteLine("Слова длина которых меньше, либо равна 3 символам: ");
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < userWords.Length; i++)
    {
        if (userWords[i].Length <= 3)
        {
            Console.WriteLine(userWords[i]);
        }
    }
    Console.ResetColor();
}
