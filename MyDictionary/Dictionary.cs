using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary <B, E>
    {
        B[] _keyArray;
        E[] _valueArray;

        public MyDictionary()
        {
            _keyArray = new B[0];
            _valueArray = new E[0];
        }
        public void Add(B key, E value)
        {
            B[] tempKeyArray;
            E[] tempValueArray;

            tempKeyArray = _keyArray;
            tempValueArray = _valueArray;

            _keyArray = new B[_keyArray.Length];
            _valueArray = new E[_valueArray.Length];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                _keyArray[i] = tempKeyArray[i];
                _valueArray[i] = tempValueArray[i];
            }

            _keyArray[_keyArray.Length - 1] =key;
            _valueArray[_valueArray.Length - 1] = value;
        }
      

        public int Count
        {
            get { return _keyArray.Length; }
           
        }
        public B[] Keys
        {
            get { return _keyArray; }

        }
        public E[] Values
        {
            get { return _valueArray; }

        }
    }
}
