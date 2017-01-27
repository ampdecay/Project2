using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2_Daigle
{
    class aCoin : aRandomNumberGenerator
    {
        /// <summary>
        /// constructor that does not seed the RNG
        /// sets range of 0 - 1
        /// </summary>
        public aCoin() : base(0, 2)
        { }
        /// <summary>
        /// constructor that  does seed RNG
        /// sets range of 0 - 1
        /// </summary>
        /// <param name="seed"></param>
        public aCoin(int seed) : base(0, 2, seed)
        { }

        /// <summary>
        /// returns "Coin"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Coin";
        }
    }
}
