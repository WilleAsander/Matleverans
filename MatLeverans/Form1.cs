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
        public static string selectedUser;
        public Form1()
        {
            InitializeComponent();

            register = new Customer();
            customer = new BindingList<Customer>();
            button1.Text = ("Register");
            button2.Text = ("Edit");
            listBox1.DataSource = customer;
            button1.Click += new EventHandler(DoRegister);
            button2.Click += new EventHandler(Edit);


        }

        private void DoRegister(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();

        }

        private void Edit(object sender, EventArgs e)
        {
            selectedUser = listBox1.GetItemText(listBox1.SelectedItem);
            RegisterUser registerUser = new RegisterUser();
            registerUser.Close();
            EditUser editUser = new EditUser();
            editUser.Show();
            
        }
    }
}
