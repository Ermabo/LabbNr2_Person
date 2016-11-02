using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLabb2_Grumpy
{
    abstract class Person : IComparable<Person>
    {
        private string firstName;
        private string lastName;


        public int CompareTo(Person that)
        {

            return 2;
        }
    }
}
