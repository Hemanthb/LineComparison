using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Line
    {
        
        public double getLength(double x1,double y1,double x2,double y2)
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
            return result;
        }
        public Boolean CheckLengthEquality(double length1,double length2)
        {
            return length1 == length2;
        }
        public void CompareLength(double length1, double length2)
        {
            if (length1 == length2)
            {
                Console.WriteLine("Length1- {0} and Length2 - {1} are equal", length1, length2);
            }
            else if (length1 < length2)
            {
                System.Console.WriteLine("Length1- {0} is less than Length2 - {1}", length1, length2);
            }
            else
            {
                Console.WriteLine("Length1- {0} is greater than Length2 - {1}", length1, length2);
            }
        }
    }
}
