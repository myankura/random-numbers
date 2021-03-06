﻿using System;
using System.Collections.Generic;

namespace random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Randomly generate numbers for numbers list.
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6)
            };

            //for loop to iterate through the list of numbers and check to see if the value appears in the list.
            for (int i = 0; i < numbers.Count; i++)
            {
                //Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

                Console.WriteLine("--------------------------------");
                Console.WriteLine($"index of {i} has a value of {numbers[i]}");

                if (numbers.Contains(i)) //If the list contains the number i print a message that says the list does contain that number.
                {
                    Console.WriteLine($"numbers list contains {i}.");
                }
                else //If the number is not in the list, print out a message that says the list does not contain the number.
                {
                    Console.WriteLine($"numbers list does not contain {i}!!");
                }
            }
        }
    }
}
