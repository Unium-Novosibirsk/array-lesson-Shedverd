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
                Console.Write("Введите элементы массива через проел: ");
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Array array = new Array(arr);
                Console.WriteLine("\n");
                Console.Write("Введите индекс: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(array.GetElementByIndex(a));
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Не расстраивайся, это всего лишь IndexOutOfRangeExcaption");
                Console.WriteLine("\n");
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
