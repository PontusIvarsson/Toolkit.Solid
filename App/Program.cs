using App._1_S;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new S();
            var s_followed = new S_Followed(new Output());
            s.ShowMePrinciple();
            s_followed.ShowMePrinciple();


            Console.ReadKey();
        }
    }
}
