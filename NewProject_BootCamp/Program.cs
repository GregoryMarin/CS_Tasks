
int GetValueFromUser (string text)
{
    int value = 0;
    bool flag = false;
    do
    {
        Console.Write(text);
        string s = Console.ReadLine()!;
        flag = int.TryParse(s, out value) && value > 0;
    } while(!flag);
    return value;
}
int number = GetValueFromUser("Write a number: ");

// string PrintNumbers(int n)
// {
//     string result = String.Empty;
//     for (int i = -n; i <= n; i++)
//     {
//         result = result + $"{i} ";
//     }
//     return result;
// }

string PrintNumbers2(int n)
{
    string result = "0";
    for (int i = 1; i <= n; i++)
    {
        result = $"{-i} " + result + $" {i} ";
    }
    return result;
}

string str = PrintNumbers2(number);
Console.Write(str);
File.WriteAllText("data.txt", str);