// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace AnagramProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            string str1 = "heart";
            string str2 = "earth";

            char[] chr1 = str1.ToLower().ToCharArray();
            char[] chr2 = str2.ToLower().ToCharArray();

            Array.Sort(chr1);
            Array.Sort(chr2);

            string val1 = new string(chr1);
            string val2 = new string(chr2);

            Console.WriteLine(val1);
            Console.WriteLine(val2);
        }
    }
}