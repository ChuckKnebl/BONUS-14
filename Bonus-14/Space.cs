using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_14
{
    // Declare class Space to implement interface IVehicle.
    class Space
    {
        private bool isFilled = false;
        private int size;
        private IVehicle parkedVehicle;


        public Space(int s)
        {
            // 0 is small;
            // 1 is medium space;
            // 2 is large space.
            // ints will make doing size comparisons easier.
            // First if statement determines if space is small.
            // Second else if statement determines if space is medium.
            // Third else if statement determines if space is large.
            if (s < 3 && s >= 0)
            {

                size = s;
            }
            else if (s < 3 && s >= 1)
            {
                size = s;

            }
            else if (s < 3 && s >= 2)
            {
                size = s;
            }

            else
            {
                size = -1;
                Console.WriteLine("Invalid size given to space.");
            }  
        }
        public bool Park(IVehicle v)
        {
            if(isFilled == true)
            {
                Console.WriteLine("Parking space is already filled.");
                return false;
            }

            else
            {
                if (v.GetSize() <= GetSize())
                {
                    isFilled = true;
                    parkedVehicle = v;
                }
            }
            return true;
        }

        public int GetSize()
        {
            return size;
        }

        public static implicit operator Space(int v)
        {
            throw new NotImplementedException();
        }

        
    }

}




