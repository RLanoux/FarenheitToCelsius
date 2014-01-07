using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare variables
            double Fahrenheit = 87;
            double Celsius;

            //Calculate the temperature in Celsius
            Celsius = (Fahrenheit - 32) * 5 / 9;

            //Show what the temperature is
            Console.WriteLine("{0:##.###} degrees Fahrenheit converts to " +
                              "{1:##.###} degrees Celsius.", Fahrenheit, Celsius);
            Console.ReadLine();
        }
    }
}
