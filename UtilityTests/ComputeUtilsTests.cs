namespace ComputeUtilsTests
{
    public class ComputeUtilsTests
    {
        [Fact]
        public static void ComputePiWithMonteCarloTest()
        {
            int precision = 2;
            double expected = 3.141592653589793238462643383279502884197169399375105820974944592307816406286;
            double actual = ComputeUtils.ComputePiwithMonteCarlo(100000000);

            expected = Math.Round(expected, precision);
            actual = Math.Round(actual, precision);

            Assert.Equal(expected, actual);
        }
    }
}