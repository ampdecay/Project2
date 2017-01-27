using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2_Daigle
{
    class aGaussian : aRandomNumberGenerator
    {
        private int high;
        private int low;
        private aDie dice1 = new aDie();

        /// <summary>
        /// Property for getting the lowest value generated
        /// </summary>
        public override int Low
        {
            get { return low; }
        }

        /// <summary>
        /// Property for getting the highest value generated
        /// </summary>
        public override int High
        {
             get { return high - 1; }
        }

        /// <summary>
        /// constructor used to seed random number generator with 
        /// time based seeding
        /// </summary>
        public aGaussian() : base (1, 7)
        {
            low = 6;
            high = 37;
        }

        /// <summary>
        /// constructor used to seed the random number generator
        /// </summary>
        /// <param name="seed"></param>
        public  aGaussian(int seed) : base(1, 7, seed)
        {
            low = 6;
            high = 37;
        }

        /// <summary>
        /// sums up the results from rolling a dice six times
        /// </summary>
        /// <returns></returns>
        public override int Next()
        {
            int temp = 0;
            for (int i = 0; i < 6; ++i)
            {
                temp += dice1.Next();
            }
            return temp;
        }

        /// <summary>
        /// returns "Gaussian"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Gaussian";
        }
    }
}
