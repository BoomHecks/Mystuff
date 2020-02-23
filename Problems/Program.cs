using System;

namespace Problems
{
     public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = Console.ReadLine();
            Console.WriteLine(Prifix(input));
        }

        Prifix(string input)
        {
            int length= input.Length();
            int[] strings = input.Split();
            int count = strings.Length();

            return length + "," + count + input;
        }
    }
}
