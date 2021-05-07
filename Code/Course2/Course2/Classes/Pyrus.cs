using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course2.Interfaces;

namespace Course2.Classes
{
    /// <summary>
    /// Represent a tree producing pears
    /// </summary>
    public class Pyrus : IPlant
    {
        public List<Fruit> Fruits { get; set; }
        public Pyrus()
        {

        }

        public void Harvest()
        {
            Console.WriteLine("Pear tree has been harvested");
        }

        public void Harvest(DateTime dateOfHarvest)
        {
            if (DateTime.Today >= dateOfHarvest)
            {
                Console.WriteLine("Harvested");
            }
            else
            {
                Console.WriteLine($"Will harvest in {(dateOfHarvest - DateTime.Today).Days}");
            }
        }

        public string GetLocation()
        {
            return "Canada";
        }
    }
}
