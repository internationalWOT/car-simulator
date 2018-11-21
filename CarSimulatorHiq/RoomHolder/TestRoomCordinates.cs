using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulatorHiq.RoomHolder
{
    public class TestRoomCoordantes
    {
        public int X { get; set; } // width
        public int Y { get; set; } //height
        public TestRoomCoordantes(string widthOfRoom, string heightOfRoom)
        {
            X = Int32.Parse(widthOfRoom);
            Y = Int32.Parse(heightOfRoom);


        }
    }
}
