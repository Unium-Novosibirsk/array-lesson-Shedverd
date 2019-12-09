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

                Console.WriteLine("Введите индекс: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ваш элемент: " + array.GetElementByIndex(a));
                Console.WriteLine("\n");
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
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Не расстраивайся, это всего лишь IndexOutOfRangeExcaption");
                Console.WriteLine("\n");
                Console.WriteLine(ex.StackTrace)
            }
                Console.Write("Введите индекс: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ваш элемент: " + array.GetElementByIndex(a));
                Console.WriteLine("\n");
                try
                {
                    Console.Write("Введите индекс: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Ваш эллемент массива: ");
                    Console.WriteLine(array.GetElementByIndex(b));
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
                    int f = int.Parse(Console.ReadLine());
                    Console.Write("Ваш эллемент массива: ");
                    Console.WriteLine(arr[f]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Не расстраивайся, это всего лишь IndexOutOfRangeExcaption");
                    Console.WriteLine("\n");
                    Console.WriteLine(ex.StackTrace);
                }
                Console.Write("Сортировка выбором: ");
                array.SelectionSort();
                array.Print();
                Console.WriteLine(" ");
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
            Console.Write("Сортировка вставками: ");
            array.InsertSort();
            array.Print();
            Console.WriteLine(" ");
            Console.Write("Введите идекс, который хотите удалить: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Ваш массив: ");
            array.DeleteElementByIndex(index);
            array.Print();
            Console.ReadKey();
        }
    }
}