using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLabb2_Grumpy
{
    public abstract class Person : IComparable<Person>
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Person(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

        public virtual string GetName()
        {
            return firstName + " " + lastName;
        }

        public static Child operator +(Person man, Person woman)
        {
            Random random = new Random();
            int nameChoice = random.Next(2);

            if(nameChoice == 2)
            {
                Child child = new Child(man.lastName, woman.lastName);
                return child;
            }
            else
            {
                Child child = new Child(woman.firstName, woman.lastName);
                return child;
            }
        }

        public int CompareTo(Person other)
        {

            // Alphabetic sort. [A to Z]

            if (this.lastName == other.lastName)
            {
                return this.firstName.CompareTo(other.firstName);
            }
            else
            {
                return this.lastName.CompareTo(other.lastName);
            }
        }
        public override string ToString()
        {
            // String representation.
            return this.lastName.ToString() + "," + this.firstName;
        }

    }
}
