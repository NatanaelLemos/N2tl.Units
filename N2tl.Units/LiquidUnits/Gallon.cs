using System;
using System.Globalization;

namespace N2tl.Units.LiquidUnits
{
    public class Gallon : Liter
    {
        private readonly decimal _gallons;

        internal Gallon(decimal milliliters)
            : base(milliliters)
        {
            _gallons = milliliters / Constants.GallonsToMilliliters;
        }

        public override decimal Decimal => _gallons;

        public override Gallon Gallons() => _gallons.Gallons();

        public override string ToString() => _gallons.ToString(CultureInfo.InvariantCulture);

        public static Gallon operator +(Gallon a, Gallon b) =>
            new Gallon(a._milliliters + b._milliliters);

        public static Gallon operator -(Gallon a, Gallon b) =>
            new Gallon(a._milliliters - b._milliliters);

        public static Gallon operator *(Gallon a, Gallon b) =>
            new Gallon(a._milliliters * b._milliliters);

        public static Gallon operator /(Gallon a, Gallon b) =>
            new Gallon(a._milliliters / b._milliliters);

        public static Gallon operator %(Gallon a, Gallon b) =>
            new Gallon(a._milliliters % b._milliliters);
    }
}