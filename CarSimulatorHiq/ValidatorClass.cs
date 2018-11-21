using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CarSimulatorHiq
{
    public static class ValidatorClass
    {
        public static bool CheckIfNumber(string number)
        {
            Regex rx = new Regex("([1-9][0-9]* [1-9][0-9]*)");
            if (!rx.IsMatch(number))
            {
                Console.WriteLine("the only letters allowed are '0-9' when choosing size of the room, the size of the " +
                    "room cant start at zero. The size must be at least two numbers seperated by a 'blankspace'");
                return false;
            }
            return true;
        }
    
    
        public static bool CheckNavigationInput(string userInput)
        {
            Regex rx = new Regex("[frlb FRLB]");
            if (!rx.IsMatch(userInput))
            {
                Console.WriteLine("the only letters allowed are 'frlb' when navigating");
                return false;
            }
            return true;
        }
        public static bool CheckStartingDirectionInput(string userInput)
        {
            Regex rx = new Regex("([1-9][0-9]* [1-9][0-9]*) [swen SWEN]");
            if (!rx.IsMatch(userInput))
            {
                Console.WriteLine("the only letters allowed are 'swen' when choosing direction of the car, they must be preceded by two numbers, for example 1 1 s");
                return false;
            }
            return true;
        }
       

        public static bool HeightVsHeight(string roomYAxis, string carYAxis)
        {
            int roomSize = Int32.Parse(roomYAxis);
            int carPosition = Int32.Parse(carYAxis);
            if (roomSize <= carPosition)
            {
                Console.WriteLine("the starting postion of the car cant be outside or equal to the Y axis of the room(the height)");
                return false;
            }
            return true;

        }
        public static bool LengthVSLength(string roomXAxis, string carXaxis)
        {
            int roomSize = Int32.Parse(roomXAxis);
            int carPosition = Int32.Parse(carXaxis);
            if (roomSize <= carPosition)
            {
                Console.WriteLine("the starting postion of the car cant be outside or equal to the X axis of the room (the width)");
                return false;
            }
            return true;

        }


    }
}
