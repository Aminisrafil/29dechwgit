using System;
using System.Collections.Generic;
using System.Text;

namespace _29dechw
{
    internal class FastFood : Food
    {
        public FastFood(int fat):base(fat)
        {

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Fat:{Fat}");
        }
    }
}
