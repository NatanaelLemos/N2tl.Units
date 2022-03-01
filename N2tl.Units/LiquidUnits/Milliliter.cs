using System;
using System.Globalization;

namespace N2tl.Units.LiquidUnits
{
    public class Milliliter
    {
        protected readonly decimal _milliliters;

        internal Milliliter(decimal milliliters)
        {
            _milliliters = milliliters;
        }

        public virtual decimal Decimal => _milliliters;

        public Milliliter Milliliters() => _milliliters.Milliliters();

        public virtual Ounce Ounces() => new Ounce(_milliliters);

        public virtual Cup Cups() => new Cup(_milliliters);

        public virtual Liter Liters() => new Liter(_milliliters);

        public virtual Gallon Gallons() => new Gallon(_milliliters);

        public override bool Equals(object obj)
        {
            return (obj is Milliliter liquidUnit) && (liquidUnit._milliliters == _milliliters);
        }

        public override int GetHashCode()
        {
            return _milliliters.GetHashCode();
        }

        public override string ToString() => _milliliters.ToString(CultureInfo.InvariantCulture);

        public static Milliliter operator +(Milliliter a, Milliliter b) =>
            new Milliliter(a._milliliters + b._milliliters);

        public static Milliliter operator -(Milliliter a, Milliliter b) =>
            new Milliliter(a._milliliters - b._milliliters);

        public static Milliliter operator *(Milliliter a, Milliliter b) =>
            new Milliliter(a._milliliters * b._milliliters);

        public static Milliliter operator /(Milliliter a, Milliliter b)
        {
            if (b._milliliters == 0)
            {
                throw new DivideByZeroException();
            }

            return new Milliliter(a._milliliters / b._milliliters);
        }

        public static Milliliter operator %(Milliliter a, Milliliter b) =>
            new Milliliter(a._milliliters % b._milliliters);

        public static bool operator ==(Milliliter a, Milliliter b) =>
            a?.Equals(b) ?? false;

        public static bool operator !=(Milliliter a, Milliliter b) =>
            !a?.Equals(b) ?? false;

        public static bool operator <(Milliliter a, Milliliter b) =>
            a._milliliters < b._milliliters;

        public static bool operator <=(Milliliter a, Milliliter b) =>
            a._milliliters <= b._milliliters;

        public static bool operator >(Milliliter a, Milliliter b) =>
            a._milliliters > b._milliliters;

        public static bool operator >=(Milliliter a, Milliliter b) =>
            a._milliliters >= b._milliliters;
    }
}