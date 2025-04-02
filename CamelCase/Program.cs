using System;

namespace CamelCase
{
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("the_stealth_warrior"));
        }

        static string ToCamelCase(string str)
        {
            string aux = "";


            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == '-' || str[i] == '_')
                {
                    aux += str[i + 1].ToString().ToUpper();
                    i++;
                }
                else {
                    aux += str[i];
                }
            }
            return aux;

            // // string[] copyString = str.Split(['-', '_']);
            // string aux = copyString[0];

            // for(int i = 1; i < copyString.Length; i++)
            // {
            //   aux += char.ToUpper(copyString[i][0]);

            //   for(int j = 1; j < copyString[i].Length; j++)
            //   {
            //         aux += copyString[i][j];
            //   }
            // }

            // return aux;
        }
    }
}