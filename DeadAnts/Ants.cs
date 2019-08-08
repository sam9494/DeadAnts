using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeadAnts
{
    class Ants
    {
        public static int CountDead(string antsString)
        {
            int countDead = 0;
            if (String.IsNullOrEmpty(antsString))
            {
                return 0;
            }
            var splitDeadAnts = Regex.Split(antsString, "ant");
            foreach (var i in splitDeadAnts)
            {
                if (i.Contains("a"))
                {
                    countDead++;
                }
            }
            return countDead;
        }
    }
}
