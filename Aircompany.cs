﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Aircompany
    {
        public List<IAirplane> planeList = new List<IAirplane>();
        public void CountCapacity()
        {
            int totalCapacity = 0, totalLoadCapacity = 0;
            foreach (IAirplane p in planeList)
            {
                totalCapacity += p.Capacity;
                totalLoadCapacity += p.LoadCapacity;
            }
            Console.WriteLine("Total capacity: " + totalCapacity);
            Console.WriteLine("Total load capacity: " + totalLoadCapacity);
        }
        public void SortByRange()
        {
            foreach (var p in planeList.OrderByDescending(p => p.FlightRange))
                Console.WriteLine($"{p.Name}: {p.FlightRange}");
        }
        public void FindByRange()
        {
            Console.WriteLine("Please, enter range start value: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter range end value: ");
            int end = Convert.ToInt32(Console.ReadLine());
            if (!start.Equals(null) || !end.Equals(null))
            {
                Console.WriteLine("Searching for planes...");
                int totalFuelConsumption = 0;
                foreach (IAirplane p in planeList)
                {
                    if (p.FuelConsumption >= start && p.FuelConsumption <= end)
                    {
                        Console.WriteLine($"{p.Name}: {p.FlightRange}");
                        totalFuelConsumption = p.FuelConsumption;
                    }

                }
                if (totalFuelConsumption == 0)
                {
                    Console.WriteLine("We don't have planes with fuel consumption in given range");
                }
            }
        }
        }
    }
        
    
