using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // create random 
            Random random = new Random();

            // create integer array of 100 elements
            int[] arrNumbers = new int[100];

            // get the random numbers between 20 to 40
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                arrNumbers[i] = random.Next(20, 41); 
            }

            // store to count of random values between from 20 to 40
            int[] Countoccurval = new int[21];

            // Count Occurence val of each number
            foreach (int numb in arrNumbers)
            {
                Countoccurval[numb - 20]++; 
            }

    

            Console.WriteLine("Count of random values from 20 between 40:");
            for (int i = 0; i < Countoccurval.Length; i++)
            {
                int number = i + 20;
                int count = Countoccurval[i];
                Console.WriteLine($"Number {number} appears {count} times.");
            }
            // the result of 20 to 40 random count it will be changing.

            Console.ReadLine();
        }
    }
}
