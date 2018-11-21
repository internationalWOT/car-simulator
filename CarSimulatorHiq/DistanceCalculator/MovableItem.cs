using CarSimulatorHiq.RoomHolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CarSimulatorHiq.DistanceCalculator
{
    class MovableItem : List<IMoveable>
    {

        private NavigationHolder navigationHolder = new NavigationHolder();
        private MonsterTruck _car;
        private TestRoomCoordantes _testRoom;

        public MovableItem(MonsterTruck car, TestRoomCoordantes room, string movementPattern)
        {
            _car = car;
            _testRoom = room;
            MapMovement(movementPattern);
            CheckMovementRange();
        }

        private bool CheckMovementRange()
        {
            if (_car.X >= _testRoom.X || _car.Y >= _testRoom.Y)
            {
                Console.WriteLine("Test failed, you hit the wall");
                return false;
            }
            else
            {
                Console.WriteLine($"test sucessful, the direction of the car is {_car._direction} and the position is Y = {_car.Y} and X = {_car.X}");
                return true;
            }

        }

        private void MapMovement(string movementInput)
        {
            var processedMovement = navigationHolder.navigationExtractor(movementInput);

            foreach (var item in processedMovement)
            {
               
                if (_car._direction.ToUpper().Contains("N"))
                {
                    MovementNorth(item);
                }
                else if (_car._direction.ToUpper().Contains("S"))
                {
                    MovementinSouth(item);
                }
                else if (_car._direction.ToUpper().Contains("W"))
                {
                    MovementinWest(item);
                }
                else if (_car._direction.ToUpper().Contains("E"))
                {
                    MovementinEast(item);
                }
               
            }

        }
        private void MovementinEast(string processedMovement)
        {

            if (processedMovement.Contains("F"))
            {
                _car.X += 1;
            }
            else if (processedMovement.Contains("B"))
            {
                _car.X -= 1;
            }
            else if (processedMovement.Contains("L"))
            {
                _car.Y += 1;
                _car._direction = _car._direction = "N";
            }
            else if (processedMovement.Contains("R"))
            {
                _car.Y -= 1;
                _car._direction = _car._direction = "S";
            }
        }


        private void MovementinWest(string processedMovement)
        {
            if (processedMovement.Contains("F"))
            {
                _car.X -= 1;
            }
            else if (processedMovement.Contains("B"))
            {
                _car.X += 1;
            }
            else if (processedMovement.Contains("L"))
            {
                _car.Y -= 1;
                _car._direction = _car._direction = "S";
            }
            else if (processedMovement.Contains("R"))
            {
                _car.Y += 1;
                _car._direction = _car._direction = "N";
            }
        }


        private void MovementinSouth(string processedMovement)
        {
            if (processedMovement.Contains("F"))
            {
                _car.Y -= 1;
            }
            else if (processedMovement.Contains("B"))
            {
                _car.Y += 1;
            }
            else if (processedMovement.Contains("L"))
            {
                _car.X += 1;
                _car._direction = _car._direction = "E";
            }
            else if (processedMovement.Contains("R"))
            {
                _car.X -= 1;
                _car._direction = _car._direction = "W";
            }
        }

        private void MovementNorth(string processedMovement)
        {

            if (processedMovement.Contains("F"))
            {
                _car.Y += 1;
            }
            else if (processedMovement.Contains("B"))
            {
                _car.Y -= 1;
            }
            else if (processedMovement.Contains("L"))
            {
                _car.X -= 1;
                _car._direction = _car._direction = "W";
            }
            else if (processedMovement.Contains("R"))
            {
                _car.X += 1;
                _car._direction = _car._direction = "E";
            }

        }

    }
}

