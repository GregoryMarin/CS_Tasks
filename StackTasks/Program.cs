void Stack()
{
    Stack<int> stackInstance = new Stack<int>();
    stackInstance.Push(100);
    stackInstance.Push(200);
    stackInstance.Push(300);

    while (stackInstance.Count > 0)
    {
        int a = stackInstance.Pop();
        Console.WriteLine(a);
    }
};
// Stack();

void Queue()
{
    Queue<int> queue = new Queue<int>();
    queue.Enqueue(100);
    queue.Enqueue(200);
    queue.Enqueue(300);

    while (queue.Count > 0)
    {
        int a = queue.Dequeue();
        Console.WriteLine(a);
    }
};
//Queue();

