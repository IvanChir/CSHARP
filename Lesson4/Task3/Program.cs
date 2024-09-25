// Задача №3
// Считать с консоли строку, состоящую из цифр и латинских букв.
// Сформировать новую строку, состоящую из букв исходной строки.

//создаем функцию для перебора и поиска в строке (string s) латинских букв
string GetLettersFromString(string s)
{
    string letters = ""; // ввод пустой строки
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true) // char.IsAsciiLetter встроенная функция поиска латинских букв
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine(); //команда для ввода строки с консоли

string resalt = GetLettersFromString(str);
Console.WriteLine(resalt); //команда для вывода результата в консоль выполнения функции GetLettersFromString(str)
