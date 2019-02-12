using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppHelper;

namespace final_project
{
    public partial class Form3 : Form
    {
        const string XML_FILE = "Recipe.xml";

        private XMLSerializer xml = null;

        private List<Recipe> listRecipe = new List<Recipe>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
            this.dataGridView1.DataSource = listRecipe;
        }

        private void LoadData()
        {
            //throw new NotImplementedException();
            xml = new XMLSerializer(XML_FILE);

            if (!File.Exists(xml.XMLPath))
                xml.SaveData(listRecipe);

            listRecipe.Clear();
            listRecipe = xml.LoadData<List<Recipe>>();

            this.dataGridView1.DataSource = listRecipe;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            OpenForm2WithSelectedValue();
        }

        //private void OpenFormWithSelectedValue()
        //{
        //    string selectedValue = "";

        //    if (dataGridView1.CurrentRow.Index != -1)
        //    {
        //        DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentRow.Index];
        //        selectedValue = row.Cells["Title"].Value.ToString();

        //        OpenForm(selectedValue);
        //    }
        //}

        //private void OpenForm(string selectedValue = "")
        //{
        //    var form2 = new Form2();
        //    form2.RecipeName = selectedValue;
        //    form2.ShowDialog();
        //}

        private void OpenForm2WithSelectedValue()
        {
            string selectedValue = "";

            if (dataGridView1.CurrentRow.Index != -1)
            {
                DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentRow.Index];
                selectedValue = row.Cells["Title "].Value.ToString();

                OpenForm2(selectedValue = "");
            }
        }

        private void OpenForm2(string selectedValue)
        {
            var form2 = new Form2();
            form2.RecipeName = selectedValue;
            form2.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenForm2();
        }

        private void OpenForm2()
        {
          //  throw new NotImplementedException();
        }
    }
}
