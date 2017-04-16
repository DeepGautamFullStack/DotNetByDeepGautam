using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppForHackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool result = isRotationOfPalindrome("caabba");

            //string[] test = { "2", "{}[]()", "{[}]" };


            //string [] testbraces = braces(test);

            int[] marks = new int[] { 5,3,1,2,2,4 };

            customSort(marks);

            //Console.WriteLine(testbraces.ToString()+ "braces result"+testbraces);

            Console.ReadLine();
        }

        public static bool isPalindrome(string str)
        {
            // Start from leftmost and rightmost corners of str
            int l = 0;
            int h = str.Length - 1;

            // Keep comparing characters while they are same
            while (h > l)
                if (str[l++] != str[h--])
                    return false;

            // If we reach here, then all characters were matching
            return true;
        }
        public static bool isRotationOfPalindrome(string str)
        {
            // If string iteself is palindrome
            if (isPalindrome(str))
                return true;

            // Now try all rotations one by one
            int n = str.Length;
            for (int i = 0; i < n - 1; i++)
            {
                string str1 = str.Substring(i + 1, n - i - 1);
                string str2 = str.Substring(0, i + 1);

                // Check if this rotation is palindrome
                if (isPalindrome(str1+str2))
                    return true;
            }
            return false;
        }

        static string doBracesWork(string input)
        {
            Stack<int> openingBraces = new Stack<int>();
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{')
                {
                    openingBraces.Push(i);
                }
                else if (input[i] == '}')
                {
                    output += string.Format("{0} - {1}\n", openingBraces.Pop(), i);
                }
            }

            return output;
        }

        static string[] braces(string[] values)
        {

            Stack<int> openingBraces = new Stack<int>();
            string output = "";

           
           // string input = values.ToString();

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].ToCharArray()[i] == '{')
                {
                    openingBraces.Push(i);
                }
                else if (values[i].ToCharArray()[i] == '}')
                {
                    output += string.Format("{0} - {1}\n", openingBraces.Pop(), i).ToString();
                }
            }

            return new[] { output };
        }

        static void customSort(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach (int value in arr)
            {
                if (value != arr.Max())
                {
                    string s = value + Environment.NewLine;
                    Console.Write(s);
                }
            }
            Console.WriteLine();

        }
    }
}
