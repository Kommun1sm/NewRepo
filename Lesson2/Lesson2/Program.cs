using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        class StatisticsDigits
        {
            public StatisticsDigits()
            {
            }
            public StatisticsDigits(int b, int c)
            {
            }
            public int countNumbers(int i)
            {
                return (int)Math.Log10(i) + 1;
            }
            public int sumNumbers(int i)
            {
                int sum = 0;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                return sum;
            }

            static void Main(string[] args)
            {
            }
        }
    }
}
