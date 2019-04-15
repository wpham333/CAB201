using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumption {
/*
 * Calculates fuel consumption in l/100km and the equivalent mpg,
 * input units of measurement are litres (l) for the fuel used and
 * kilometres (km) for the distance travelled
 *
 * Author William Pham, 9702474
 * Date: 17 August 2016
 *
 */
    class Program {
       
        // Note to myself
        // The minimum value of the fuel is 20. Therefore x< 20 is invalid
        // The minimum value of the kilometre is at least (8) time more than the fuel. Therefore kilometre = kilometre > fuel * 8
        // The fuel consumption is expressed as litres per 100 kilometre (1L/100km)
        // To find the fuel consumption get the fuel value (Litre) and divide by the distance (Kilometre). For example, 45L/100KM * 100 = 9.181
        // To calculate the mpg the formula is mpg = 282.2/ fuel consumption.
        // The program must repeat itself when the user press 'Y' or 'y'. If not then end gracefully.
        // DON'T USE THE goto function NEVER

        const double MIN = 20;
        const double FUEL_FACTOR = 8;

        static void Main(string[] args) {
            WelcomeMessage();
            double fuel = FuelInput();
            double distance = DistanceInput(fuel);
            result(fuel, distance);
            AnotherOne();
        }
        public static void WelcomeMessage() {
            Console.WriteLine("\t\t Welcome to fuel consumption calculator");
        }
        //The Fuel Input Function
        public static double FuelInput() {
            // Listing three important variables
            double fuel;
            bool okay;
            string inputString;
            Console.Write("Enter the amount of fuel used in litres: ");
            inputString = Console.ReadLine();
            // This part of the code will check if the user input the correct value. For example
            // If the user inputted a letter like "asd" then it will perform the error message and tell the user to
            // try again.
            okay = double.TryParse(inputString, out fuel);
            if (!okay) {
                Console.WriteLine("Error {0} is not a value", inputString);
                Console.WriteLine("Please try again");
                Console.Write("Enter the amount of fuel used in litres: ");
                fuel = Convert.ToInt32(Console.ReadLine());
                // This statement here represent that if the value fuel is less than the MIN which is a constant of 20.
                // Then it will perform and error message saying please input a value higher than 20.
                while (fuel < MIN) {
                    Console.WriteLine("{0} is below the minimum value of 20", fuel);
                    Console.Write("Please re-enter a number greater than 20 : ");
                    fuel = Convert.ToInt32(Console.ReadLine());
                    // This if statement represent that if the fuel is greater than 20 then return the fuel and go to the next method/function.
                    if (fuel >= MIN) {
                        // Returning the value as fuel which will store the value that the user inputted.
                        // With that stored value, the program will pass the value into DistanceInput().
                        return fuel;
                    } else return FuelInput();
                }
            }
            // This statement will tell the users that he/she have inputted a value less than 20
            // It therefore ask the users to re-enter a number greater than 20
            while (fuel < MIN) {
                Console.WriteLine("{0} is below the minimum value of 20",fuel);
                Console.Write("Please re-enter a number greater than 20 : ");
                fuel = Convert.ToInt32(Console.ReadLine());
                if (fuel > MIN) {
                    return fuel;
                } else return FuelInput();
            }
            return fuel;
        }
        // The Distance Input Function
        public static double DistanceInput(double fuel) {
            // Three important variable to be called
            int distance;
            bool okay;
            string inputString;
            // This line basically start off by asking the user to input their kilometre
            Console.Write("Enter the distance travelled in kilometre: ");
            inputString = Console.ReadLine();
            // This okay statement then checks if the user input is correct. If not okay then it will make an error message
            // saying that the input value is wrong. And ask the user to try again. 
            okay = int.TryParse(inputString, out distance);
            if (!okay) {
                // The {0} can be used in a string to make the output of the writeline easier to comprehend.
                Console.WriteLine("Error {0} is not a value", inputString);
                Console.WriteLine("Please try again");
                Console.Write("Enter the distance travelled in kilometre: ");
                // This line under here convert the user input into an int type value
                distance = Convert.ToInt32(Console.ReadLine());
                while (distance <= fuel * FUEL_FACTOR) {
                    Console.WriteLine("{0} is below the minimum value of {1}",distance, fuel * FUEL_FACTOR);
                    Console.Write("Please re-enter a number greater than  {0} : ", fuel * FUEL_FACTOR);
                    distance = Convert.ToInt32(Console.ReadLine());
                    if (distance >= fuel * FUEL_FACTOR) {
                        return distance;
                    } else return DistanceInput(fuel);
                }
                return distance;
            }
            if (distance >= fuel * FUEL_FACTOR) {
                return distance;
            }
            while (distance <= fuel * FUEL_FACTOR) {
                Console.WriteLine("{0} is below the minimum value of {1}", distance, fuel * FUEL_FACTOR);
                Console.Write("Please re-enter a number greater than {0} : ", fuel * FUEL_FACTOR);
                distance = Convert.ToInt32(Console.ReadLine());
                if (distance >= fuel * FUEL_FACTOR) {
                    return distance;
                } else
                    return DistanceInput(fuel);
            }
            return distance;
        }


        public static double result(double fuel, double distance) {
            double fuelconsumption;
            fuelconsumption = fuel / distance;
            Console.WriteLine("Your fuel consumption rate is {0:f2}lt/100km",fuelconsumption * 100);
            return mpg(fuelconsumption);
        }


        public static double mpg(double fuelconsumption) {
            Console.WriteLine("Which is equivalent to {0:f2} mpg",((282.48/fuelconsumption)/100));
            return 0;
        }


        // This is where i would make the 'Another calculation'
        public static void AnotherOne() {
            string userInput = " ";
            string yes = "Y";
            Console.Write("Another calculation <Y/N> ");
            Convert.ToChar(userInput = Console.ReadLine());
            if (userInput.ToUpper() == yes) {
                WelcomeMessage();
                double fuel = FuelInput();
                double distance = DistanceInput(fuel);
                result(fuel, distance);
                AnotherOne();
            }
            else {
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                return;
            }
        }
    }
}