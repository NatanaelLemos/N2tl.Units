using System;
using System.Globalization;

namespace N2tl.Units.LiquidUnits
{
    public class Ounce : Milliliter
    {
        private readonly decimal _ounces;

        internal Ounce(decimal milliliters)
            : base(milliliters)
        {
            _ounces = milliliters / Constants.OuncesToMilliliters;
        }

        public override decimal Decimal => _ounces;

        public override Ounce Ounces() => _ounces.Ounces();

        public override string ToString() => _ounces.ToString(CultureInfo.InvariantCulture);

        public static Ounce operator +(Ounce a, Ounce b) =>
            new Ounce(a._milliliters + b._milliliters);

        public static Ounce operator -(Ounce a, Ounce b) =>
            new Ounce(a._milliliters - b._milliliters);

        public static Ounce operator *(Ounce a, Ounce b) =>
            new Ounce(a._milliliters * b._milliliters);

        public static Ounce operator /(Ounce a, Ounce b) =>
            new Ounce(a._milliliters / b._milliliters);

        public static Ounce operator %(Ounce a, Ounce b) =>
            new Ounce(a._milliliters % b._milliliters);
    }
}