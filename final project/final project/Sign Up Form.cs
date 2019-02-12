using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Sign_Up_Form : Form
    {
        public Sign_Up_Form()
        {
            InitializeComponent();
        }

        private void Sign_Up_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if
            (txtEmail.Text == "")
            {
                MessageBox.Show("Email is a required field");
            }

         
            if 
                (txtUsername1.Text == "")
            {
                MessageBox.Show("Username is a required field");
            }
            if
             (txtpass.Text == "")

              if (txtConfirmPass.Text == "")
                {
                    MessageBox.Show("Please enter the password");
                }
            if (txtConfirmPass.Text != txtpass.Text)
            {
                MessageBox.Show("The passwords don't match!");
            }
            else
            {

                this.Hide();
                MainProfile ss = new MainProfile();
                ss.Show();
            }
        
        }
    }
}