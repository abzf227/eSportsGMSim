using System;

public class GaussianRandom //i stole this from chatgpt bro why isnt there like a built-in one
    {
        private Random rand;

        public GaussianRandom()
        {
            rand = new Random();
        }

        public double NextGaussian(double mean = 0, double stdDev = 1)
        {
            // Box-Muller transform
            double u1 = 1.0 - rand.NextDouble(); // avoid zero
            double u2 = rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                                Math.Cos(2.0 * Math.PI * u2);
            return mean + stdDev * randStdNormal;
        }
    }