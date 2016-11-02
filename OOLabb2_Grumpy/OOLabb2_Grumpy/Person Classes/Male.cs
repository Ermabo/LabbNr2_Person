using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLabb2_Grumpy
{
    public class Male : Person  
    {
        private string title = "Mr";

        public Male(string fName, string lName)
            : base(fName, lName)
        {
        }

        public override string GetName()
        {
            return title + " " + base.GetName();
        }

    }
}
