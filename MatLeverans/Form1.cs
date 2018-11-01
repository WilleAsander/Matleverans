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
        public static BindingList<Customer> customer;
        public Form1()
        {
            InitializeComponent();

            register = new Customer();
            customer = new BindingList<Customer>();
            button1.Text = ("Register!");
            listBox1.DataSource = customer;
            button1.Click += new EventHandler(DoRegister);

        }

        private void DoRegister(object sender, EventArgs e)
        {



           

            RegisterUser customerlist = new RegisterUser();
            customerlist.Show();

        }
    }
}
