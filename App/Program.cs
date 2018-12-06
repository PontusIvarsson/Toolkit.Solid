

using App._2_0;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            var s_Followed_O = new S_Followed_O(new Output());
            s_Followed_O.ShowMePrinciple(new object[] { new SRP(), new OC()});



            Console.ReadKey();
        }
    }
}
