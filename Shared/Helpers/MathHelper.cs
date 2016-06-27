using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Shared.Helpers
{
    public static class MathHelper
    {
        public static double GetHypotenuse(double side1, double side2)
        {
            return Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
        }

        public static double GetHypotenuse(double side)
        {
            ///<summary>
            /// returns hypotenuse of a isosceles triangle of lenth side
            ///</summary>
            
            return side * Math.Cos(Math.PI * 45 / 180);
        }
    }
}
