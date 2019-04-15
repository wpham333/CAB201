using System;

namespace TrainTimetable {

   /*
    * Designing a console application that will be read and take values from a TrainTimetable array,
    * an integer input from the departing station (1-6) and arrival station (1-6), which correlate to the enum Stations. 
    * Time is also taken and stored, which will be used to compared other time depending on
    * the departaure and arrival of the user.
    * The result will print the recommeded time for when the user wants to arrival 
    *
    * Author William Pham, 9702474
    * Date: August 2016
    *
    */

    enum Stations { Central, Roma_Street, Milton, Auchenflower, Toowong, Taringa, Indooroopilly };

    class Program {
        // This constant EXIT will be used to determine whether the user want the exit the program gracefully before main.
        const int EXIT = 0;
        // This constant OFFSET will be used to take one away from the array since the array is counting from '0' to 7 or '0' to 76.
        // Having this constant helps the users select array that are in position 0 or 75.
        const int OFFSET = 1;
        // Constant TWELVE is used as a convertion. Which convert the 24 hours into 12 hour format
        const int TWELVE = 12;
        // The constant HUNDRES will be used to split a four or three digits number into their hours and minutes
        const int HUNDRED = 100;

        public const int NUMBER_OF_TRAINS = 76;
        public const int NUMBER_OF_STATIONS = 7;
        static int[,] timeTable = new int[NUMBER_OF_STATIONS, NUMBER_OF_TRAINS];
         
        static string departFrom = "\n Which station are you leaving from?\n"
                              + "\n1) Central"
                              + "\n2) Roma Street"
                              + "\n3) Milton"
                              + "\n4) Auchenflower"
                              + "\n5) Toowong"
                              + "\n6) Taringa"
                              + "\n\nEnter your option(1-6 or 0 to exit): ";

        static string arriveAt = "\n Which station are you going to?\n"
                           + "\n1) Roma Street"
                           + "\n2) Milton"
                           + "\n3) Auchenflower"
                           + "\n4) Toowong"
                           + "\n5) Taringa"
                           + "\n6) Indooroopilly"
                           + "\n\nEnter your option(1-6 or 0 to exit): ";


        // This method will then take the string from departFrom and ask the user for their input.
        static int Departfrom() {
            int userInput;
            bool okay;

            // Implementing the do while function which will ask the user for their departure selection. 
            do {
                Console.Write(departFrom);
                // The okay check whether the input is an intger, if not exit the program.
                okay = int.TryParse((Console.ReadLine()), out userInput);
                if (userInput > (int)Stations.Indooroopilly) {
                    
                }// end if

                else if (userInput == EXIT) {
                    return userInput;
                }// end else if

            // This while statement check if the condition is true, 
            //if so repeat the do while loop until userInput is less than (int)Stations.Indoorpilly
            } while (userInput > (int)Stations.Indooroopilly);
            return userInput;

        }// end Departfrom

        
        // This method acts the same as Departfrom() but asked the user for their arrival station.
        // It also uses the interger parametre taken from the DepartFrom(). This parametre will be used to check if
        // the user have input their arrival station wrongly depending on the Departing selection. 
        static int Arriveat(int UserInputFromDepart) {

            int userInput;
            bool okay;

            do {
                Console.Write(arriveAt);
                okay = int.TryParse((Console.ReadLine()), out userInput);

                // This if statment is there to repeat the do while loop if the user's input is larger than the given condition.

                // This else if statement is used for when the user want to quit the program gracefully before continuing.
                if (userInput == EXIT) {

                    return userInput = EXIT;
                }// end if

               // This if statement checks whether the userInput is less than the departing selection.
               // If so, print a discouraged message and exit the program. 
                else if (userInput < UserInputFromDepart) {

                    Console.WriteLine("\nYou cannot travel from {0} to {1},\n", (Stations)UserInputFromDepart, (Stations)userInput);

                    Console.Write("\t This enquiry is cancelled.");

                    return userInput = EXIT;
                }// end else if

                     // This else if statement check if the userInput is the same as the departing selection.
                     // If so it will print the message stating that the stations choosen are the same and therefore exit the program.
                else if (userInput == UserInputFromDepart) {

                    Console.WriteLine("\nYou have selected {0} as both your departure and arrival station\n", (Stations)userInput);

                    Console.WriteLine("\t this enquiry is cancelled");

                    return userInput = EXIT;

                }// end else if

            } while (userInput > (int)Stations.Indooroopilly);
            return userInput;
        }// end ArriveAt


