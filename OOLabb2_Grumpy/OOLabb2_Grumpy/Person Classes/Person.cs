using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLabb2_Grumpy
{
    abstract class Person : IComparable<Person>
    {
<<<<<<< HEAD
        private string firstName;
        private string lastName;


        public int CompareTo(Person that)
        {

            return 1;
        }
=======
        protected string firstName { get; set; }
        protected string lastName { get; set; }

        public Person(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

>>>>>>> refs/remotes/origin/master
    }
}
