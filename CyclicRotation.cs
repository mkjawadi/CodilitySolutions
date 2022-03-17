namespace CodilitySolutions
{
    public static class CyclicRotation
    {
        public static int[] Solution(int[] A, int K)
        {
            if (A.Length == K || A.Length == 0 || A.Length == 1 || K % A.Length == 0)
                return A;

            var tempArray = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                // we use % to make sure that index is not out of the array size.
                int index = (i + K) % A.Length;
                tempArray[index] = A[i];
            }

            return tempArray;
        }
    }
}