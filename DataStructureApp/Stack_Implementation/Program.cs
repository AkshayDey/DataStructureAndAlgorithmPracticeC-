using System.Collections;

namespace Stack_Implementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Stack<string> stack = new Stack<string>();
            //stack.Push("A");
            //stack.Push("B");
            //stack.Push("C");

            ////stack.Pop();

            //Console.WriteLine("Pop: {0}", stack.Pop());
            //Console.WriteLine("Peek: {0}",stack.Peek());

            Stack_Practice<string> stackPracticeNew = new Stack_Practice<string>();
            stackPracticeNew.Push("A");
            stackPracticeNew.Push("B");
            stackPracticeNew.Push("C");

            Console.WriteLine("Pop: {0}", stackPracticeNew.Pop());
            Console.WriteLine("Pop: {0}", stackPracticeNew.Pop());
            Console.WriteLine("Peek: {0}", stackPracticeNew.Peek());

        }
    }
}