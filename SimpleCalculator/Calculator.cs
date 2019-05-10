using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Calculator
    {
        /// <summary>
        /// Add 2 nums
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// sub 2 nums
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Sub(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Mulitply 2 nums
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Mult(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Div 2 nums.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Div(int a, int b)
        {
            return a / b;
        }
    }
}
