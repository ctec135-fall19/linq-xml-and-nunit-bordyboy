/*
Author: Bogdan Livadaru
Date:   11/02/2019
CTEC 135: Microsoft Software Development with C#
​
Module 5: Programming Assignment 5, LINQ and Unit Testing
    Create a static method that:
    1. creates an array of strings (the ordering of the strings should be random)
    2. create a LINQ statement that returns the strings that start with 'a' - 'f'
    3. output the result 
    4. modify the array in such a way that the result will be different
    5. output the result again
    6. modify the array in such a way that the result will be different
    7. capture the result as a List<string> object and return it
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            // I will be refering to the numbered directions from the top of this page.
            //1.
            string[] currentVideoGames = { "PUBG", "Fallout 4", "Rocket League", "League of Legends", "The Witcher 3" };
            //2.

            var queryOne = from elements in currentVideoGames
                            where elements[0] >= 'A' && elements[0] <= 'F'
                            select elements;
            //3.
            foreach (var game in queryOne)
            {
                Console.WriteLine("Item: {0}", game);
            }
            Console.WriteLine();

            //4. 
            currentVideoGames[0] = "CS";

            //5.
            foreach (var game in queryOne)
            {
                Console.WriteLine("Item: {0}", game);
            }
            Console.WriteLine();

            //6.
            currentVideoGames[3] = "Call of Duty: Modern Warfare";

            //7.
            List<string> outputList = (from elements in currentVideoGames
                                       where elements[0] 
                                       >= 'A' && elements[0] <= 'F'
                                       orderby elements
                                       select elements).ToList<string>();

        }
    }
}
