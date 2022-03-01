using System;

namespace N2tl.Units.LiquidUnits
{
    public static class LiquidUnitBuilder
    {
        public static Milliliter Milliliters(this int milliliters) =>
            new Milliliter(milliliters);

        public static Milliliter Milliliters(this long milliliters) =>
            new Milliliter(milliliters);

        public static Milliliter Milliliters(this float milliliters) =>
            new Milliliter(Convert.ToDecimal(milliliters));

        public static Milliliter Milliliters(this double milliliters) =>
            new Milliliter(Convert.ToDecimal(milliliters));

        public static Milliliter Milliliters(this decimal milliliters) =>
            new Milliliter(milliliters);

        /********/

        public static Ounce Ounces(this int ounces) =>
            new Ounce(ounces);

        public static Ounce Ounces(this long ounces) =>
            new Ounce(ounces);

        public static Ounce Ounces(this float ounces) =>
            new Ounce(Convert.ToDecimal(ounces));

        public static Ounce Ounces(this double ounces) =>
            new Ounce(Convert.ToDecimal(ounces));

        public static Ounce Ounces(this decimal ounces) =>
            new Ounce(ounces);

        /********/

        public static Cup Cups(this int cups) =>
            new Cup(cups);

        public static Cup Cups(this long cups) =>
            new Cup(cups);

        public static Cup Cups(this float cups) =>
            new Cup(Convert.ToDecimal(cups));

        public static Cup Cups(this double cups) =>
            new Cup(Convert.ToDecimal(cups));

        public static Cup Cups(this decimal cups) =>
            new Cup(cups);

        /********/

        public static Liter Liters(this int liters) =>
            new Liter(liters);

        public static Liter Liters(this long liters) =>
            new Liter(liters);

        public static Liter Liters(this float liters) =>
            new Liter(Convert.ToDecimal(liters));

        public static Liter Liters(this double liters) =>
            new Liter(Convert.ToDecimal(liters));

        public static Liter Liters(this decimal liters) =>
            new Liter(liters);

        /********/

        public static Gallon Gallons(this int gallons) =>
            new Gallon(gallons);

        public static Gallon Gallons(this long gallons) =>
            new Gallon(gallons);

        public static Gallon Gallons(this float gallons) =>
            new Gallon(Convert.ToDecimal(gallons));

        public static Gallon Gallons(this double gallons) =>
            new Gallon(Convert.ToDecimal(gallons));

        public static Gallon Gallons(this decimal gallons) =>
            new Gallon(gallons);
    }
}