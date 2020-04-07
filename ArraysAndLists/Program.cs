﻿using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            int[] numbers = new int[11];

            for(int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = i;
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();

            var odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            for(int i = 0; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
            }

            for(int i = 0; i < 50; i++ )
            {
                if(i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */


            foreach(int even in evens)
            {
                Console.WriteLine(even);
            }

            Console.ReadLine();

            foreach(int odd in odds)
            {
                Console.WriteLine(odd);
            }
        }
    }
}
