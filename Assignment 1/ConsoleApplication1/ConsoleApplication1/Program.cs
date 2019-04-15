using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        // Note to myself
        // The minimum value of the fuel is 20. Therefore x< 20 is invalid
        // The minimum value of the kilometre is at least (8) time more than the fuel. Therefore kilometre = kilometre > fuel * 8
        // The fuel consumption is expressed as litres per 100 kilometre (1L/100km)
        // To find the fuel consumption get the fuel value (Litre) and divide by the distance (Kilometre). For example, 45L/100KM * 100 = 9.181
        // To calculate the mpg the formula is mpg = 282.2/ fuel consumption.
        // The program must repeat itself when the user press 'Y' or 'y'. If not then end gracefully.
        // DON'T USE THE goto function NEVER
        static void Main(string[] args) {
            WelcomeMessage();
            FuelInput();
            AnotherOne();
        }
        public static void WelcomeMessage() {
            Console.WriteLine("\t\t Welcome to fuel consumption calculator");
        }
        public static double FuelInput() {
            int fuel;
            bool okay;
            string inputString;
            Console.Write("Enter the amount of fuel used in litres: ");
            inputString = Console.ReadLine();
            okay = int.TryParse(inputString, out fuel);
            if (!okay) {
                Console.WriteLine("Error " + inputString + " is not a value");
                Console.WriteLine("Please try again");
                Console.Write("Enter the amount of fuel used in litres: ");
                fuel = Convert.ToInt32(Console.ReadLine());
                while (fuel < 20) {
                    Console.WriteLine(fuel + " is below the minimum value of 20");
                    Console.Write("Please re-enter a number greater than 20 : ");
                    fuel = Convert.ToInt32(Console.ReadLine());
                    if (fuel > 20) {
                        return DistanceInput(fuel);
                    } 
                    else return DistanceInput(fuel);
                }
                while (!okay) ;
                while (fuel < 20) {
                    Console.WriteLine(fuel + " is below the minimum value of 20");
                    Console.Write("Please re-enter a number greater than 20 : ");
                    fuel = Convert.ToInt32(Console.ReadLine());
                    if (fuel > 20) {
                        return DistanceInput(fuel);
                    }
                }
                if (fuel > 20) {
                    return DistanceInput(fuel);
                }
                return DistanceInput(fuel);
            }
            while (fuel < 20) {
                Console.WriteLine(fuel + " is below the minimum value of 20");
                Console.Write("Please re-enter a number greater than 20 : ");
                fuel = Convert.ToInt32(Console.ReadLine());
                if (fuel > 20) {
                    return DistanceInput(fuel);
                } else return DistanceInput(fuel);
            }
            return DistanceInput(fuel);
        }
        public static double DistanceInput(double fuel) {
            int distance;
            bool okay;
            string inputString;
            Console.Write("Enter the distance travelled in kilometre: ");
            inputString = Console.ReadLine();
            okay = int.TryParse(inputString, out distance);
            if (!okay) {
                Console.WriteLine("Error " + inputString + " is not a value");
                Console.WriteLine("Please try again");
                Console.Write("Enter the distance travelled in kilometre: ");
                distance = Convert.ToInt32(Console.ReadLine());
                while (distance < fuel * 8) {
                    Console.WriteLine(distance + " is below the minimum value of " + fuel * 8);
                    Console.Write("Please re-enter a number greater than " + fuel * 8 + ": ");
                    distance = Convert.ToInt32(Console.ReadLine());
                    if (distance > fuel * 8) {
                        return LitreKilometre(fuel, distance);
                    } else return LitreKilometre(fuel, distance);
                }
                while (!okay) ;
                while (distance < fuel * 8) {
                    Console.WriteLine(distance + " is below the minimum value of " + fuel * 8);
                    Console.Write("Please re-enter a number greater than " + fuel * 8 + ": ");
                    distance = Convert.ToInt32(Console.ReadLine());
                    if (distance > fuel * 8) {
                        return LitreKilometre(fuel, distance);
                    }
                }
                if (distance > fuel * 8) {
                    return LitreKilometre(fuel, distance);
                }
                return LitreKilometre(fuel, distance);
            }
            if (distance > fuel * 8) {
                return LitreKilometre(fuel, distance);
            }
            while (distance < fuel * 8) {
                Console.WriteLine(distance + " is below the minimum value of " + fuel * 8);
                Console.Write("Please re-enter a number greater than " + fuel * 8 + ": ");
                distance = Convert.ToInt32(Console.ReadLine());
                if (distance > fuel * 8) {
                    return LitreKilometre(fuel, distance);
                } else
                    return LitreKilometre(fuel, distance);
            }
            return LitreKilometre(fuel, distance);
        }
        public static double LitreKilometre(double fuel, double distance) {
            double fuelconsumption;
            fuelconsumption = fuel / distance;
            Console.WriteLine("Your fuel consumption rate is " + fuelconsumption * 100 + "lt/100km");
            return mpg(fuelconsumption);
        }
        public static double mpg(double fuelconsumption) {
            Console.WriteLine("Which is equivalent to " + (282.48 / fuelconsumption) / 100 + "mpg");
            return 0;
        }
        // This is where i would make the 'Another calculation'
        public static void AnotherOne() {
            string userInput = " ";
            string yes = "Y";
            Console.Write("Another calculation <Y/N> ");
            Convert.ToChar(userInput = Console.ReadLine());
            if (userInput == yes) {
                WelcomeMessage();
                FuelInput();
                AnotherOne();
            }
            else {
                return;
            }
        }
    }
}


    

