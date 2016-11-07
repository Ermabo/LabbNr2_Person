using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLabb2_Grumpy
{
    public class Child : Person 
    {
        private string title = "Child";

        public Child(string fName, string lName)
            : base (fName, lName)
        {

        }



        public override string ToString()
        {
            return title + " " + base.GetName();
        }
    }
}
