using System;
using System.Collections.Generic;
using System.Text;

namespace App._1
{

    /// <summary>
    /// Every software module should have only one reason to change.
    /// If we want to write to other output, the class does not need to change.
    /// </summary>
    class S_Followed
    {
        private Output output = new Output();
        
        public void ShowPrinciple()
        {
            output.WriteLine("Single Responsibility Principle (SRP)");
            output.WriteLine(string.Format("SRP says: {0}", "Every software module should have only one reason to change"));
        }
    }

    public class Output
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
