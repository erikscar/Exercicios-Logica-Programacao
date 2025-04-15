namespace SomandoNumeros {
    class Program {
        public static void Main(string[] args)
        {
            double[] array = new double[]{1, 5.2, 4, 0, -1};
            
            Console.WriteLine(SumArray(array));
        }

        public static double SumArray(double[] array)
        {
            return array == null ? 0 : array.Sum();
        }
    }
}