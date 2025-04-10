namespace EncontreAgulha
{
    //Can you find the needle in the haystack?
    //Write a function findNeedle() that takes an array full of junk but containing one "needle"
    //After your function finds the needle it should return a message (as a string) that says:
    //"found the needle at position " plus the index it found the needle
    
    class Program
    {
        public static void Main(string[] args)
        {
            Object[] haystack = new Object[]{"junk", "more junk", new String("needle"), "gadget"};
            Console.WriteLine(FindNeedle(haystack));
        }

        public static string FindNeedle(object[] haystack)
        {
            // int index = 0;
            // for(int i = 0; i < haystack.Length; i++)
            // {
            //     if(Equals(haystack[i], "needle"))
            //     {
            //         index = i;
            //     }
            // }
            // return $"found the needle at position {index}";

            return $"found the needle at position {Array.IndexOf(haystack, "needle")}";
        }
    }
}