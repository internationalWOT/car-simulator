using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulatorHiq
{
  public class MonsterTruck : Car
    {
        public MonsterTruck(string height, string width, string direction) : base(height, width, direction)
        {
              
        }
      
        public override List<int> getPosition()
        {
            return base.getPosition();
        }
    }
}
