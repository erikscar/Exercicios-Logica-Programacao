namespace RemovendoEspacos
{
    //Write a function that removes the spaces from the string, then return the resultant string.
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SpacesRemover("8 j 8   mBliB8g  imjB8B8  jl  B"));
        }

        public static string SpacesRemover(string input)
        {
            
            //return input.Replace(" ", "");
            string aux = "";
            for(int i = 0; i < input.Length; i ++)
            {
                if(input[i].ToString() != " ")
                {
                    aux += input[i];
                }
            }
            return aux;
        }
    }
}