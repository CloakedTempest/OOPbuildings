using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbuildings
{
    internal class House : Building
    {
        //VARS
        private int bedrooms;
        private int bathrooms;
        //CONSTRUCTOR
        public House(int pFloors, double pWidth, double pHeight, int pBedrooms, int pBathrooms) : base(pFloors, pWidth, pHeight)
        {
            this.bedrooms = pBedrooms;
            this.bathrooms = pBathrooms;
        }
        //GETTERS
        public int getBedrooms()
        { return bedrooms; }
        public int getBathrooms()
        { return bathrooms; }

        //SETTERS
        public void setBedrooms(int num)
        {
            if (num > 0) { bedrooms = num; }
            else { Console.WriteLine("bedrooms must be >0"); }
        }
        public void setBathrooms(int num)
        {
            if (num > 0) { bathrooms = num; }
            else { Console.WriteLine("bathrooms must be >0"); }
        }
    }
}
