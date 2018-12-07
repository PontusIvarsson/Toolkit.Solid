using System;
using System.Collections.Generic;
using System.Text;

namespace App._2_0
{

    class L
    {
        private Output output;

        public L(Output output)
        {
            this.output = output;
        }

        public void ShowPrinciple(object[] principles)
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



}
