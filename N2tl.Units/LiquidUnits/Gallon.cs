using System;
using System.Globalization;

namespace N2tl.Units.LiquidUnits
{
    public class Gallon : Liter
    {
        private readonly decimal _gallons;

        internal Gallon(decimal gallons)
            : base(gallons * Constants.GallonsToLiters)
        {
            _gallons = gallons;
        }

        public override decimal Decimal => _gallons;

        public override Gallon Gallons() => _gallons.Gallons();

        public override string ToString() => _gallons.ToString(CultureInfo.InvariantCulture);

        public static Gallon operator +(Gallon a, Gallon b) =>
            new Gallon(a._gallons + b._gallons);

        public static Gallon operator -(Gallon a, Gallon b) =>
            new Gallon(a._gallons - b._gallons);

        public static Gallon operator *(Gallon a, Gallon b) =>
            new Gallon(a._gallons * b._gallons);

        public static Gallon operator /(Gallon a, Gallon b)
        {
            if (b._gallons == 0)
            {
                throw new DivideByZeroException();
            }

            return new Gallon(a._gallons / b._gallons);
        }

        public static Gallon operator %(Gallon a, Gallon b) =>
            new Gallon(a._gallons % b._gallons);
    }
}