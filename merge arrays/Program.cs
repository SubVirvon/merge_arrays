using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merge_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[] {"1", "2", "1"};
            string[] array2 = new string[] { "3", "2" };
            List<string> result = new List<string>();

            AddArrayToList(array1, result);
            AddArrayToList(array2, result);

            foreach (var element in result)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }

        static void AddArrayToList(string[] array, List<string> list)
        {
            for(int i = 0; i < array.Length; i++)
            {
                bool isMeet = list.Contains(array[i]);

                if(isMeet == false)
                {
                    list.Add(array[i]);
                }
            }
        }
    }
}
