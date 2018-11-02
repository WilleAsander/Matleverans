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
        public static int Index;
        public Form1()
        {
            InitializeComponent();

            register = new Customer();
            customer = new BindingList<Customer>();
            button1.Text = ("Register");
            button2.Text = ("Edit");
            button3.Text = ("Delete");
            button4.Text = ("Search");
            textBox1.Text = ("Social security number...");
            label1.Text = ("Status: ");
            listBox1.DataSource = customer;
            button1.Click += new EventHandler(DoRegister);
            button2.Click += new EventHandler(Edit);
            button3.Click += new EventHandler(Delete);
            button4.Click += new EventHandler(Search);
            textBox1.GotFocus += new EventHandler(RemoveText);
            textBox1.LostFocus += new EventHandler(AddText);

        }

        

        private void DoRegister(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();

        }

        private void Edit(object sender, EventArgs e)
        {
            selectedUser = listBox1.GetItemText(listBox1.SelectedItem);
            foreach (Customer c in customer)
            {
                if (c.socialSec == selectedUser)
                {
                    RegisterUser registerUser = new RegisterUser();
                    registerUser.Close();
                    EditUser editUser = new EditUser();
                    editUser.Show();
                    listBox1.SelectedItems.Clear();
                    return;
                }
            }
            MessageBox.Show("You need an item selected!");


        }

        private void Delete(object sender, EventArgs e)
        {
            selectedUser = listBox1.GetItemText(listBox1.SelectedItem);
            foreach(Customer c in customer)
            {
                if(c.socialSec == selectedUser)
                {
                    Index = customer.IndexOf(customer.Single(i => i.socialSec == selectedUser));
                    customer.RemoveAt(Index);
                    return;
                }
            }
            MessageBox.Show("You need an item selected!");
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = ("Social security number...");
            }
        }

        private void RemoveText(object sender, EventArgs e)
        {
            textBox1.Text = ("");
        }

        private void Search(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
            int currentIndex = -1;
            foreach (Customer c in customer)
            {
                currentIndex++;
                if (c.socialSec == textBox1.Text)
                {
                    
                    Index = customer.IndexOf(customer.Single(i => i.socialSec == textBox1.Text));
                    listBox1.SetSelected(Index, true);
                    label1.Text = "Status: " + listBox1.SelectedItems.Count.ToString() + " items found";
                    return;
                }
            }
            label1.Text = "Status: 0 items found";

        }
    }
}
