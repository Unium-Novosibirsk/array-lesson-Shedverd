using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Array array = new Array(arr);
                Console.WriteLine(array.GetElementByIndex(1));
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeExcaption");
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
