using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            Console.WriteLine("\n");
            try
            {
                Console.Write("Введите индекс: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Ваш эллемент массива: ");
                Console.WriteLine(array.GetElementByIndex(a));
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Не расстраивайся, это всего лишь IndexOutOfRangeExcaption");
                Console.WriteLine("\n");
                Console.WriteLine(ex.StackTrace);
            }
            try
            {
                Console.Write("Введите индекс эллемента: ");
                int Index = int.Parse(Console.ReadLine());
                Console.Write("Введите значение эллемента: ");
                int SetInt = int.Parse(Console.ReadLine());
                array.SetElementByIndex(Index, SetInt);
                Console.WriteLine("Ваш массив: ");
                array.Print();
                Console.WriteLine(" ");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Не расстраивайся, это всего лишь IndexOutOfRangeExcaption");
                Console.WriteLine("\n");
                Console.WriteLine(ex.StackTrace);
            }
            try
            {
                Console.Write("Введите индекс эллемента: ");
                int Index = int.Parse(Console.ReadLine());
                Console.Write("Введите значение эллемента: ");
                int SetInt = int.Parse(Console.ReadLine());
                arr[Index] = SetInt;
                Console.WriteLine("Ваш массив: ");
                array.Print();
                Console.WriteLine(" ");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Не расстраивайся, это всего лишь IndexOutOfRangeExcaption");
                Console.WriteLine("\n");
                Console.WriteLine(ex.StackTrace);
            }
            try
            {
                Console.Write("Введите индекс: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Ваш эллемент массива: ");
                Console.WriteLine(arr[a]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Не расстраивайся, это всего лишь IndexOutOfRangeExcaption");
                Console.WriteLine("\n");
                Console.WriteLine(ex.StackTrace);
            }
            Console.Write("Сортировка пузырьком: ");
            array.BubleSort();
            array.Print();
            Console.ReadKey();
        }
    }
}
