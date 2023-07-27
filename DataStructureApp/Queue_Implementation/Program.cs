namespace Queue_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Peek: " + queue.Peek()); // Output: Peek: 10

            Console.WriteLine("Dequeue: " + queue.Dequeue()); // Output: Dequeue: 10

            Console.WriteLine("Peek: " + queue.Peek()); // Output: Peek: 20

            Console.WriteLine("IsEmpty: " + queue.IsEmpty()); // Output: IsEmpty: False

            queue.Clear();

            Console.WriteLine("IsEmpty: " + queue.IsEmpty()); // Output: IsEmpty: True
        }
    }
}