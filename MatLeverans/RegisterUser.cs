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
    public partial class RegisterUser : Form
    {

        public RegisterUser()
        {
            InitializeComponent();
            button1.Text = ("Register!");

            button1.Click += new EventHandler(DoRegister);

        }

        private void DoRegister(object sender, EventArgs e)
        {



            //List<Customer> customer = new List<Customer>() { register.Add(name, socialSec, adress, email, phone, VIP, id, date) };
            /*string name = (textBox1.Text);
            string socialSec = (textBox2.Text);
            string adress = (textBox3.Text);
            string email = (textBox4.Text);
            string phone = (textBox5.Text);
            bool VIP = (checkBox1.Checked);
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            int id = 1;*/
            Form1.customer.Add(new Customer
            {
                name = (textBox1.Text),
                socialSec = (textBox2.Text),
                adress = (textBox3.Text),
                email = (textBox4.Text),
                phone = (textBox5.Text),
                VIP = (checkBox1.Checked),
                date = DateTime.Now.ToString("MM/dd/yyyy"),
            });

            RegisterUser customerlist = new RegisterUser();
            customerlist.Show();
            this.Hide();
        }
    }
}
