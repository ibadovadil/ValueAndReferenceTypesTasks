namespace ValueAndReferenceTypesTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, -8, -23, 23, 57, 56, 92, 4, 2 };
            TurnPositive(Array);

        }
        static void TurnPositive(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] *= -1;
                }
                Console.WriteLine(array[i]);
            }
        }
    }
}