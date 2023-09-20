using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbuildings
{
    internal class Building
    {
        //VARS
        protected int numberFloors;
        protected double width;
        protected double height;
        //CONSTRUCTOR
        public Building(int pFloors, double pWidth, double pHeight)
        {
            this.numberFloors = pFloors;
            this.width = pWidth;
            this.height = pHeight;
        }
        //GETTERS
        public int getNumberFloors()
        { return numberFloors; }
        public double getWidth()
        { return width; }
        public double getHeight()
        { return height; }

        //SETTERS
        public void setNumberFloors(int num)
        {
            if (num > 0) { numberFloors = num; }
            else { Console.WriteLine("floors must be >0"); }
        }
        public void setWidth(double num)
        {
            if (num > 0) { width = num; }
            else { Console.WriteLine("width must be >0"); }
        }
        public void setHeight(double num)
        {
            if (num > 0) { height = num; }
            else { Console.WriteLine("height must be >0"); }
        }
    }
}
