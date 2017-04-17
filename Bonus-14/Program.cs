using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_14
{
    class Program
    {
        //This app will have five levels in a parking garage.
        //There will be 15 parking spaces on each level:  5 of size small (0), 5 of size medium (1)
        //and 5 of size large.    
        //Motorcycles can park in any of 75 spots (small, 25; medium, 25; large, 25).
        //Cars can park in any of any of 50 spots (medium, 25; or large, 25).
        //Buses can park in any of 25 large spots.
        //App will calculate how many spots of each type are filled and how many are empty.  
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to the CK Parking Garage App.");
                Console.WriteLine("There are 75 spaces for motorcycles, 50 spaces for cars and 25 large spaces for buses.");
                Console.WriteLine("What kind of vehicle would you like to park:  motorcycle, car or bus?");
                string input = Console.ReadLine();
            }
        }

                public static Boolean Continue()
        {
            bool run;
            Console.WriteLine("Would you like to continue searching for a parking spot? (y/n)");
            string answer = Console.ReadLine();

            if(answer == "y")
            {
                run = true;
            }
            else if (answer == "n")
            {
                run = false;
                Console.WriteLine("Good bye!");
            }
            else
            {
                Console.WriteLine("I'm sorry; I don't understand.  Let's try again, shall we.");
                run = Continue();
            }
            return run;
        }

    }
}

    

