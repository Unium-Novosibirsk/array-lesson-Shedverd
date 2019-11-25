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
            Console.Write("Введите элементы массива через пробел: ");
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array array = new Array(arr);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write("Сумма эллементов массива равна: ");
            Console.Write(array.Summ());
            Console.WriteLine(" ");
            Console.Write("Произведение эллементов массива равно: ");
            Console.Write(array.Mult());
            Console.WriteLine(" ");
            Console.Write("Минимальный эллемент массива равен: ");
            Console.Write(array.Max());
            Console.WriteLine(" ");
            Console.Write("Минимальный эллемент массива равен: ");
            Console.Write(array.Min());
            Console.WriteLine(" ");
            Console.Write("Сортировка эллементов пузырьковым методом: ");
            Console.WriteLine();
            Console.WriteLine("Получение эллемента масиива по индексу: ");
            try
            {
                
                Console.Write("Введите индекс: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ваш элемент: " + array.GetElementByIndex(a));
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Не расстраивайся, это всего лишь IndexOutOfRangeExcaption");
                Console.WriteLine("\n");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
