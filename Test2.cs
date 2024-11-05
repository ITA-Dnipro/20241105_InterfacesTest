using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241105_InterfacesTest
{
    public struct Test2: IContainer, IEnumerable<double>
    {
        private double[] _items;

        public Test2(params double[] items)
        {
            _items = (double[])items.Clone();
        }

        public double this[int position]
        {
            get
            {
                // validation
                if (position < 0 || position >= _items.Length)
                {
                    return 0.0;    // throw 
                }

                return _items[position];
            }
            set
            {
                _items[position] = value;
            }
        }

        public int Size
        {
            get
            {
                return _items.Length;
            }
        }

        public IEnumerator<double> GetEnumerator()
        {
            // (1)
            //for (int i = 0; i < _items.Length; i++)
            //{
            //    yield return _items[i];
            //}

            // (2)
            return new Test2Iterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                yield return _items[i];
            }
        }

        private struct Test2Iterator : IEnumerator<double>
        {
            private Test2 _source;
            private int _pos;

            public Test2Iterator(Test2 source)
            {
                _source = source;
                _pos = -1;
            }

            public double Current
            {
                get 
                {
                    return _source._items[_pos];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return _source._items[_pos];
                }
            }

            public void Dispose()
            {
                //throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                _pos++;

                return _pos < _source._items.Length;
            }

            public void Reset()
            {
                _pos = -1;
            }
        }
    }
}
