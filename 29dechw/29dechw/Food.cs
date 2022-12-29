using System;
using System.Collections.Generic;
using System.Text;

namespace _29dechw
{
    internal abstract class Food
    {
        public Food(int fat)
        {
            Fat = fat;
        }
        public int Fat;

        public abstract void ShowInfo();
        
        
    }
}
