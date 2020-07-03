/*
In the space provided on this page write a program using these instructions:
1.    Create two classes, one called ‘Adult’ and one called ‘Child’ with the following string properties:
a.    First Name
b.    Last Name
2.    Populate the first and last name properties in both the Adult and Child classes.
3.    Create a single array to hold both the Adult and Child classes.
4.    Populate the array with one Adult class and one Child class.  
5.    Use the array in a loop and print the Adult and Child first and last name properties to the console.
*/

using System;

namespace Net012Final
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wholeArray = new string[100];

            Adult myAdult = new Adult();
            myAdult.FirstName = "Joe";
            myAdult.LastName = "Smith";

            Child myChild = new Child();
            myChild.FirstName = "Mary";
            myChild.LastName = "Wood";

            wholeArray[0] = (string)(myAdult.FirstName+ ' ' + myAdult.LastName);
            wholeArray[1] = (string)(myChild.FirstName + ' ' + myChild.LastName);

            for (int i = 0; i < wholeArray.Length; i++)
            {
                if (wholeArray[i] != null)
                    Console.WriteLine(wholeArray[i]);
            }

        }
    }

    public class Adult
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    public class Child
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}



