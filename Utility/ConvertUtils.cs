namespace Utility
{
    public class ConvertUtils
    {
        public static double MilesToKilometers(double miles)
        {
            return miles * 1.609344;
        }

        public static double KilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371192;
        }

        public static double CelsusToFarenheit(double celsus)
        {
            return celsus * 9 / 5 + 32;
        }

        public static double FarenheitToCelsus(double farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }

    }
}