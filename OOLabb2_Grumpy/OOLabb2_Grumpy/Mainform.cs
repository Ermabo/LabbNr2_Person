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
        System.Media.SoundPlayer scream = new System.Media.SoundPlayer("scream.wav");

        //Bool's to ensure the stability of this program. All hail the bool.
        private bool firstnameAcceptable, lastnameAcceptable, genderSelected, missingsoundwarned = false;

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


        //public static Child operator+ (Male man, Female woman)
        //{
        //    personList.Add(new Child())
        //}

        //Checks the creation textboxes, making sure they're not empty. If empty, the appropriate button will be disabled.
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

        //Adds a man. Or a woman.
        private void createButton_Click(object sender, EventArgs e)
        {

            if (manRadio.Checked)
            {
                personList.Add(new Male(firstnameTextbox.Text, lastnameTextbox.Text));
            }
            else
            {
                personList.Add(new Female(firstnameTextbox.Text, lastnameTextbox.Text));
            }

            ReList();

        }

        //Removes people.
        //Whether they want to or not..
        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (var p in personListbox.SelectedItems)
            {
                personList.Remove((Person)p);
            }
            try
            {
                scream.Play();
            }
            catch (Exception ex)
            {
                if (missingsoundwarned == false)
                {
                    System.Media.SystemSounds.Question.Play();
                    MessageBox.Show(ex.Message + "\n" + "\"scream.wav\" ska finnas i samma plats som .exe-filen körs." + "\n\nDenna varning visas bara en gång.");
                    missingsoundwarned = true;
                }
                else
                {
                    System.Media.SystemSounds.Question.Play();
                }
            }
            ReList();
        }

        //Clears the searchbox
        private void buttonClear_Click(object sender, EventArgs e)
        {
            searchTextbox.Text = "";
        }
        //Sorts the list.
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

        //Adds some victi... I mean volunteers for testing the program.
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

        //Creates a child. Birds and bees you know?
        private void mergeButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        
    }
}
