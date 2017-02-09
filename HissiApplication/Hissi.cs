using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApplication
{
    class Elevator
    {
        private readonly int minFloor = 1;
        private readonly int maxFloor = 5;

        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= maxFloor && value >= minFloor) floor = value;

                else if (value > maxFloor)
                {
                    Console.WriteLine("That floor doesn't exist.");
                }
                else
                {
                    Console.WriteLine("That floor doesn't exist.");
                }
            }
        }
       

        public void Callout()
        {
            Console.WriteLine("The elevator is now in floor " + floor);
            Console.WriteLine();
        }
    }
}