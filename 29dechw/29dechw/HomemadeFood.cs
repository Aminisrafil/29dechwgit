using System;
using System.Collections.Generic;
using System.Text;

namespace _29dechw
{
    internal class HomemadeFood:Food
    {
        public HomemadeFood(int fat):base(fat)
        {

        }
        public override void ShowInfo()
        {
            
            Console.WriteLine($"Fat:{Fat}");
        }
    }
}
