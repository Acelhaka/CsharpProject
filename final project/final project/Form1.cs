﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace final_project
{
   

    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up_Form ss = new Sign_Up_Form();
            ss.Show();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
    //    {
    //       SqlConnection con = new SqlConnection(@"Data Source=.\(LocalDB)\v11.0;AttachDbFilename=C:\Users\amar_\OneDrive\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");    
    //     SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username= '" + txtUsername.Text + " ' and Password = ' " + txtPassword.Text + " ' ", con);
    //        DataTable dt = new DataTable();
    //        sda.Fill(dt);
    //       if (dt.Rows[0][0].ToString() == "1")
  {
        if (txtUsername.Text == "")
        {   
             MessageBox.Show("Please check Username and Password");
        }
        else if (txtPassword.Text == "")
        {
             MessageBox.Show("Please check Username and Password");
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