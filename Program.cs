using System;

namespace OverLoadDemo
{
    class Program
    {
        public void Test()
        {
            Console.WriteLine("First Method.");
        }
        public void Test(int i)
        {
            Console.WriteLine("Second Method.");
        }
        public void Test(string s)
        {
            Console.WriteLine("Third Method.");
        }
        public void Test(int i, string s)
        {
            Console.WriteLine("Fourth Method.");
        }
        public void Test(string s, int i)
        {
            Console.WriteLine("Fifth Method.");
        }
       
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            p.Test(20);
            p.Test("zx");
            p.Test(10,"sd");
            p.Test("sa",32);
            string str = "Hello World";
            Console.WriteLine(str);
            Console.WriteLine(str.IndexOf('o',5));
            Console.WriteLine(str.IndexOf("ll"));
        }
    }
}
