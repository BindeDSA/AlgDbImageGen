using System;

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
            return side * Math.Cos(Math.PI * 45 / 180);
        }
    }
}
