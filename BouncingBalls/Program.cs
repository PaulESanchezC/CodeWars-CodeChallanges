using System;
using System.Runtime.CompilerServices;

namespace BouncingBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = 30;
            const double bounce = 0.66;
            const double window = 1.5;

            BouncingBall bouncingBall = new BouncingBall();

            Console.WriteLine(bouncingBall.bouncingBall(height, bounce, window));
        }
    }

    public class BouncingBall
    {
        public int bouncingBall(double h, double bounce, double window)
        {
            if (h < 0 || window >= h || bounce < 0 || bounce >= 1)
                return -1;

            int bounceCounter = 0;

            while (true)
            {
                if (h >= window)
                {
                    bounceCounter++;  
                }
                
                var bounceHeight = h * bounce; 

                if (bounceHeight > window)
                {
                    bounceCounter++;
                    h = bounceHeight;
                }else break;
                
            }
            return bounceCounter;
        }
    }
}
