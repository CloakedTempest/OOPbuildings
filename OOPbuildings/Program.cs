using System;

namespace OOPbuildings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = 10;
            double width = 100;
            double height = 500;
            int desks = 50;
            int companies = 3;
            int bedrooms = 9;
            int bathrooms = 20;
            Building building = new Building(floors, width, height);
            Console.WriteLine(building.getNumberFloors());

            Office office = new Office(floors, width, height, desks ,companies);
            Console.WriteLine(office.getHeight());

            House house = new House(floors, width, height, bedrooms, bathrooms);
            Console.WriteLine(house.getBedrooms());
        }
    }
}
