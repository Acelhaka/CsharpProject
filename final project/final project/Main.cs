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
    public partial class MainProfile : Form
    {
        public MainProfile()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to search for Chinese recipes?", "Visit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("http://www.chineserecipesforall.com/");
            }
        }
        private void btnCreateRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAddRecipe ss = new FrmAddRecipe();
            ss.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to search for American recipes?", "Visit",
               MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("http://www.myrecipes.com/american-recipes");
            }
        }

        private void btnItalianchefs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to search for Great Italian chef's recipe?", "Visit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("http://www.greatitalianchefs.com/");
            }
        }

        private void MainProfile_Load(object sender, EventArgs e)
        {

        }

        private void btndifferentrecipes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to search for different recipes?", "Visit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("http://www.foodandwine.com/");
            }
        }

        private void btnMyrecipes_Click(object sender, EventArgs e)
        {
            this.Hide();
          Form3 ss = new Form3();
            ss.Show();
        }
    }
}
