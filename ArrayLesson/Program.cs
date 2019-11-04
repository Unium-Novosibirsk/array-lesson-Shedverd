using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел");
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array array = new Array(arr);
            Console.WriteLine("Сумма этих чисел раывна:");
            Console.WriteLine(array.Summ());
            Console.WriteLine("Произведение этих чисел равно:");
            Console.WriteLine(array.Mult());
            Console.WriteLine("Максимальное число равно:");
            Console.WriteLine(array.Max());
            Console.WriteLine("Минимальное число равно:");
            Console.WriteLine(array.Min());
            Console.WriteLine("Сортировка пузырьком:");
            Console.WriteLine(array.BubbleSort());
            Console.ReadKey();
        }
    }
}
