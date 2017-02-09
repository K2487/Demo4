using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VahvistinApplication
{
    class Amplifier
    {
        private readonly int minVolume = 1;
        private readonly int maxVolume = 100;
        private int volume { get; set; }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= 100 && value >= 1)
                {
                    volume = value;
                }

                else if (value <= minVolume)
                {
                    Console.WriteLine("Too low volume - Amplifier volume is set to minimum : 0");
                    volume = minVolume;
                }
                else if (value >= maxVolume)
                {
                    Console.WriteLine("Too much volume -  Amplifier volume is set to maximum : 100");
                    volume = maxVolume;
                }
            }
        }
    }
}