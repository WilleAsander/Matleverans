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
    public partial class EditUser : Form
    {
        public static string Names;
        public static string SocialSecurity;
        public static string Adress;
        public static string Email;
        public static string PhoneNmr;
        public static int index;
        public static string Date;
        public EditUser()
        {
            InitializeComponent();
            index = Form1.customer.IndexOf(Form1.customer.Single(i => i.socialSec == Form1.selectedUser));
            Names = "";
            SocialSecurity = "";
            Adress = "";
            Email = "";
            PhoneNmr = "";
            Date = "";
            int currentIndex = -1;

            foreach(Customer c in Form1.customer)
            {
                currentIndex++;
                if (currentIndex == index)
                {
                    Name = c.name;
                    SocialSecurity = c.socialSec;
                    Adress = c.adress;
                    Email = c.email;
                    PhoneNmr = c.phone;
                    Date = c.date;
                    if(c.VIP == true)
                    {
                        checkBox1.Checked = true;
                    }
                }
            }

            textBox1.Text = Name;
            textBox2.Text = SocialSecurity;
            textBox3.Text = Adress;
            textBox4.Text = Email;
            textBox5.Text = PhoneNmr;
            button1.Text = ("Save");
            button1.Click += (Save);
            

        }

        private void Save(object sender, EventArgs e)
        {
            foreach (Customer c in Form1.customer)
            {
                if (c.socialSec == textBox2.Text)
                {
                    MessageBox.Show("This Social Security Number is already registered!");
                    return;
                }
            }
            Form1.customer.RemoveAt(index);
            Form1.customer.Add(new Customer
            {
                name = textBox1.Text,
                socialSec = textBox2.Text,
                adress = textBox3.Text,
                email = textBox4.Text,
                phone = textBox5.Text,
                VIP = checkBox1.Checked,
                date = Date
            });

            this.Close();
        }
    }
}
