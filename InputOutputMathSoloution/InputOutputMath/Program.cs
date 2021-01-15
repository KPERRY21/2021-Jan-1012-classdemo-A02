using System;

namespace InputOutputMath
{
    class Program
    {
                    
                static void Main(string[] args);

        /*
        * Implement a teprature converter from
        * Celsius to Fahrenheit
        * 
        * Jan 2021
        */

        //input: Celsius temprature
        //string inputTemp
        //double theCelsiusTemprature

        //output: Fahrenheit temprature
        //       double theFahrenheitTemprature

        //expression (calculate): (ct *(9.0/5.0)) + 32
        //check with ct = 0 expect ft = 32
        //check with ct = 100 expect ft = 212
        //check with ct = -40 expect ft = -40

        //prompt for a celcius temprature
        // .Write() keeps your cursor on the same line
        Console.Write("Enter a Celsius temprature: ");

                    //How does the program pull in the entry from the user
                    //to obtain the key sttrokes that the user types (input)
                    // .ReadLine()
                    //important!!!!
                    // Data comes into the program as a string
                    //DOES NOT matter if you enter an number, it is treated as a string

                        //declare the variable:      datatype varaiblename;
                     string inputTemp;
        //assignment statement: expression on the roght is placed
        // into the varaible on the left
        //expression (action):     read the user input
        inputTemp = Console.ReadLine();
                        //you could do both statemnets on one line
                        //string inputTemp = Console. ReadLine();

                        //currently the celsius value is a string
                        //the value need to be converted to a number to be
                        //     used in a math calculation
                        //convert the data to a different datatype
                        //to do this; you will use a technique called parsing
                        //    syntax: datatypeTo.Parse(string value)
                        //WARNING: I am assuming the user will enter a valid data
                        //if the user does not enter a number this program
                        //will abour on the exicution of this line

                double theCelsiusTemprature = double.Parse(inputTemp);
        //calculation using the conversion expression
        double theFahrenheitTemprature =
                    (theCelsiusTemprature * (9.0 / 5.0)) + 32;

        //output
        //.Writeline() which automaticly goes to the next line.
        Console.WriteLine($"The Celsius temprature of {theCelsuisTemprature} is) " + $"{theFahrenheitTemprature} in Fahrenheit. ");
            

    }
}

