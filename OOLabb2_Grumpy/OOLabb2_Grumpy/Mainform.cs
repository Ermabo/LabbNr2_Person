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
        public List<Person> MyList = new List<Person>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (firstnameTextbox.Text == "")
            {
                MessageBox.Show("Set firstname!");
            }
            if (lastnameTextbox.Text == "")
            {
                MessageBox.Show("Set lasname!");
            }
            if (manRadio.Checked == true)
            {
                sex = "man";
            }
            if (womanRadio.Checked == true)
            {
                sex = "woman";
            }

        }
    }
}
