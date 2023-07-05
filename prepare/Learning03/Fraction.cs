using System;
namespace Learning03
{

    public class Fraction
    {
        private int _above;
        private int _below;
        public Fraction()
        {
            _above = 1;
            _below = 1;
        }
        public Fraction(int WholeNumber)
        {
            _above = WholeNumber;
            _below = 1;
        }
        public Fraction(int above, int below)
        {
            _above = above;
            _below = below;
        }
        public string GetFraction()
        {
            string text = $"{_above}/{_below}";
            return text;
        }
        public double GetDecimal()
        {
            return (double)_above / (double)_below;
        }
    }
}