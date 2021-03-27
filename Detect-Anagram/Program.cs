using System;
using System.Linq;

namespace Detect_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string FirstString, SecondString;

                Console.WriteLine("Write in your first word");
                FirstString = Console.ReadLine().ToUpper();
                Console.WriteLine("Write in your second word");
                SecondString = Console.ReadLine().ToUpper();

                Console.WriteLine($"{FirstString} and {SecondString} Anagram? {FindAnagram(FirstString, SecondString)}");
                Console.ReadKey(true);
            }
        }
        public static bool FindAnagram(string string1, string string2)
        {
            if(string.Equals(string1,string2))
            {
                return false;
            }
            else
            {
                if (string1.Length == string2.Length)
                {
                    char[] char1 = string1.ToCharArray();
                    Array.Sort(char1);
                    char[] char2 = string2.ToCharArray();
                    Array.Sort(char2);

                    if (Enumerable.SequenceEqual(char1, char2))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }            
        }
    }
}
