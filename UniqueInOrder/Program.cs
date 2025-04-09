namespace UniqueInOrder
{
    //Implement the function unique_in_order which takes as argument a sequence and returns a list of items
    // without any elements with the same value next to each other and preserving the original order of elements.
    class Program
    {
        public static void Main(string[] args)
        {
            var res = UniqueInOrder("AAAABBBCCDAABBB");
            foreach(var item in res)
            {
                Console.Write(item + " ");
            }
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> listItems)
        {
            var list = listItems.ToList();
            var aux = new List<T>();

            for(int i = 0; i < list.Count - 1; i++) 
            {
                if(!Equals(list[i], list[i + 1])) {
                    aux.Add(list[i]);
                }
            }

            if(list.Count == 0) {
                return aux;
            }

            aux.Add(list[list.Count - 1]);
            
            return aux;
        }
    }
}