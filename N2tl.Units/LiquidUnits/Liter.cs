using System;
using System.Globalization;

namespace N2tl.Units.LiquidUnits
{
    public class Liter : Cup
    {
        private readonly decimal _liters;

        internal Liter(decimal milliliters)
            : base(milliliters)
        {
            _liters = milliliters / Constants.LitersToMilliliters;
        }

        public override decimal Decimal => _liters;

        public override Liter Liters() => _liters.Liters();

        public override string ToString() => _liters.ToString(CultureInfo.InvariantCulture);

        public static Liter operator +(Liter a, Liter b) =>
            new Liter(a._milliliters + b._milliliters);

        public static Liter operator -(Liter a, Liter b) =>
            new Liter(a._milliliters - b._milliliters);

        public static Liter operator *(Liter a, Liter b) =>
            new Liter(a._milliliters * b._milliliters);

        public static Liter operator /(Liter a, Liter b) =>
            new Liter(a._milliliters / b._milliliters);

        public static Liter operator %(Liter a, Liter b) =>
            new Liter(a._milliliters % b._milliliters);
    }
}