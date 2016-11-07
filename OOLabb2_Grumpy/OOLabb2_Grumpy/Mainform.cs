using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOLabb2_Grumpy
{
    public partial class MainForm : Form
    {
        //Bool's to ensure the stability of this program. All hail the bool.
        private bool firstnameAcceptable, lastnameAcceptable, genderSelected = false;

        static List<Person> personList = new List<Person>();

        public MainForm()
        {
            InitializeComponent();
            createButton.Enabled = false;
        }

        //Regenerates the list, with IMPUNITY
        public void ReList()
        {
            personListbox.Items.Clear();
            foreach (Person person in personList)
            {
                personListbox.Items.Add(person);
            }
        }



        //Checks the creation textboxes, making sure they're not empty. If empty, the "create human"-button will be disabled.
        private void firstnameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (firstnameTextbox.Text != "")
            {
                firstnameAcceptable = true;
                if ((firstnameAcceptable == true && lastnameAcceptable == true) && genderSelected == true)
                {
                    createButton.Enabled = true;
                }
                else
                {
                    createButton.Enabled = false;
                }
            }
            else
            {
                firstnameAcceptable = false;
                createButton.Enabled = false;
            }
        }
        private void lastnameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (lastnameTextbox.Text != "")
            {
                lastnameAcceptable = true;
                if ((firstnameAcceptable == true && lastnameAcceptable == true) && genderSelected == true)
                {
                    createButton.Enabled = true;
                }
                else
                {
                    createButton.Enabled = false;
                }
            }
            else
            {
                lastnameAcceptable = false;
                createButton.Enabled = false;
            }
        }
        //These just make sure that a radio button has been selected.
        private void manRadio_CheckedChanged(object sender, EventArgs e)
        {
            genderSelected = true;
            if ((firstnameAcceptable == true && lastnameAcceptable == true) && genderSelected == true)
            {
                createButton.Enabled = true;
            }
            else
            {
                createButton.Enabled = false;
            }
        }
        private void womanRadio_CheckedChanged(object sender, EventArgs e)
        {
            genderSelected = true;
            if ((firstnameAcceptable == true && lastnameAcceptable == true) && genderSelected == true)
            {
                createButton.Enabled = true;
            }
            else
            {
                createButton.Enabled = false;
            }
        }

        //Removes people.
        //Whether they want to or not..
        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (var p in personListbox.SelectedItems)
            {
                personList.Remove((Person)p);
            }
            ReList();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "")
            {
                buttonClear.Enabled = false;
            }
            else
            {
                buttonClear.Enabled = true;
            }
            string tmp = searchTextbox.Text;
            personListbox.Items.Clear();
            foreach (var item in personList)
            {
                if (item.firstName.ToLower().Contains(tmp.ToLower()))
                {
                    personListbox.Items.Add(item);
                }
                else if (item.lastName.ToLower().Contains(tmp.ToLower()))
                {
                    personListbox.Items.Add(item);
                }
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            searchTextbox.Text = "";
        }

        private void buttonAddSomePeople_Click(object sender, EventArgs e)
        {
            //Add some people to the empty listbox
            personListbox.Items.Clear();
            personList.Add(new Male("Steve", "Jobs"));
            personList.Add(new Female("Janet", "Jackson"));
            personList.Add(new Male("Andrew", "Loyd Webber"));
            personList.Add(new Female("Lucy", "Lou"));
            personList.Add(new Male("Bill", "Gates"));
            personList.Add(new Female("Christina", "Applegate"));
            personList.Add(new Male("Bing", "Crosby"));
            personList.Add(new Female("Amanda", "Bluebarry"));
            foreach (var item in personList)
            {
                personListbox.Items.Add(item);
            }

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            personListbox.Items.Clear();
            // Uses IComparable.CompareTo()
            personList.Sort();

            // Uses Employee.ToString
            foreach (var item in personList)
            {
                personListbox.Items.Add(item);
            }
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            if (personListbox.SelectedItems.Count == 2)
            {
                if (personListbox.SelectedItems[0] is Male && personListbox.SelectedItems[1] is Female)
                {
                    //personListbox.SelectedItems[0] + personListbox.SelectedItems[1]
                }
                else if(personListbox.SelectedItems[0] is Female && personListbox.SelectedItems[1] is Male)
                {

                }
            }

            //foreach (Person p in personListbox.SelectedItems)
            //{
            //    if (p is Male)
            //    {
                   
            //    }
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void createButton_Click(object sender, EventArgs e)
        {
            
            if (manRadio.Checked)
            {
                personList.Add(new Male (firstnameTextbox.Text, lastnameTextbox.Text));
            }
            else
            {
                personList.Add(new Female(firstnameTextbox.Text, lastnameTextbox.Text));
            }

            ReList();

        }
    }
}
