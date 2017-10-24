namespace PuzzleImageGenerator.Three.Helpers
{
    public class MathFunc
    {
        public static int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
    }
}
