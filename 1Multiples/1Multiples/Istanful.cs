using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Multiples
{
    public static class Istanful
    {
        /// <summary>
        /// Returns a sum for a given progression in a given range. (Not geometrical)
        /// </summary>
        /// <param name="total">The range.</param>
        /// <param name="number">The delta number.</param>
        /// <returns></returns>
        static int SumFor(int total, int number, bool isInclusive = false)
        {
            int buffer = total;
            int sum = 0;
            int pair;

            // Check if there is only whole pairs in progression
            bool isWholePairs = ((buffer - (buffer % number)) / number) % 2 == 0;
            
            // Go to nearest multiple
            buffer -= buffer % number;

            // If there isn't only whole pairs add the biggest pair to the progression
            // and remove it from the buffer
            if (!isWholePairs)
            {
                pair = buffer;
                sum += pair;
                buffer -= number;
            }
            // If there is whole pairs only and method shouldn't include all numbers 
            // calculate pair size
            else if (!isInclusive)
                pair = (buffer % number) != 0 ? number + buffer : buffer - number;
            // If method includes all numbers calculate pair size
            else
                pair = buffer + number;

            // Calculate number of pairs and add to sum
            int pairs = (buffer / number) / 2;
            sum += pairs * pair;

            return sum;
        }

        /// <summary>
        /// Calculates subtraction for mutual numbers in progression.
        /// </summary>
        static int MutualSum(int total, int smallest, int biggest)
        {
            int step = smallest * biggest;
            return SumFor(total, 15, true);
        }

        /// <summary>
        /// Summarize all numbers in the progression
        /// </summary>
        /// <param name="total">Progression length</param>
        /// <returns></returns>
        public static int Sum(int total)
        {
            return SumFor(total, 3) + SumFor(total, 5) - MutualSum(total, 3, 5);
        }
    }
}
