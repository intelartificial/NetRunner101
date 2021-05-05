using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course2.Classes;

namespace Course2.Interfaces
{
    public interface IPlant
    {
        List<Fruit> Fruits { get; set; }
        void Harvest();
        void Harvest(DateTime dateOfHarvest);

    }
}
