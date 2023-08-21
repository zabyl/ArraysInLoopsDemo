using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInLoopsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // average of all numbers from user input


            int total = 0;

            Console.WriteLine("how many numbers to calculate: ");
            int numbersLength = int.Parse(Console.ReadLine());

            int[] numbers = new int[numbersLength];

            for (int i = 0; i < numbersLength; i++)
            {
                Console.Write("Please enter {0}. number: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in numbers)
            {
                total += i;
            }

            Console.WriteLine("average of entered numbers is: " + total/numbersLength);
            Console.ReadLine();

        }
    }
}
