namespace PZ_12
{
    internal class Program
    {
        static int SumOfEvenElementsOnOddPositions(int[] arr)
        {
            int x = 0;
            for (int i = 1;  i < arr.Length; i += 2) 
            {
                if (arr[i] % 2 == 0)
                {
                    x += arr[i];
                }
            }
            return x;
        }
        static void Main(string[] args) 
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = SumOfEvenElementsOnOddPositions(array);
            Console.WriteLine(result);
        }
    }
}