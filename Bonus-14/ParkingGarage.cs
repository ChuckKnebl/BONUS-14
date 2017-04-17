using Bonus_14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_14
{
    class ParkingGarage
    {
        
        //Add five levels to a list.
        //NOTE:  You call a level based on the index position in the levels list.
        List<Level> levels = new List<Level>()
        {
            new Level ("Level 1"),
            new Level ("Level 2"),
            new Level ("Level 3"),
            new Level ("Level 4"),
            new Level ("Level 5"),
        };

        
        public Level GetLevel(int index)
        {
            var firstLevel = levels.ElementAt(0);
            var secondLevel = levels.ElementAt(1);
            var thirdLevel = levels.ElementAt(2);
            var fourthLevel = levels.ElementAt(3);
            var fifthLevel = levels.ElementAt(4);
            Level l = levels[index];
            return l;
        }
    }
}
