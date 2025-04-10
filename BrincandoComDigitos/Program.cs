namespace BrincandoComDigitos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DigPow(46288, 3));
        }

        public static long DigPow(int n, int p)
        {
           var aux = n.ToString();
           double total = 0;

           for(int i = 0; i < aux.Length; i++)
           {
           total += Math.Pow(double.Parse(aux[i].ToString()), p + i);
           }

           if(total % n == 0)
           {
                return (long)total / n;
           }

           return -1;
        }
    }
}
