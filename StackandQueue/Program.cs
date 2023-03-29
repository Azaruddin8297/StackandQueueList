namespace StackandQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackList list = new StackList();
            list.Push(10);
            list.Push(20);
            list.Push(30);
            list.Push(50);
            Console.WriteLine("*************************");
            list.Display();
            Console.WriteLine("*************************");
            list.Peek();
            Console.WriteLine("*************************");
            list.Pop();
            list.Display();
            Console.WriteLine("*************************");
            QueueList list1 = new QueueList();
            list1.Enqueue(10);
            list1.Enqueue(20);
            list1.Enqueue(30);
            list1.Enqueue(50);
            Console.WriteLine("***************************");
            list1.Display();
        }
    }
}