using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2.Classes
{
    public class Pear : Fruit
    {
        public Pear() : base("Pear", 10, KnownColor.Green, true)
        {
        }

        public void Eat()
        {
            this.IsEdible = false;
        }
    }
}
