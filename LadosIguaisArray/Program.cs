namespace La
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(FindEvenIndex([1, 2, 3, 4, 3, 2, 1]));
        }

        public static int FindEvenIndex(int[] arr)
        {
          for(int i = 0; i < arr.Length; i++)
          {
            int left = 0;
            int right = 0;

            for(int j = 0; j < i; j++)
            {
                left += arr[j];
            }

            for(int j = i + 1; j < arr.Length; j++)
            {
                right += arr[j];
            }

            if(left == right) return i;

          }
          return -1;
        }
        
    }
}