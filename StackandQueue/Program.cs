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
        }
    }
}