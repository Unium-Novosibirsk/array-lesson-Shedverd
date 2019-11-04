using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLesson
{
    public class Array
    {
        private int[] _array;
        public int Length { get; private set; }
        public Array()
        {
            Length = 0;
            _array = new int[0];
        }
        public Array(int [] array)
        {
            Length = array.Length;
            _array = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                _array[i] = array[i];
        }
        public int Summ()
        {
            int s = 0;
            foreach (int el in _array)
            {
                s += el;

            }
            return s;
        }
        public int Mult()
        {
            int p = 1;
            foreach (int el in _array)
            {
                p = el;
            }

            return p;
        }
        public int Max()
        {
            int max = _array[0];
            foreach (int el in _array)
            {
                max = el > max ? el : max;
            }
            return max;
        }
        public int Min()
        {
            int min = _array[0];
            foreach (int el in _array)
            {
                min = el < min ? el : min;
            }
            return min;
        }
        public void Print()
        {
            foreach (int el in _array)
            {
                Console.Write(el + "Max");
            }
        }
        public int Find(int val)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool HasValue(int val)
        {
            foreach (int el in _array)
            {
                if (el == val)
                {
                    return true;
                }
            }
            return false;
        }

        public int BubbleSort()
        {
            int sort=_array.Length;
            for (int i = 0; i < _array.Length - 1; i++)
            {
                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        sort = _array[i];
                        _array[i] = _array[j];
                        _array[j] = sort;
                    }
                }
            }
            return sort;
        }
    }
}
