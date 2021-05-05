using System.Drawing;

namespace Course1
{
    public class Pear
    {
        public bool IsFresh { get; set; }
        public string Color { get; }
        public KnownColor RgbColor { get; }

        /// <summary>
        /// Default Constructor if no argument are given. If no construct is defined, this one is used.
        /// </summary>
        public Pear()
        {
            IsFresh = true;
            Color = "Green";
            RgbColor = KnownColor.Green;
        }

        /// <summary>
        /// Custom Constructor that require argument to be given.
        /// </summary>
        /// <param name="isFresh"></param>
        /// <param name="color"></param>
        /// <param name="rgbColor"></param>
        public Pear(bool isFresh, string color, KnownColor rgbColor)
        {
            IsFresh = isFresh;
            Color = color;
            RgbColor = rgbColor;
        }

        public void Eat()
        {
            IsFresh = false;
        }
    }
}