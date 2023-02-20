void FillArray(int[] context)
{
    int length = context.Length;
    int index = 0;
    while (index < length)
    {
        context[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] write)
{
    int counter = 0;
    int ammount = write.Length;
    while (counter < ammount)
    {
        Console.Write($"{write[counter]} ");
        counter++;
    }
}

int IndexOff(int[] context, int find)
{
    int count = context.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (context[index] == find)
        {
            position = index;
            
        }
        index++;
    }
    return position;

}
int[] array = new int[10];


FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 4);
Console.WriteLine(pos);
