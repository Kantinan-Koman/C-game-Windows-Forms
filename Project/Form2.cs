using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        user US = new user();
        public Form2()
        {
            InitializeComponent();
        }
        string x = "";
        string y = "";
        private void btnregister2_Click(object sender, EventArgs e)
        {
            string user  = txtusername2.Text;
            string pass  = txtpassword2.Text;
            string con = txtConpassword.Text;

            if (pass == con )
            {
                y = user;
                x = pass;
                MessageBox.Show("Registration successfully");
                Form1 form1 = new Form1();
                form1.Datapass = x;
                form1.Datauser = y;
                this.Hide();
                form1.ShowDialog();
            }
            else if (pass != con)
            {
                MessageBox.Show("Password don't match");
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
