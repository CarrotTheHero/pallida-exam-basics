using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyyeaaay
{
    class CandyShop
    {
        int sugar = 300;
        int income = 100;
        int lollipops = 3;
        int candies = 3;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Inventory: {0} {1}, {2} {3}, Income: {4}$, Sugar: {5}gr", Count.candies, SweetType.Candies, Count.Lollipops, SweetType.Lollipops, income, sugar);
    }
}
