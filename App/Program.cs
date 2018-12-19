
using App._1;
using App._5_SOLID_Followed;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            var l = new SOLID_Followed(new Output());
            l.ShowPrinciple(new object[] { new SRP(), new OC(), new LISKOV(), new ISP(), new DIP() });

            Console.ReadKey();
        }
    }
}
