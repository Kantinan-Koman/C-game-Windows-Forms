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
    public partial class Form1 : Form
    {
        user US;
        public string Datapass { get; set; }
        public string Datauser { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user1 = Convert.ToString(txtusername.Text);
            string pass1 = Convert.ToString(txtPassword.Text);
            if(pass1 != this.Datapass ||  user1 !=this.Datauser)
            {
                
                MessageBox.Show("Password Wrong!");
            }
            if (pass1 == this.Datapass && user1 == this.Datauser) {
                Game form3 = new Game();
                this.Hide();
                form3.ShowDialog();
            
            }

         
       
        }
    }
}
