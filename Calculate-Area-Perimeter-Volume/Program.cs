using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Area_Perimeter_Volume
{
    class Program
    {
        public static void Main(string[] args)
        {
            //No validation required for this console app based on lab instructions
            double length = 0.0;
            double width = 0.0;
            double height = 0.0;

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            while (true) //loop program until user is finished.
            {
                Console.WriteLine("Enter Length:");
                length = Double.Parse(Console.ReadLine());//Get length from user. 
                Console.WriteLine("Enter Width:");
                width = Double.Parse(Console.ReadLine());//Get width from user.
                Console.WriteLine("Enter Height:");
                height = Double.Parse(Console.ReadLine());//Get height from user.
                
                Console.WriteLine("Area: " + (length * width));//Call CalculateArea method and display result

                Console.WriteLine("Perimeter: " + (2 * (length + width)));//Call CalculatePerimeter method and display result

                Console.WriteLine("Volume: " + (length * width * height));//Call CalculateVolume and display result

                Console.WriteLine("Continue? (y/n):");//Does user want to preform calculations again?
                string response = Console.ReadLine();//Get users response
                if (response.ToLower() == "n")//Was users response n?
                {
                    break;//User is done and we can break out of loop.
                }
            }
        }
    }
}
