using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack llStack = new LinkedListStack();
            llStack.Push(56);
            llStack.Push(30);
            llStack.Push(70);
            llStack.Display();

        }
    }
}
