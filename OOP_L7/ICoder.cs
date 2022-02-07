using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L7
{
    internal interface ICoder
    {
        public void Encode(string in_str);
        public void Decode(string in_str);
    }
}
