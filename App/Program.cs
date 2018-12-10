
using App._1;
using App._3_L;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            var l = new L(new Output());
            l.ShowPrinciple(new object[] { new SRP(), new OC(), new LISKOV() });



            Console.ReadKey();
        }
    }
}
