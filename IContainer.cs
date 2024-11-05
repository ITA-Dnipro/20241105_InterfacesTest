using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241105_InterfacesTest
{
    // 1. definition
    public interface IContainer
    {
        public int Size { get; }

        public double this[int position] { get; set; }
    }
}
