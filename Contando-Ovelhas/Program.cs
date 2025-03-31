namespace Exercicios 
{
    //Consider an array/list of sheep where some sheep may be missing from their place.
    // We need a function that counts the number of sheep present in the array (true means present).
    public class ContandoOvelhas 
    {
        public static void Main(string[] args)
        {
            var sheeps = new bool[] { true, false, true };
            Console.WriteLine(CountSheeps(sheeps));
        }

        public static int CountSheeps(bool[] sheeps)
        {
            int aux = 0;

            for(int i = 0; i < sheeps.Length; i++)
            {
                if(sheeps[i] == true) aux++;
            }

            return aux;
        }
    }
}