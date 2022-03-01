using System;
using System.Globalization;

namespace N2tl.Units.LiquidUnits
{
    public class Cup : Ounce
    {
        private readonly decimal _cups;

        internal Cup(decimal milliliters)
            : base(milliliters)
        {
            _cups = milliliters / Constants.CupsToMilliliters;
        }

        public override decimal Decimal => _cups;

        public override Cup Cups() => _cups.Cups();

        public override string ToString() => _cups.ToString(CultureInfo.InvariantCulture);

        public static Cup operator +(Cup a, Cup b) =>
            new Cup(a._milliliters + b._milliliters);

        public static Cup operator -(Cup a, Cup b) =>
            new Cup(a._milliliters - b._milliliters);

        public static Cup operator *(Cup a, Cup b) =>
            new Cup(a._milliliters * b._milliliters);

        public static Cup operator /(Cup a, Cup b) =>
            new Cup(a._milliliters / b._milliliters);

        public static Cup operator %(Cup a, Cup b) =>
            new Cup(a._milliliters % b._milliliters);
    }
}