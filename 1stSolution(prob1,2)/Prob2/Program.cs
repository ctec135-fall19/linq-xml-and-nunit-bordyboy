/*
Author: Bogdan Livadaru
Date:   11/02/2019
CTEC 135: Microsoft Software Development with C#
​
Module 5: Programming Assignment 5, LINQ and Unit Testing
    1. Create a static method that creates an XML document and saves it. See pages 3 and 10 in Appendix B
    2. Create a static method that creates an XML document from an array and saves it. See page 12 in Appendix B
    3. Create a static method that loads an XML document and prints it to the screen. You can load the doc created in 2 above. See page  13 in Appendix B. Note that all I am asking for is for you to load the document and print. You can ignore the parsing part of the book's example code.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

using System.Xml.Linq;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            // I will be refering to the numbered directions from the top of this page.
            one();
            two();
            three();


        }

        static void one()
        {
            //1.
            XElement parts =
                new XElement("Inventory",
                new XElement("Car", new XAttribute("ID", "1000"),
                new XElement("PetName", "Jimbo"),
                new XElement("Color", "Red"),
                new XElement("Make", "Ford")
                )
            );

            parts.Save("ListOfParts.xml");
        }

        static void two()
        {
            //2. 
            var people = new[] {
                new { FirstName = "Mandy", Age = 32},
                new { FirstName = "Andrew", Age = 40 },
                new { FirstName = "Dave", Age = 41 },
                new { FirstName = "Sara", Age = 31}
            };
            XElement peopleDoc =
            new XElement("People",
                            from c in people
                            select new XElement("Person", new XAttribute("Age",c.Age),
                            new XElement("FirstName", c.FirstName))
            );
            peopleDoc.Save("DocumentOfPeople.xml");
        }

        static void three()
        {
            //3.
            XDocument myDoc = XDocument.Load("DocumentOfPeople.xml");
            Console.WriteLine(myDoc);
        }
    
    }
}
