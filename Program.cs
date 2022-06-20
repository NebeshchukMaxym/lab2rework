using System;

namespace Part2
{
    class Program
    {
        static void Main()
        {
            Aircompany aircompany = new Aircompany();
            PlaneBeechcraft beechcraft = new PlaneBeechcraft();
            PlaneMriya mriya = new PlaneMriya();
            PlaneHawker hawker = new PlaneHawker();
            aircompany.planeList.Add(beechcraft);
            aircompany.planeList.Add(mriya);
            aircompany.planeList.Add(hawker);
            Console.WriteLine("0 - Exit program\n1 - Total Capacity\n2 - Planes List Ordered By Max Flight Range\n3 - Find Planes With Fuel Consumption Within\n");
            int choice, i = 1;
            while(i != 0)
            {
                Console.Write("Action: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        i = 0;
                        break;
                    case 1:
                        aircompany.CountCapacity();
                        break;
                    case 2:
                        aircompany.SortByRange();
                        break;
                    case 3:
                        aircompany.FindByRange();
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }

        }
    }
}