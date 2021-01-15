using System;

namespace ArithmaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //The special character\n adds an extra blank line
            //it is call the next line character
            Console.WriteLine("Arithmatic Samples\n!");
            //declare a varaible of data type double
            //syntax; datatype varaiblename assignment operator literal numeric value
            //          double        Total          =                  0.0;
            double Total = 0.00;
            double Cost = 15.23;
            double Tax =  0.81;

            //Arithmatic assignment operation
            //syntax; receiving varaible assignment operator binary arithmatic (Addition) expression
            //                    Total                   =                    Cost + Tax;
            //action: the expression will be exicuted and the results will be placed into 
            //the receiving variable.
            Total = Cost + Tax;

            Console.WriteLine($"The Result of {Cost} + {Tax} is {Total}");


            //An alternate way of outpuing your varaibles will be to use string
            //concatenation.
            //String concatenation uses the operator +
            Console.WriteLine("The results of " + Cost + " + " + Tax + " is " + Total);

            //An alternate way is to use placeholders.
            //Placeholders start at 0 and increment by 1
            //Placeholder values are in a list after the string
            //ORDER IS IMPORTANT
            Console.WriteLine("The Result of {0} + {1} is {2}",Cost,Tax,Total);

        }
    }
}
