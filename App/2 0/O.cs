using System;
using System.Collections.Generic;
using System.Text;

namespace App._2_0
{

    class S_Followed_O
    {
        private Output output;

        public S_Followed_O(Output output)
        {
            this.output = output;
        }

        public void ShowMePrinciple(object[] principles)
        {
            foreach (var item in principles)
            {
                if(item is SRP)
                {
                    output.WriteLine(((SRP)item).Name);
                    output.WriteLine(((SRP)item).Description);
                }
                else if(item is OC)
                {
                    output.WriteLine(((OC)item).Name);
                    output.WriteLine(((OC)item).Description);
                }

            }
        }
    }

    public class SRP
    {
        public string Name = "Single Responsibility Principle(SRP)";
        public string Description = string.Format("SRP says: {0}", "Every software module should have only one reason to change");
    }

    public class OC
    {
        public string Name = "Open/Closed Principle";
        public string Description = string.Format("The Open/closed Principle says: {0}", "A software module /class is open for extension and closed for modification");
    }

    public class Output
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
