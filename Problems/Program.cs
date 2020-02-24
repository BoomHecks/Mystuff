using System;

namespace Problems
{
     public class Program
    {
       public string Prifix(string input)
        {
            int length = input.Length;
            
            string[] stringsArray = input.Split();
            
            int count = stringsArray.Length;
            if (length == 0) count = 0;
            string output = Convert.ToString(length) + "," + Convert.ToString(count) +":"+ input;
            return output;
        }

        static void Main(string[] args)
        {
            // string hi = Prifix("hello hoo lll");
            //Console.WriteLine(hi);
            Program p = new Program();

            Console.WriteLine(p.Prifix("what  ... did you say ?? "));
        }


    }
}
