namespace Utility.Tests
{
    public class ConvertUtilsTests
    {
        [Fact()]
        public void CelsusToFarenheitTest()
        {
            double celsus = 10;
            double expected = 50;
            double actual = ConvertUtils.CelsusToFarenheit(celsus);
            if (expected != actual)
            {
                throw new Exception($"Expected {expected} but got {actual}");
            }
        }

        [Fact]
        public void FarenheitToCelsusTest()
        {
            double farenheit = 50;
            double expected = 10;
            double actual = ConvertUtils.FarenheitToCelsus(farenheit);
            if (expected != actual)
            {
                throw new Exception($"Expected {expected} but got {actual}");
            }
        }

        [Fact]
        public static void MilesToKilometersTest()
        {
            double miles = 10;
            double expected = 16.09344;
            double actual = ConvertUtils.MilesToKilometers(miles);
            if (expected != actual)
            {
                throw new Exception($"Expected {expected} but got {actual}");
            }
        }
        [Fact]
        public static void KilometersToMilesTest()
        {
            double kilometers = 10;
            double expected = 6.21371192;
            double actual = ConvertUtils.KilometersToMiles(kilometers);
            if (expected != actual)
            {
                throw new Exception($"Expected {expected} but got {actual}");
            }
        }
    }
}