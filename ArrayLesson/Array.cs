﻿using System;
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
        public int GetElementByIndex(int index)
        {
            if (index >= _array.Length || index == 0)
                throw new IndexOutOfRangeException();
            int myGetIlement = _array[index];
            if (myGetIlement > _array[index] || myGetIlement == 0)
                throw new IndexOutOfRangeException();
            return myGetIlement;
        }
    }
}
