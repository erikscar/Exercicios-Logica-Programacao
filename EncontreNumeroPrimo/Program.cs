namespace EncontreNumeroPrimo;

//Given an array of integers, find the one that appears an odd number of times.
//There will always be only one integer that appears an odd number of times.
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(FindIt([1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1]));
    }

    public static int FindIt(int[] seq)
    {

        for (int i = 0; i < seq.Length - 1; i++)
        {
            int counter = 0;

            for (int j = 0; j < seq.Length; j++)
            {
                if (seq[i] == seq[j])
                {
                    counter++;
                }
            }

            if (counter % 2 != 0)
                {
                    return seq[i];
                }
        }

        return -1;
    }
}