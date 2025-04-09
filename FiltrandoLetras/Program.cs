using System.Linq;
using System.Text.RegularExpressions;

namespace FiltrandoLetras
{

    //In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
            var res = GetIntegersFromList(list);

            foreach (int item in res)
            {
                Console.Write(item + "");
            }
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < listOfItems.Count; i++)
            {
                if (listOfItems[i] is int)
                {
                    numbers.Add((int)listOfItems[i]);
                }
            }
            return numbers;

        }

    }
}
