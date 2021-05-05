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

        public Fruit(string name, int volume, KnownColor color, bool isEdible)
        {
            Name = name;
            Volume = volume;
            Color = color;
            IsEdible = isEdible;
        }
    }
}