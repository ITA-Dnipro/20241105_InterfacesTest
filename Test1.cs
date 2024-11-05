using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241105_InterfacesTest
{
    public class Test1 : IContainer
    {
        private double[] _items = new double[] { 3.1, 5.3, 9.23 };

        public double GetItemByPosition(int position)
        {
            // validation
            if (position < 0 || position >= _items.Length)
            {
                return 0.0;    // throw 
            }

            return _items[position];
        }

        public double this[int position] 
        {
            get 
            {
                //// validation
                //if (position < 0 || position >= _items.Length)
                //{
                //    return 0.0;    // throw 
                //}

                //return _items[position];

                return GetItemByPosition(position);
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
    }
}
