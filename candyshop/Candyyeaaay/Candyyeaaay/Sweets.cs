using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyyeaaay
{
    class Sweets
    {
        protected int HowManySugarNeeds;
        int Price;
        int Raise;

        public void Raising(int percent)
        {
            Price += Price * Raise/100;
        }
    }
}
