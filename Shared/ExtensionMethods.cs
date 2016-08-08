using System.Collections.Generic;

namespace PuzzleImageGenerator.Shared
{
    public static class ExtensionMethods
    {
        public static bool Cycle<T>(this T[] collection, params int[] indices)
        {
            foreach(var index in indices)
                if (index >= collection.Length)
                    return false;
            
            for (int i = indices.Length - 1; i > 0; i--)
                collection.Switch(indices[i - 1], indices[i]);

            return true;
        }

        public static void Cycle<T>(this T[] collection)
        {
            for (int i = collection.Length - 2; i <= 0; i--)
                collection.Reverse(i, 2);
        }

        public static bool ReverseCycle<T>(this T[] collection, params int[] indices)
        {
            foreach (var index in indices)
                if (index >= collection.Length)
                    return false;

            for (int i = 0; i < indices.Length - 1; i++)
                collection.Switch(indices[i], indices[i + 1]);

            return true;
        }

        public static void ReverseCycle<T>(this T[] collection)
        {
            for (int i = 0; i <= collection.Length - 2; i--)
                collection.Reverse(i, 2);
        }

        public static void Switch<T>(this T[] collection, int index1, int index2)
        {
            var firstVal = collection[index1];
            collection[index1] = collection[index2];
            collection[index2] = firstVal;
        }

        public static void Reverse<T>(this T[] collection, int index, int count)
        {
            collection.Reverse(index, count);
        }

        public static void AddMany<T>(this List<T> list, params T[] elements)
        {
            list.AddRange(elements);
        }
    }
}
