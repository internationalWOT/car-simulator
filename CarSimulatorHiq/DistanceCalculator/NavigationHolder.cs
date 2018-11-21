using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarSimulatorHiq.DistanceCalculator
{
   public class NavigationHolder
    {
        public List<string> navigationExtractor(string inputParameters)
        {
        List<string> newList = new List<string>();
        var orderOfInput = inputParameters.ToUpper().Select(x => new string(x, 1)).ToArray();
            foreach (var item in orderOfInput)
            {
                newList.Add(item);
            }
        return newList;
        }
}
    }
