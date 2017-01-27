using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2_Daigle
{
    class aDie : aRandomNumberGenerator
    {
        /// <summary>
        /// constructor that seeds the random number generator
        /// with time based seeding.
        /// sets range of 0 - 1
        /// </summary>
        public aDie() : base(1, 7)
        { }
        
        /// <summary>
        /// constructor that seeds the random number generator
        /// with the given seed
        /// sets range of 0 - 1
        /// </summary>
        /// <param name="seed"></param>
        public aDie(int seed) : base(1, 7, seed)
        { }
        
        /// <summary>
        /// returns "Die"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Die";
        }
    }
}
