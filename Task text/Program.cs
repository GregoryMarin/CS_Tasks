// Дан текст, В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить на большие "К", 
// большие "С" заменить маленькими "с"

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
              + "ежели бы вас послали вместо нашего милого Винценгероде,"
              + "вы бы взяли приступом согласие прусского короля."
              + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldChar, char newChar)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldChar) result = result + $"{newChar}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string replacedText = Replace(text, ' ', '|');
string replacedLetter = Replace(replacedText, 'к', 'К');
string replacedLetterC = Replace(replacedLetter, 'С', 'с');

System.Console.WriteLine(text);
System.Console.WriteLine(replacedLetterC);