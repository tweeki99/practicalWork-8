using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw8
{
    class RangeOfArray
    {
        private int _upperIndex;
        private int _lowerIndex;
        private int[] _array;

        public int this[int index]
        {
            get
            {
                return _array[index - _lowerIndex];
            }
            set
            {
                _array[index - _lowerIndex] = value;
            }
        }

        public RangeOfArray(int lowerIndex, int upperIndex)
        {
            _upperIndex = upperIndex;
            _lowerIndex = lowerIndex;
            _array = new int[_upperIndex - _lowerIndex + 1];          
        }

        public void InitArray()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = i;
            }
        }

        public void ShowArray()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write( _array[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
