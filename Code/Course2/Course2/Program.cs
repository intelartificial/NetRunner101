using System;
using System.Drawing;
using Course2.Classes;
using Course2.Interfaces;

namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit("Tomato", 10, KnownColor.Red, true);
            // Uncomment this line and see that C# doesn't allow the default construct has we have definited at least one constructor.
            //fruit = new Fruit();

            Pear pear1 = new Pear();
            // This is the oposite of the first example. You cannot call a constructor this undefinited or definited only on the parent.
            //pear1 = new Pear("Pear", 10, KnownColor.Green, true);

            AsianPear asianPear = new AsianPear();
            Console.WriteLine(asianPear.ToString());
            Console.WriteLine(asianPear.Origin);
            Console.WriteLine();

            // Here I am convecting back the asianPear into it parent class
            Pear pear2 = (Pear)asianPear;
            // See here that the method toString still keep the new implementation specific to AsianPear
            Console.WriteLine(pear2.ToString());
            //Now the following line is now throwing an error as the property hasn't been defined either on Fruit Class or the Pear Class
            //Console.WriteLine(pear2.Origin);

            //Here the normal Pear object is using the behavior defined in the Fruit object instead.
            Console.WriteLine(pear1.ToString());
            Console.WriteLine();

            //This is an example of using interface.
            IPlant plant = new Pyrus();
            plant.Harvest();
            plant.Harvest(DateTime.Today);
            plant.Harvest(DateTime.Today.AddDays(10));
            plant.Harvest(DateTime.Today.AddDays(-10));
            // Here I am trying to access a function undefined by the Interface. Visual studio won't let me compile this line.
            //Console.WriteLine(plant.GetLocation());
            // But this line does work as we are casting first into the proper object.
            Console.WriteLine(((Pyrus)plant).GetLocation());
            Console.WriteLine();


            // Now see the difference with the appletree interface.
            var appleTree = new AppleTree();

            // Here is checkin if the appletree does implement the interface IPlant
            if (appleTree is IPlant)
            {
                // This casting into IPlant. 
                plant = (IPlant)appleTree;

                plant.Harvest();
                plant.Harvest(DateTime.Today);
                plant.Harvest(DateTime.Today.AddDays(10));
                plant.Harvest(DateTime.Today.AddDays(-10));
                Console.WriteLine();

            }

            //Here plant should be an appleTree. But we don't know the base type.
            //So we are trying to cast it into a Pyrus
            Pyrus applePear = plant as Pyrus;

            // If the conversion failed, there won't be an error but the value will be null
            if (applePear != null)
            {
                // See are it isn't been run.
                applePear.Harvest();
                applePear.Harvest(DateTime.Today);
                applePear.Harvest(DateTime.Today.AddDays(10));
                applePear.Harvest(DateTime.Today.AddDays(-10));
            }

            //But this casting will fail at runtime
            applePear = (Pyrus)plant;

        }
    }
}
