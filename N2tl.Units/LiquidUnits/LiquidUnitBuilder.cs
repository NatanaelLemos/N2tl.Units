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
            new Ounce(ounces * Constants.OuncesToMilliliters);

        public static Ounce Ounces(this long ounces) =>
            new Ounce(ounces * Constants.OuncesToMilliliters);

        public static Ounce Ounces(this float ounces) =>
            new Ounce(Convert.ToDecimal(ounces) * Constants.OuncesToMilliliters);

        public static Ounce Ounces(this double ounces) =>
            new Ounce(Convert.ToDecimal(ounces) * Constants.OuncesToMilliliters);

        public static Ounce Ounces(this decimal ounces) =>
            new Ounce(ounces * Constants.OuncesToMilliliters);

        /********/

        public static Cup Cups(this int cups) =>
            new Cup(cups * Constants.CupsToMilliliters);

        public static Cup Cups(this long cups) =>
            new Cup(cups * Constants.CupsToMilliliters);

        public static Cup Cups(this float cups) =>
            new Cup(Convert.ToDecimal(cups) * Constants.CupsToMilliliters);

        public static Cup Cups(this double cups) =>
            new Cup(Convert.ToDecimal(cups) * Constants.CupsToMilliliters);

        public static Cup Cups(this decimal cups) =>
            new Cup(cups * Constants.CupsToMilliliters);

        /********/

        public static Liter Liters(this int liters) =>
            new Liter(liters * Constants.LitersToMilliliters);

        public static Liter Liters(this long liters) =>
            new Liter(liters * Constants.LitersToMilliliters);

        public static Liter Liters(this float liters) =>
            new Liter(Convert.ToDecimal(liters) * Constants.LitersToMilliliters);

        public static Liter Liters(this double liters) =>
            new Liter(Convert.ToDecimal(liters) * Constants.LitersToMilliliters);

        public static Liter Liters(this decimal liters) =>
            new Liter(liters * Constants.LitersToMilliliters);

        /********/

        public static Gallon Gallons(this int gallons) =>
            new Gallon(gallons * Constants.GallonsToMilliliters);

        public static Gallon Gallons(this long gallons) =>
            new Gallon(gallons * Constants.GallonsToMilliliters);

        public static Gallon Gallons(this float gallons) =>
            new Gallon(Convert.ToDecimal(gallons) * Constants.GallonsToMilliliters);

        public static Gallon Gallons(this double gallons) =>
            new Gallon(Convert.ToDecimal(gallons) * Constants.GallonsToMilliliters);

        public static Gallon Gallons(this decimal gallons) =>
            new Gallon(gallons * Constants.GallonsToMilliliters);
    }
}