using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    class Building : SpaceCreator
    {
        public override House DisplayInfo(int houseNR)
        {
            if (houseNR == 22)
            {
                return new House(22, 5, "James Stone", 1);
            }
            else if (houseNR == 21)
            {
                return new House(21, 5, "Merry O'Brian", 1);
            }
            else if (houseNR == 23)
            {
                return new House(23, 5, "Tobby Ross", 1);
            }
            else
                return null;
        }
        public override Shop DisplayInfo1(int shopNR)
        {
            if (shopNR == 20)
            {
                return new Shop(20, "Tommy VanMag");
            }
            else
                return null;
        }
        public override Room DisplayInfo3(string roomType)
        {
            if (roomType == "Kuchnia")
            {
                return new Kitchen(123, 2, "Kuchnia");
            }
            else if (roomType == "Salon")
            {
                return new LivingRoom(123, 2, "Salon");
            }
            else if (roomType == "Przedpokój")
            {
                return new Hall(27, 0, "Przedpokój");
            }
            else if (roomType == "Łazienka")
            {
                return new Bathroom(67, 1, "Łazienka");
            }
            else if (roomType == "Sypialnia")
            {
                return new Bedroom(73, 2, "Sypialnia");
            }
            else
                return null;
        }
    }
}
