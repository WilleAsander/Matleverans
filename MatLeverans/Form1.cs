using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatLeverans
{
    public partial class Form1 : Form
    {
        private ICustomer register;

        public Form1()
        {
            InitializeComponent();

            register = new ICustomer();

            button1.Text = ("Register!");

            button1.Click += new EventHandler(DoRegister);

        }

        private void DoRegister(object sender, EventArgs e)
        {


            string name = (textBox1.Text);
            string socialSec = (textBox2.Text);
            string adress = (textBox3.Text);
            string email = (textBox4.Text);
            string phone = (textBox5.Text);
            bool VIP = (checkBox1.Checked);



        }
    }
}
