// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace AnagramProblem
{
    public class AnagramDetection
{
    public static void Main(string[] args)
    {
       
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        // Check if the strings are anagrams
        bool Anagrams = CheckIfAnagrams(str1, str2);

        // Print the result
        if (Anagrams)
        {
            Console.WriteLine("The two strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The two strings are not anagrams.");
        }
    }

    public static bool CheckIfAnagrams(string str1, string str2)
    {
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();

        // Check if the strings have the same length
        if (str1.Length != str2.Length)
        {
            return false;
        }

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);

        // Compare the sorted arrays
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }

        return true;
    }
}

}
