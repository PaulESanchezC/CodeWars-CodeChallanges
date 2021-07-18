namespace BouncingBalls
{
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