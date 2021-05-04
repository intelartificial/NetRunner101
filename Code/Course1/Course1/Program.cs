using System;

namespace Course1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pear pear1 = new Pear();
            Pear pear2 = new Pear();
            Pear pear3 = new Pear(false, "Yellow", System.Drawing.KnownColor.Yellow);

            Console.WriteLine($"pear1 is not the same object as pear2 : {pear1 == pear2}");
            Console.WriteLine($"pear1 is not the same object as pear3 : {pear1 == pear3}");
            Console.WriteLine($"pear2 is not the same object as pear2 : {pear2 == pear3}");
            Console.WriteLine();

            Console.WriteLine($"pear1 isFresh Value : {pear1.IsFresh}, pear2 isFresh Value : {pear2.IsFresh}, pear3 isFresh Value : {pear3.IsFresh}");

            pear1.Eat();

            Console.WriteLine($"Action on pear1 doesn't affect the other objects. pear1 isFresh Value : {pear1.IsFresh}, pear2 isFresh Value : {pear3.IsFresh}, pear2 isFresh Value : {pear3.IsFresh}");

            Console.ReadLine();
        }
    }
}
