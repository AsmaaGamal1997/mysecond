using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //program to reverse array of words

            Console.WriteLine("enter your string");
            String str = Console.ReadLine();
            String[] s = str.Split(' ');
            Array.Reverse(s);
            Console.WriteLine("reverse string is:");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + "" + ' ');
            }
            Console.ReadKey();
            /////////////////////////////////////////////////////

            // program calculat  max space between the same two numbers
            Console.WriteLine("enter size of arr");
            int arr = int.Parse(Console.ReadLine());
            int[] numbers = new int[arr];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("enter value ( " + i + ", " + numbers + ") :");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int max = 0;
            int l = 0;
            int n = 0;
            for (int x = 0; x < numbers.Length; x++)
            { 

                for (int j = x + 1; j < numbers.Length; j++)
                {
                    if (numbers[x] == numbers[j])
                        l = j;
                    n = x;

                    if (l - n > max)
                    {
                        max = l - n;
                    }
                }
            }
            Console.WriteLine(max - 1);

        }

    }
    
}
