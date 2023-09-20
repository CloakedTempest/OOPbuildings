using System;

namespace OOPbuildings
{
    internal class Office : Building
    {
        //VARS
        private int numDesks;
        private int numCompanies;
        //CONSTRUCTOR
        public Office(int pFloors, double pWidth, double pHeight, int pNumDesks, int pNumCompanies) : base(pFloors, pWidth, pHeight)
        {
            this.numDesks = pNumDesks;
            this.numCompanies = pNumCompanies;
        }
        //GETTERS
        public int getNumDesks()
        { return numDesks; }
        public int getNumCompanies()
        { return numCompanies; }

        //SETTERS
        public void setNumDesks(int num)
        {
            if (num > 0) { numDesks = num; }
            else { Console.WriteLine("desks must be >0"); }
        }
        public void setNumCompanies(int num)
        {
            if (num > 0) { numCompanies = num; }
            else { Console.WriteLine("companies must be >0"); }
        }
    }
}
