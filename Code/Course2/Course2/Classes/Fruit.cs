using System.Drawing;

namespace Course2.Classes
{
    public class Fruit
    {
        /// <summary>
        /// Color of the fruit
        /// </summary>
        public KnownColor Color { get; }

        /// <summary>
        /// Can we eat the fruit
        /// </summary>
        public bool IsEdible { get; set; }

        /// <summary>
        /// Name of the fruit
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Volume of the fruit in centimeter cubed
        /// </summary>
        public int Volume { get; }

        /// <summary>
        /// This is the only constructor for this object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="volume"></param>
        /// <param name="color"></param>
        /// <param name="isEdible"></param>
        public Fruit(string name, int volume, KnownColor color, bool isEdible)
        {
            Name = name;
            Volume = volume;
            Color = color;
            IsEdible = isEdible;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}