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
<<<<<<< HEAD
        private bool firstnameAcceptable, lastnameAcceptable, genderSelected = false;
=======
        public List<Person> MyList = new List<Person>();

>>>>>>> refs/remotes/origin/a
        public MainForm()
        {
            InitializeComponent();
            createButton.Enabled = false;
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string _firstname = firstnameTextbox.Text;
            string _lastname = lastnameTextbox.Text;
            string _sex;
            
            if (manRadio.Checked == true)
            {
                _sex = "man";
            }
            else
            {
                _sex = "woman";
            }
            MyList.Add(_firstname, _lastname, _sex);
        }
    }
}
