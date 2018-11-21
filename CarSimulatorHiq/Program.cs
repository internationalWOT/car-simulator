using CarSimulatorHiq.DistanceCalculator;
using CarSimulatorHiq.RoomHolder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace CarSimulatorHiq
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the car simulator");

                AnotherMainMethod();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        private static void AnotherMainMethod()
        {

            //not the nices soulution to creating a nice conversation flow. but it is properly validated. would have liked to make everything async as well if there was more time.


            Console.WriteLine("Input the size of the Testingroom");
            var length = Console.ReadLine();
            var gridsize = length.Split(" ");
            if (ValidatorClass.CheckIfNumber(length))
            {
                nextConversation(gridsize);

            }
            else
            {
                AnotherMainMethod();
            }
        }

        private static void nextConversation(string[] inputGrid)
        {
            Console.WriteLine("Input the starting position of the car. Also input which direction it's facing");
            var testroom = new TestRoomCoordantes(inputGrid[0], inputGrid[1]);
            var carLength = Console.ReadLine();
            var Carinfoinput = carLength.Split(" ");
            if (ValidatorClass.CheckStartingDirectionInput(carLength) && ValidatorClass.HeightVsHeight(inputGrid[1], Carinfoinput[0])
                      && ValidatorClass.LengthVSLength(inputGrid[0], Carinfoinput[0]))
            {
                var car = new MonsterTruck(Carinfoinput[0], Carinfoinput[1], Carinfoinput[2]);
                lastconversation(car, testroom);
            }
            else
            {
                nextConversation(inputGrid);
            }
        }

        private static void lastconversation(MonsterTruck car, TestRoomCoordantes room)
        {
            Console.WriteLine("input the movingpattern of your car. choose between 'F', 'B', 'L' and 'r'");
            var movementPattern = Console.ReadLine();
            if (ValidatorClass.CheckNavigationInput(movementPattern))
            {
                new MovableItem(car, room, movementPattern);
                Console.WriteLine("press 'any key in order to restart the test");
                Console.ReadKey();
                AnotherMainMethod();
            }
            else
            {
                lastconversation(car, room);
            }
        }
    }
}
