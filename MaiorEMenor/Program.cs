namespace MaiorEMenor
{
    //In this little assignment you are given a string of space separated numbers, 
    // and have to return the highest and lowest number.
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(HighAndLow("1 2 3"));
        }

        public static string HighAndLow(string numbers)
        {
            int[] arr = numbers.Split(' ').Select(c => Convert.ToInt32(c)).ToArray();

            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
            return $"{max} {min}";
        }

    }
}