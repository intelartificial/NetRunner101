using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course2.Interfaces;

namespace Course2.Classes
{
    public class AppleTree : IPlant
    {
        public List<Fruit> Fruits { get; set; }

        public void Harvest()
        {
            Console.WriteLine("Apple tree has been harvested");
        }

        public void Harvest(DateTime dateOfHarvest)
        {
            if (DateTime.Today > dateOfHarvest)
            {
                Console.WriteLine($"Has been harvest {(dateOfHarvest - DateTime.Today).Days} day(s) ago");
            }
            else
            {
                Console.WriteLine("Harvested");
            }
        }
    }
}
