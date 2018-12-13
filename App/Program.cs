
using App._1;
using App._4_SOLI_Followed;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            var l = new SOLI_Followed(new Output());
            l.ShowPrinciple(new object[] { new SRP(), new OC(), new LISKOV(), new ISP() });



            Console.ReadKey();
        }
    }
}
