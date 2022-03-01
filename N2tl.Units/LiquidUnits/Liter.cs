using System;
using System.Globalization;

namespace N2tl.Units.LiquidUnits
{
    public class Liter : Cup
    {
        private readonly decimal _liters;

        internal Liter(decimal liters)
            : base(liters * Constants.LitersToCups)
        {
            _liters = liters;
        }

        public override decimal Decimal => _liters;

        public override Milliliter Milliliters() => (_liters * Constants.LitersToMilliliters).Milliliters();

        public override Liter Liters() => _liters.Liters();

        public override string ToString() => _liters.ToString(CultureInfo.InvariantCulture);

        public static Liter operator +(Liter a, Liter b) =>
            new Liter(a._liters + b._liters);

        public static Liter operator -(Liter a, Liter b) =>
            new Liter(a._liters - b._liters);

        public static Liter operator *(Liter a, Liter b) =>
            new Liter(a._liters * b._liters);

        public static Liter operator /(Liter a, Liter b)
        {
            if (b._liters == 0)
            {
                throw new DivideByZeroException();
            }

            return new Liter(a._liters / b._liters);
        }

        public static Liter operator %(Liter a, Liter b) =>
            new Liter(a._liters % b._liters);
    }
}