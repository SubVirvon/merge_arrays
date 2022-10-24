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
            List<string> result = RemoveDuplicates(array1, array2);

            RemoveDuplicates(result);

            foreach(var element in result)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }

        static List<string> RemoveDuplicates(List<string> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for(int j = list.Count - 1; j > i; j--)
                {
                    if (list[j] == list[i])
                    {
                        list.RemoveAt(j);
                    }
                }
            }

            return list;
        }

        static List<string> RemoveDuplicates(string[] array1, string[] array2)
        {
            List<string> list1 = array1.ToList();
            List<string> list2 = array2.ToList();

            for(int i = 0; i < list2.Count; i++)
            {
                if (list1.IndexOf(list2[i]) == -1)
                {
                    list1.Add(list2[i]);
                }
            }

            return list1;
        }
    }
}
