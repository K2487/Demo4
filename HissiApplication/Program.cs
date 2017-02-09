using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            elevator.Floor = 1;

            int check = 0;
            while (check != 10)
            {
                elevator.Callout();
                Console.Write("Give a new floor numer (1-5) > ");
                string line = Console.ReadLine();
                elevator.Floor = int.Parse(line);
                check = int.Parse(line);

            }
            Console.WriteLine();
        }
    }
}