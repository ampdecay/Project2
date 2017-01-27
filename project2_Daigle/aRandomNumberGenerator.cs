using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2_Daigle
{
    public class aRandomNumberGenerator : Random
    {
        private int high;
        private int low;


        /// <summary>
        /// Property for getting the lowest value generated
        /// </summary>
        virtual public int Low
        {
            get { return low; }
        }

        /// <summary>
        /// Property for getting the highest value generated
        /// </summary>
        virtual public int High
        {
            get { return high - 1; }
        }

        /// <summary>
        /// default constructor will set high to 10
        /// and low to 0 by default
        /// </summary>
        public aRandomNumberGenerator() : base()
        {
            high = 10;
            low = 0;
        }

        /// <summary>
        /// constructor used to set high and low values
        /// as well as set the seed
        /// </summary>
        /// <param name="lowest"></param>
        /// <param name="highest"></param>
        /// <param name="seed"></param>
        public aRandomNumberGenerator(int lowest, int highest, int seed) : base(seed)
        {
            low = lowest;
            high = highest;
        }

        /// <summary>
        /// constructor to set the high and low values
        /// calls the default constructor for rand class using
        /// time based seeding
        /// </summary>
        /// <param name="lowest"></param>
        /// <param name="highest"></param>
        public aRandomNumberGenerator(int lowest, int highest)
            : base()
        {
            low = lowest;
            high = highest;
        }

        /// <summary>
        /// overrides the next function of the Random class
        /// to only give numbers in the range specified
        /// </summary>
        /// <returns>next random integer in range</returns>
        public override int Next()
        {
            int val;
            val = this.Next(low, high);
            return val;
        }

        /// <summary>
        /// used to return values between 0 and 1 with 1 not being inclusive
        /// </summary>
        /// <param name="val"></param>
        /// <returns>value between 0.0 and 1.0</returns>
        public override int Next (int l)
        {
            return this.Next(0, l);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Random Number Generator</returns>
        public override string ToString()
        {
            return "Random Number Generator";
        }
            
    }
}
