namespace Somando_Numeros
{
    //Given two integers a and b, which can be positive or negative, 
    // find the sum of all the integers between and including them and return it. 
    // If the two numbers are equal return a or b.
    //Note: a and b are not ordered!
    class SomandoNumeros
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Final: " + GetSum(0, 1));
        }

        public static int GetSum(int a, int b)
        {
            int aux = 0;

            if(a == b)
            {
                return a;
            }

            if (b < a)
            {
                while (a >= b)
                {
                    aux += b;
                    b++;

                }
            }
            else
            {
                while (b >= a)
                {
                    aux += a;
                    a++;
                }
            }
            return aux;
        }
    }
}