using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_14
{
    class Level
    {
        //NOTE:  You call a space based on the index position in the spaces array.
        int[] spaces = new int[15] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};

        public Space GetSpace(int index)
        {
            int spotOne;
            spotOne = spaces[0];
            int spotTwo;
            spotTwo = spaces[1];
            int spotThree;
            spotThree = spaces[2];
            int spotFour;
            spotFour = spaces[3];
            int spot5;
            spot5 = spaces[4];
            int spot6;
            spot6 = spaces[5];
            int spot7;
            spot7 = spaces[6];
            int spot8;
            spot8 = spaces[7];
            int spot9;
            spot9 = spaces[8];
            int spot10;
            spot10 = spaces[9];
            int spot11;
            spot11 = spaces[10];
            int spot12;
            spot12 = spaces[11];
            int spot13;
            spot13 = spaces[12];
            int spot14;
            spot14 = spaces[13];
            int spot15;
            spot15 = spaces[14];

            Space s = spaces[index];
            return s;
        }        

        private string v;
        public Level(string v)
        {
            this.v = v;
        }
    }
}
