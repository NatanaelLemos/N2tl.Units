using System;
using System.Globalization;

namespace N2tl.Units.LiquidUnits
{
    public class Cup : Ounce
    {
        private readonly decimal _cups;

        internal Cup(decimal cups)
            : base(cups * Constants.CupsToOunces)
        {
            _cups = cups;
        }

        public override decimal Decimal => _cups;

        public override Cup Cups() => _cups.Cups();

        public override string ToString() => _cups.ToString(CultureInfo.InvariantCulture);

        public static Cup operator +(Cup a, Cup b) =>
            new Cup(a._cups + b._cups);

        public static Cup operator -(Cup a, Cup b) =>
            new Cup(a._cups - b._cups);

        public static Cup operator *(Cup a, Cup b) =>
            new Cup(a._cups * b._cups);

        public static Cup operator /(Cup a, Cup b)
        {
            if (b._cups == 0)
            {
                throw new DivideByZeroException();
            }

            return new Cup(a._cups / b._cups);
        }

        public static Cup operator %(Cup a, Cup b) =>
            new Cup(a._cups % b._cups);
    }
}