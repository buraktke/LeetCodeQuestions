using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    internal class QParkingSystem
    {
        public int Big { get; set; }
        public int Medium { get; set; }
        public int Small { get; set; }

        public QParkingSystem(int big, int medium, int small)
        {
            Big = big;
            Medium = medium;
            Small = small;
        }

        public bool AddCar(int carType)
        {
            bool result = carType == 1 && Big > 0 ? true : (carType == 2 && Medium > 0 ? true : (carType == 3 && Small > 0 ? true : false));
            switch (carType)
            {
                case 1: 
                    Big--; 
                    break;
                case 2: 
                    Medium--; 
                    break;
                case 3: 
                    Small--; 
                    break;
            }
            return result;
        }
    }
}