        // This method is used to offset the departing selection. Since central isn't actually located in the number 1 of the array.
        // But in fact Central is located in the row number 0 in the array(timeTable).
        // Therefore the OFFSET is there to transform the result into the correct array placement.
        static int Userdepartstation(int UserInputFromDepart) {

            int whatstation = UserInputFromDepart;
            return whatstation - OFFSET;
            }// end Userdepartstaion


        // This method will then ask the user for their desired time to arrive at the arrival station
        static string Whattimeforarrive(int UserInputFromArrive) {
            string rawInput;
            
            // Making hoursAndMinutes into a string array which can be used as a mini list that will store the users input.
            string[] hoursAndMinutes;
            int hours, minutes, number, whatstation;

            whatstation = UserInputFromArrive;

            Console.Write("Enter the time you wish to be at {0} in 24 hour format <hh:mm>  ",
                (Stations)whatstation);
            rawInput = Console.ReadLine();

            // These line of code then takes the user input and split them into parts. The seperation of the colon, 
            // which was inputted by the user was able to make the split between hours and minutes.
            // The hoursAndMinutes array is then properly distrubuted by the hoursAndMinutes[0] which represents the hours.
            // hoursAndMinutes[1] which then represents the minutes.
            // Those hoursAndMinutes are still in their string format. Which mean int.Parse will convert them to intger.   
            hoursAndMinutes = rawInput.Split(':');
            hours = int.Parse(hoursAndMinutes[0]);
            minutes = int.Parse(hoursAndMinutes[1]);
            number = int.Parse(hoursAndMinutes[0] + hoursAndMinutes[1]);

            // This for loop then read through the timeTable from the first part of the array which is the station.
            for (int i = 0; i < timeTable.GetLength(0); i++) {

                // This nested for loop then continue from the previous loop which read the time of the train.
                for (int j = 0; j < timeTable.GetLength(1); j++) {

                    // This if statement is there to check whether the user number is less than the timeTable(time).
                    // If so print the error message and do a recursion to the current method which will then
                    // repeat the whole method process until the user enters the correct number.
                    if (number <= timeTable[UserInputFromArrive,j]) {

                        Console.WriteLine("\nYou cannot catch any train to arrive by {0} at {1}\n", rawInput, (Stations)whatstation);

                        Console.WriteLine("You will need to enter a later time.\n");

                        return Whattimeforarrive(UserInputFromArrive);

                    }//end if

                    // This if statement acts the same as above but its condition check whether the user input number
                    // is greater than the timetable time. As shown on the timeTable[1,2]. The varible in the 2 spot of the timeTable
                    // is using a public constant which makes up the number of column in the array.
                    // However, the OFFSET must also apply to the array since their starting value is always at 0.
                    if (number >= timeTable[UserInputFromArrive, NUMBER_OF_TRAINS - OFFSET]) {

                        Console.WriteLine("\nYou cannot catch any train to arrive by {0} at {1}\n", rawInput, (Stations)whatstation);

                        Console.WriteLine("You will need to enter a earlier time.\n");

                        return Whattimeforarrive(UserInputFromArrive);
                    
                    // Else, if the user's number isn't less than or greater than the time from the given array.
                    // then return the rawInput and continue on.
                    }else{
                        return rawInput;
                    }// end else

                }// for j

            }// for i

            // This line of code is there to stop the program from destroying itself.
            return null;
        }// end Whattimeforarrive

