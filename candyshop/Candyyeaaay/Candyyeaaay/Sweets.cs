using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyyeaaay
{
    class Sweets : CandyShop
    {
        public int HowManySugarNeeds;
        public int Price;
        public int Raise;
        public int Count;
        protected string SweetType;

        public void Raising(int percent)
        {
            Price += Price * Raise/100;
        }
        public void BuySugar(int Price)
        {
            Price--;
            sugar++;
        }
        public void CreatingSweets(string SweetType)
        {
            Count++;
            HowManySugarNeeds--;
        }
        public void Sell(string SweetType)
        {
            Count--;
            Price++;
        }
    }
}
