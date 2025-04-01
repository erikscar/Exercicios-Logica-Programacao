namespace UmEZeros
{
    class Program {
        public static void Main(string[] args)
        {
            int[] Test = new int[] {0,1,0,1};
            Console.WriteLine(binaryArrayToNumber(Test));
        }

        public static int binaryArrayToNumber(int[] array)
        {
            int convertNumber = 0;
            for(int i = 0; i < array.Length; i++)
            {
                int pow = (int)Math.Pow(2, array.Length - i - 1);

                convertNumber += array[i] *  pow;
            }
            return convertNumber;
        }
    }
}