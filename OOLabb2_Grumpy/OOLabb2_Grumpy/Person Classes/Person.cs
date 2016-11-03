using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLabb2_Grumpy
{
    public abstract class Person : IComparable<Person>
    {
        protected string firstName { get; set; }
        protected string lastName { get; set; }

        public Person(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

        public virtual string GetName()
        {
            return firstName + " " + lastName;
        }

        public int CompareTo(Person other)
        {
            return 2;
            // Alphabetic sort. [A to Z]

            if (this.lastName == other.lastName)
            {
                return this.firstName.CompareTo(other.firstName);
            }
            else
            {
                return this.lastName.CompareTo(other.lastName);
                //System.Windows.Forms.MessageBox.Show("Test");


                //MyPerson.Sort();
                //foreach (MyPerson.lastname in MyPerson)
                //    listbox.items.add()
            }
        }
    }
}
