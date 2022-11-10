using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Firstproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String firstName = tbFirstName.Text;
            String lastName = tbLastName.Text;
            lbWelcome.Text = "Hello " + firstName + " " + lastName;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            lbWelcome.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "";
        }
    }
}