        // This method then take three parametre from the depart selection, arrival selection and the time
        static void Result(int station, int station2, string time) {
            // Using another split code to seperate the hours and minutes from the colon
            string[] HourAndMinute;
            string pm_OR_am;
            int hours, minutes, number;
            HourAndMinute = time.Split(':');
            hours = int.Parse(HourAndMinute[0]);
            minutes = int.Parse(HourAndMinute[1]);
            number = int.Parse(HourAndMinute[0] + HourAndMinute[1]);

            // An if statement checks whether the hours less then TWELVE.
            // If so return a string which will represent the time in "AM"
            // Else return the string as "PM" and make it into 12 hour format.
            if (hours <= TWELVE) {
                pm_OR_am = "am";

            }else{
                hours = hours - TWELVE;
                pm_OR_am = "pm";
            }//end else

            // A nested for loop which will read from the both the station number and time.
            for (int i = 0; i < timeTable.GetLength(0); i++) {
                for (int j = 0; j < timeTable.GetLength(1); j++) {
                    
                    // An if statement checking if number is less than the timeTable[station2, j].
                    // The station2 will be the row which is the number station.
                    // And j will be the column which is the time allocated for the station2.
                    // If it is less than, apply the offset to j and assign it to number.
                    if (number < timeTable[station2, j]) {
                        int catchhour, catchminute;

                        number = j - OFFSET;

                        Console.WriteLine("\nTo arrive at {0} by {1}:{2}{3}",
                            (Stations)station2,
                            hours,
                            HourAndMinute[1],
                            pm_OR_am);

                        // This bunch of code then departing time using a linear search method.
                        // similar to the if(number < timeTable[station2,j]).
                        // However replace the variable "station 2" and "j" with "station" and "number" 
                        // will give the recommended time for the departing station.
                        // The code then also convert the whole 4 digits and 3 digits into their retrospective
                        // hours and minutes with the help of modulo and integer division.
                        catchhour = timeTable[station, number] / HUNDRED;
                        catchminute = timeTable[station, number] % HUNDRED;

                        // Same code mentioned above which determine whether to add a PM or AM.
                        // However slight modification, made this code as a 24 hours to 12 hours convertor.
                        if (catchhour <= TWELVE) {

                        }else{
                            catchhour = catchhour - TWELVE;
                        }//end else

                        Console.WriteLine("\nyou need to catch the train from {0} at {1}:{2}{3}",
                            (Stations)station,
                            catchhour,
                            catchminute,
                            pm_OR_am);

                        return;
                    }//end if

                    // A similar else if mentioned above
                    // This else if statement check whether the user's number is correctly the same time
                    // as the timeTable[station2, j].
                    // If so, assign j as number and add NO OFFSET.
                    // Same repetition of the above statement. But only difference is there is a possiblity
                    // of getting the exact user's number as the timeTable. 
                    else if (number == timeTable[station2, j]) {
                        int catchhour, catchminute;

                        number = j;

                        Console.WriteLine("\nTo arrive at {0} by {1}:{2}{3}",
                            (Stations)station2,
                            hours,
                            HourAndMinute[1],
                            pm_OR_am);

                        catchhour = timeTable[station, number] / HUNDRED;
                        catchminute = timeTable[station, number] % HUNDRED;
                        if (catchhour <= TWELVE) {
                            
                        }else{
                            catchhour = catchhour - TWELVE;
                        }//end else

                        Console.WriteLine("\nyou need to catch the train from {0} at {1}:{2}{3}",
                            (Stations)station2,
                            catchhour,
                            catchminute,
                            pm_OR_am);
                        return;
                    }//end if

                }// for j

            }//for i

        }// end Result

        static void Main() {

            // ********** Do not remove the following statement ******************
            timeTable = Timetables.CreateTimeTable();
            //*********** Start your code for Main below this line  ******************
            int departselection, departnumber, arriveselection;
            string arrivetime;

            departselection = Departfrom();

            if (departselection == EXIT) {
                ExitProgram();
                return;
            }

            departnumber = Userdepartstation(departselection);

            arriveselection = Arriveat(departnumber);

            if (arriveselection == EXIT) {
                ExitProgram();
                return;
            }

            arrivetime = Whattimeforarrive(arriveselection);

            Result(departnumber, arriveselection, arrivetime);

            ExitProgram();

        }// end Main



        /// <summary>
        /// Will exit the project once the user has pressed any key
        /// </summary>
        static void ExitProgram() {
            Console.Write("\n\n\t Press any key to terminate program ...");
            Console.ReadKey();
        }//end ExitProgram





    }//end class
}//end nameSpace
