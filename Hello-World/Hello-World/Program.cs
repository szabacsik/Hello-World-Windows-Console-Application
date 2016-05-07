using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
        }
    }

    public class Hello
    {
        static Hello()
        {
            Console.WriteLine("Hello World");
        }
    }
}