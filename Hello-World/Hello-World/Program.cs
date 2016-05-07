using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Hello hello = new Hello(user.Name);
        }
    }

    public class Hello
    {
        public Hello(string who)
        {
            Console.WriteLine("Hello {0}", who);
        }
    }

    public class User
    {
        //private static string Name;
        static User()
        {
            //Name = Environment.UserName;
        }
        public string Name
        {
            get
            {
                return Environment.UserName;
            }
            set { }
        }
    }
}