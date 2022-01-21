using System;

namespace Course1
{
    class Program
    {
        public static Tree tree = new Tree();
        public static Pear pear1 = new Pear();


        static void Main(string[] args)
        {

            // See here, I am creating 3 objects with the same properties and functions but they are distinct.
            Pear pear2 = new Pear();
            Pear pear3 = new Pear(false, "Yellow", System.Drawing.KnownColor.Yellow);


            // These are pointer comparaisons because we didn't override both .Equals and == functions.
            Console.WriteLine($"pear1 is not the same object as pear2 : {pear1 == pear2}");
            Console.WriteLine($"pear1 is not the same object as pear3 : {pear1 == pear3}");
            Console.WriteLine($"pear2 is not the same object as pear2 : {pear2 == pear3}");
            Console.WriteLine($"Also, the colors are different, pear2 color : {pear2.Color}, pear3 Color: {pear3.Color}");

            Console.WriteLine();

            Console.WriteLine($"pear1 isFresh Value : {pear1.IsFresh}, pear2 isFresh Value : {pear2.IsFresh}, pear3 isFresh Value : {pear3.IsFresh}");

            Console.WriteLine("pear1 is being eaten");
            pear1.Eat();

            Console.WriteLine($"Action on pear1 doesn't affect the other objects. pear1 isFresh Value : {pear1.IsFresh}, pear2 isFresh Value : {pear3.IsFresh}, pear2 isFresh Value : {pear3.IsFresh}");
            Console.WriteLine();


            tree.Fruits = new Pear[3];
            tree.Height = 5;
            tree.Fruits[0] = pear1;
            tree.Fruits[1] = pear2;
            tree.Fruits[2] = pear3;

            ComparePear_Class(pear1);
            CompareTrees_Struct(tree);

            // Stopping the program so it doesn't stop when finish.
            Console.ReadLine();
        }

        public static void CompareTrees_Struct(Tree newTree)
        {

            Console.WriteLine($"Inital values : tree height = {tree.Height}, newTree height = {newTree.Height}");

            Console.WriteLine("Setting tree height to 5, newTree Height to 10");
            newTree.Height = 10;

            Console.WriteLine($"Notice that both tree are no longer hold the same values : tree height = {tree.Height}, newTree height = {newTree.Height}");
            // Struct are passed as shallow copies. Shallow Copy means that any values are copies (struct object) but any reference remains the same (i.e. class object)

            Console.WriteLine($"Here is the proof that sub-object aren't copied. The point equals for both trees.Fruits[0] return true");
            Console.WriteLine($" {newTree.Fruits[0] == tree.Fruits[0]}.");

            Console.WriteLine("This means that it is the same object as it is the same pointer.");
            // This is a pointer comparaison because we didn't override both .Equals and == function.

            Console.WriteLine();
        }

        public static void ComparePear_Class(Pear newPear)
        {
            Console.WriteLine($"Inital values : Pear1 isFresh = {pear1.IsFresh}, newPear = {newPear.IsFresh}");

            Console.WriteLine("Setting newPear.isFresh to true");
            newPear.IsFresh = true;

            Console.WriteLine($"Notice that both pear have the same values : Pear1 isFresh = {pear1.IsFresh}, newPear = {newPear.IsFresh}");
            // This is because class-object are pass as reference and not copied.

            Console.WriteLine();

        }
    }
}
