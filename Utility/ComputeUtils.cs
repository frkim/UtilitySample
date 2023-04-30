namespace Utility
{
    public static class ComputeUtils
    {

        public static double ComputePiwithMonteCarlo(int numThrows)
        {
            Random rand = new Random();
            int numSuccess = 0;
            for (int i = 0; i < numThrows; i++)
            {
                double x = rand.NextDouble();
                double y = rand.NextDouble();
                if (x * x + y * y <= 1)
                {
                    numSuccess++;
                }
            }
            return 4.0 * numSuccess / numThrows;
        }

    }
}
