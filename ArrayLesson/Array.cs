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
        public Array(int[] array)
        {
            Length = array.Length;
            _array = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                _array[i] = array[i];
        }
        public int GetElementByIndex(int index)
        {
            if (index < 0 || index >= _array.Length)
                throw new IndexOutOfRangeException();
            return _array[index];
        }
        public void SetElementByIndex(int index, int value)
        {
            if (index < 0 || index >= _array.Length)
                throw new IndexOutOfRangeException();
            _array[index] = value;
        }
        public void Print()
        {
            foreach (int el in _array)
                Console.Write(el+" ");
        }
        public int this [int index]
        {
            get
            {
                return GetElementByIndex(index);
            }
            set
            {
                SetElementByIndex(index, value);
            }
        } 
        public void Swap(ref int i,ref int j)
        {
                int temp = i;
                i = j;
                j = temp;
        }
        public void BubbleSort()
        {
            for (int i = 0; i < _array.Length; i++)
               for (int j = i + 1; j < _array.Length - 1; j++)
                  if (_array[j] > _array[j + 1])
                     Swap(ref _array[j],ref _array[j + 1]);
        }
    }
}

