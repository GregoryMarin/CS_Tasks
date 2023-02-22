
int[] GetRangeSum(int[] array, int m)
{
    int n = array.Length;
    int[] t = new int[n - m + 1];
    int index = 0;
    for (int i = 0; i <= n-m; i++)
    {
        for (int j = 0; j < i + m; j++)
        {
            t[index] += array[j];
        }
        index++;
    }
    return t;
}

int[] CreateArray(int size) => new int [size];

string Print(int[] array) => $"[{String.Join(", ", array)}]";

void Fill(ref int[] array) => array = array.Select(e => Random.Shared.Next(10)).ToArray();

int[] numbers = CreateArray(15);

Fill(ref numbers);

Console.WriteLine(Print(numbers));

int count = 5;
int[] groupSumNumbers = GetRangeSum(numbers, count);
Console.WriteLine(Print(groupSumNumbers));

