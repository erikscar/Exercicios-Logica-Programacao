
namespace OrdemDecrescente {
    //Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order.
    //Essentially, rearrange the digits to create the highest possible number.
        class Program {
        public static void Main(string[] args)
        {
            Console.WriteLine(DescendingOrder(42145));
        }

        public static int DescendingOrder(int num)
        {
            var ordered = num.ToString().OrderByDescending(c => (int)c).ToList();
            var aux = "";

            for (int i = 0; i < ordered.Count(); i++)
            {
                aux += ordered[i];
            }
            return int.Parse(aux);
            //return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));

        }
        
    }
}