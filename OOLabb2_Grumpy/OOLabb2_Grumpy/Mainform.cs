﻿using System;
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
                personListbox.Items.Add(person.GetName());
            }

            personListbox.Items.Clear();
            foreach (Person p in personList)
            {
                personListbox.Items.Add(p);

            }
        }

        //public static Child operator+ (Male man, Female woman)
        //{
        //    personList.Add(new Child())
        //}

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
        //Whether they want to or not...
        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (var p in personListbox.SelectedItems)
            {
                personList.Remove((Person)p);
            }
            ReList();
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
