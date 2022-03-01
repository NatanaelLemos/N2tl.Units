using FluentAssertions;
using N2tl.Units.LiquidUnits;
using Xunit;

namespace N2tl.Units.Tests
{
    public class CrossUnitsTests
    {
        [Fact]
        public void OuncePlusMilliliterShouldReturnMilliliter()
        {
            var ounces = 3.Ounces();
            var milliliters = 5.Milliliters();

            var result = ounces + milliliters;
            result.Should().Be(93.7205.Milliliters());
        }

        [Fact]
        public void OuncePlusOunceShouldReturnOunce()
        {
            var ounces1 = 3.Ounces();
            var ounces2 = 2.Ounces();

            var result = ounces1 + ounces2;
            result.Should().Be(5.Ounces());
            result.Milliliters().Should().Be(147.8675.Milliliters());
            result.Milliliters().Ounces().Should().Be(147.8675.Milliliters());
        }

        [Fact]
        public void CupsPlusOuncesShouldReturnOunces()
        {
            var cups = 3.Cups();
            var ounces = 5.Ounces();

            var result = cups + ounces;
            result.Should().Be(29.Ounces());
        }

        [Fact]
        public void CupsPlusMillilitersShouldReturnMilliliters()
        {
            var cups = 3.Cups();
            var milliliters = 10.Milliliters();

            var result = cups + milliliters;
            result.Should().Be(719.764.Milliliters());
        }

        [Fact]
        public void CupsShouldBeComparableToMilliliters()
        {
            var cups = 3.Cups().Milliliters().Cups();
            cups.Should().Be(3.Cups());
            cups.Should().Be(709.764.Milliliters());
        }

        [Fact]
        public void LitersPlusLitersShouldBeLiters()
        {
            var result = 3.Liters() + 9.Liters();
            result.Should().Be(12.Liters());
            result.Milliliters().Should().Be(12000.Milliliters());
        }

        [Fact]
        public void CastAll()
        {
            var result = 8045.Milliliters().Ounces().Cups().Liters().Gallons()
                .Liters().Cups().Ounces().Milliliters();
            result.Should().Be(8044.986556805.Milliliters());
        }
    }
}