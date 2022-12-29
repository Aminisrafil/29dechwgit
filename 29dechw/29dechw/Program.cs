using System;

namespace _29dechw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FastFood burger = new FastFood(80);
            HomemadeFood badimcandolmasi = new HomemadeFood();

            Console.WriteLine(burger.ShowInfo());
        }
    }
}
