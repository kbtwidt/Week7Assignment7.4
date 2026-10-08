using System;
using System.Collections.Generic;
using System.Text;

namespace Week7Assignment7._4
{
    public class ParkingSystem
    {
        private int[] spaces;

        public ParkingSystem(int big, int medium, int small)
        {
            spaces = new int[] { 0, big, medium, small };
        }

        public bool AddCar(int carType)
        {
            if (spaces[carType] > 0)
            {
                spaces[carType]--;
                return true;
            }

            return false;
        }
    }
}
