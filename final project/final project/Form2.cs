using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppHelper;
using System.IO;

namespace final_project
{
    public partial class FrmAddRecipe : Form
    {

        const string XML_FILE = "Recipe.xml";

        private XMLSerializer xml = null;

        private List<Recipe> listRecipe = new List<Recipe>();

        private List <Ingredients> listIngredients = new List<Ingredients>();
       // private List<Steps> stepsList = new List<Steps>();
       
        public FrmAddRecipe()
            
        {
            InitializeComponent();
            LoadData(); 
        }

private void LoadData()
{
    //throw new NotImplementedException();
    xml = new XMLSerializer(XML_FILE);

    if (!File.Exists(xml.XMLPath))
        xml.SaveData(listRecipe);

    listRecipe.Clear();
    listRecipe = xml.LoadData<List<Recipe>>();

    



    //var recipe  = listRecipe[0];
    //this.txtRecipeTitle.Text = recipe.Title;
    //this.cmbServing.Text = recipe.Serving;
    //            this.txtTime.Text = recipe.Time;
    //            this.richtxtDescription.Text = recipe.Description;
    //            this.txtCost.Text = recipe.Cost;
    //            this.txtCalories.Text = recipe.Calories;

    //LoadGrid(recipe.Ingredients);

 	
}

private void LoadGrid()
{
 //	throw new NotImplementedException();
}

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSaveRecipe_Click(object sender, EventArgs e)
        
        {
            if (txtRecipeTitle.Text == "")
            {
                MessageBox.Show("Please enter your recipe title");
            }
            
            
            if (richtxtDescription.Text == "")
            {
                MessageBox.Show("Please enter the Preparation step!");
            }
           
            
            
            if (MessageBox.Show("Do you want to save your recipe", "Save", MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                // user clicked yes
                this.Hide();
                MainProfile ss = new MainProfile();
                ss.Show();
            }
            else
            {
                // user clicked no
            }


            var recipe = new Recipe(
                this.txtRecipeTitle.Text,
                this.cmbServing.Text,
                this.txtTime.Text,
                this.richtxtDescription.Text,
                this.txtCost.Text,
                this.txtCalories.Text);

            recipe.Ingredients = listIngredients;
            
            listRecipe.Add(recipe);

            SaveData();
        }




           
        

private void SaveData()
{
    xml.SaveData(listRecipe);
 //	throw new NotImplementedException();
}

        private void lblAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAddIngredient_Click(object sender, EventArgs e)

        {

            if (txtname.Text == "")
            {
                MessageBox.Show("Please enter the ingredient");
            }

            
            var ingredients = new Ingredients(
                this.txtQuantity.Text,
                            this.cmbUnit.Text,
                            this.txtname.Text);
        
            listIngredients.Add(ingredients);

                       LoadGrid(listIngredients);
                   }

private void LoadGrid(List<Ingredients> listIngredients)
{
 	//throw new NotImplementedException();

    this.dgvIngredients.DataSource = null;
    this.dgvIngredients.DataSource = listIngredients;



    //clearing out the data from controls
                txtname.Text = "";
                txtQuantity.Text = "";
                cmbUnit.SelectedIndex = -1;

}

private void FrmAddRecipe_FormClosing(object sender, FormClosingEventArgs e)
{
    //SaveDAta();
}
        
        



            


                      
          
            //ingredients.Name = this.txtname.Text;
            //ingredients.Quantity = this.txtQuantity.Text;
            //ingredients.Unit = this.cmbUnit.Text;


            //ingredientsList.Add(ingredients);

            //dgvIngredients.DataSource = null;
            //dgvIngredients.DataSource = ingredientsList;

                //clearing out the data from controls
                //txtname.Text = "";
                //txtQuantity.Text = "";
                //cmbUnit.SelectedIndex = -1;


                ////focus
                //txtname.Focus();

            


        

        //private void btnAdddPrepStep_Click(object sender, EventArgs e)
        //{




            //var steps = new Steps();

            //steps.Number = this.cmbStepnumber.Text;
            //steps.Description = this.richtxtDescription.Text;

            //stepsList.Add(steps);

            //dgvSteps.DataSource = null;
            //dgvSteps.DataSource = stepsList;

            //// focus
            //cmbStepnumber.Focus();



            //// clearing out data
            //cmbStepnumber.SelectedIndex = -1;
            //richtxtDescription.Text = "";

            
            
            
            
            
}
        }
