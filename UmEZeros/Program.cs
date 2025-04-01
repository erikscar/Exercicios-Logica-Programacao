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


        //ESSA É UMA FORMA, CONCATENAR OS NUMEROS EM UMA STRING E TRANSFORMAR EM BINÁRIO UTILIZANDO O Convert.ToInt32, QUE ACEITA UMA STRING E A BASE DE UM DETERMINADO NUMERO
        //  public static int binaryArrayToNumber(int[] BinaryArray)
        // {
        //   string binary = "";
        //   foreach(int i in BinaryArray)
        //   {
        //     binary += i;
        //   }
        //   return Convert.ToInt32(binary, 2);
        // }
    }
}