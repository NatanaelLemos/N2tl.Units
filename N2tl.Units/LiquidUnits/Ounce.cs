using System;
using System.Globalization;

namespace N2tl.Units.LiquidUnits
{
    public class Ounce : Milliliter
    {
        private readonly decimal _ounces;

        internal Ounce(decimal ounces)
            : base(ounces * Constants.OuncesToMilliliters)
        {
            _ounces = ounces;
        }

        public override decimal Decimal => _ounces;

        public override Ounce Ounces() => _ounces.Ounces();

        public override string ToString() => _ounces.ToString(CultureInfo.InvariantCulture);

        public static Ounce operator +(Ounce a, Ounce b) =>
            new Ounce(a._ounces + b._ounces);

        public static Ounce operator -(Ounce a, Ounce b) =>
            new Ounce(a._ounces - b._ounces);

        public static Ounce operator *(Ounce a, Ounce b) =>
            new Ounce(a._ounces * b._ounces);

        public static Ounce operator /(Ounce a, Ounce b)
        {
            if (b._ounces == 0)
            {
                throw new DivideByZeroException();
            }

            return new Ounce(a._ounces / b._ounces);
        }

        public static Ounce operator %(Ounce a, Ounce b) =>
            new Ounce(a._ounces % b._ounces);
    }
}