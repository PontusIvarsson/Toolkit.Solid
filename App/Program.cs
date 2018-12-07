

using App._2_0;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            var l = new L(new Output());
            l.ShowPrinciple(new object[] { new SRP(), new OC()});



            Console.ReadKey();
        }
    }
}
