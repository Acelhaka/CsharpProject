namespace final_project
{
    partial class FrmAddRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddRecipe));
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblRecipeTitle = new System.Windows.Forms.Label();
            this.txtRecipeTitle = new System.Windows.Forms.TextBox();
            this.lblServing = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmbServing = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.lblPreparation = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCalories = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.richtxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnSaveRecipe = new System.Windows.Forms.Button();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAdd.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdd.Location = new System.Drawing.Point(54, 9);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(335, 50);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Add Your Own Recipe";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // lblRecipeTitle
            // 
            this.lblRecipeTitle.AutoSize = true;
            this.lblRecipeTitle.Location = new System.Drawing.Point(50, 61);
            this.lblRecipeTitle.Name = "lblRecipeTitle";
            this.lblRecipeTitle.Size = new System.Drawing.Size(92, 20);
            this.lblRecipeTitle.TabIndex = 1;
            this.lblRecipeTitle.Text = "Recipe Title";
            // 
            // txtRecipeTitle
            // 
            this.txtRecipeTitle.Location = new System.Drawing.Point(54, 84);
            this.txtRecipeTitle.Name = "txtRecipeTitle";
            this.txtRecipeTitle.Size = new System.Drawing.Size(285, 26);
            this.txtRecipeTitle.TabIndex = 2;
            // 
            // lblServing
            // 
            this.lblServing.AutoSize = true;
            this.lblServing.Location = new System.Drawing.Point(50, 130);
            this.lblServing.Name = "lblServing";
            this.lblServing.Size = new System.Drawing.Size(125, 20);
            this.lblServing.TabIndex = 3;
            this.lblServing.Text = "Serving Quantity";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(342, 130);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 20);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Total Time";
            // 
            // cmbServing
            // 
            this.cmbServing.FormattingEnabled = true;
            this.cmbServing.Items.AddRange(new object[] {
            "1   person\t",
            "2   persons",
            "3   persons",
            "4   persons",
            "5   persons",
            "6   persons",
            "7   persons",
            "8   persons",
            "9   persons",
            "10 persons",
            "11 persons",
            "12 persons"});
            this.cmbServing.Location = new System.Drawing.Point(54, 153);
            this.cmbServing.Name = "cmbServing";
            this.cmbServing.Size = new System.Drawing.Size(160, 28);
            this.cmbServing.TabIndex = 5;
            // 
            // txtTime
            // 
            this.txtTime.AcceptsTab = true;
            this.txtTime.Location = new System.Drawing.Point(346, 155);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(138, 26);
            this.txtTime.TabIndex = 6;
            this.txtTime.Text = "hour, minute";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(50, 193);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(153, 43);
            this.lblIngredients.TabIndex = 7;
            this.lblIngredients.Text = "Ingredients";
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.AutoSize = true;
            this.lblIngredientName.ForeColor = System.Drawing.Color.Black;
            this.lblIngredientName.Location = new System.Drawing.Point(55, 247);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(51, 20);
            this.lblIngredientName.TabIndex = 8;
            this.lblIngredientName.Text = "Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(241, 248);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(404, 246);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(38, 20);
            this.lblUnit.TabIndex = 10;
            this.lblUnit.Text = "Unit";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(59, 271);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 26);
            this.txtname.TabIndex = 11;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(245, 271);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 26);
            this.txtQuantity.TabIndex = 12;
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "bag",
            "bottle",
            "box",
            "can",
            "cup",
            "fluid ounce",
            "g (gram)",
            "gallon",
            "gill",
            "jar",
            "kg (kilogram)",
            "l (liter)",
            "mg (milligram)",
            "ml (milliliter)",
            "ounce",
            "packet",
            "pint",
            "pound",
            "quart",
            "tablespoon",
            "teaspoon"});
            this.cmbUnit.Location = new System.Drawing.Point(408, 269);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 28);
            this.cmbUnit.Sorted = true;
            this.cmbUnit.TabIndex = 13;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIngredient.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAddIngredient.Location = new System.Drawing.Point(810, 261);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(162, 45);
            this.btnAddIngredient.TabIndex = 14;
            this.btnAddIngredient.Text = "Add Ingredient";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // lblPreparation
            // 
            this.lblPreparation.AutoSize = true;
            this.lblPreparation.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparation.Location = new System.Drawing.Point(55, 423);
            this.lblPreparation.Name = "lblPreparation";
            this.lblPreparation.Size = new System.Drawing.Size(163, 43);
            this.lblPreparation.TabIndex = 15;
            this.lblPreparation.Text = "Preparation";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(64, 487);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(80, 20);
            this.lblDirections.TabIndex = 16;
            this.lblDirections.Text = "Directions";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(71, 762);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(99, 43);
            this.lblDetails.TabIndex = 19;
            this.lblDetails.Text = "Details";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(75, 825);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(114, 20);
            this.lblCost.TabIndex = 20;
            this.lblCost.Text = "Cost of Recipe";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(79, 864);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(132, 26);
            this.txtCost.TabIndex = 21;
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(394, 825);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(66, 20);
            this.lblCalories.TabIndex = 22;
            this.lblCalories.Text = "Calories";
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(398, 864);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(132, 26);
            this.txtCalories.TabIndex = 23;
            // 
            // richtxtDescription
            // 
            this.richtxtDescription.Location = new System.Drawing.Point(63, 520);
            this.richtxtDescription.Name = "richtxtDescription";
            this.richtxtDescription.Size = new System.Drawing.Size(647, 172);
            this.richtxtDescription.TabIndex = 24;
            this.richtxtDescription.Text = "\n\n\n\n\n\n\n\n\n";
            // 
            // btnSaveRecipe
            // 
            this.btnSaveRecipe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveRecipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRecipe.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSaveRecipe.Location = new System.Drawing.Point(810, 839);
            this.btnSaveRecipe.Name = "btnSaveRecipe";
            this.btnSaveRecipe.Size = new System.Drawing.Size(222, 87);
            this.btnSaveRecipe.TabIndex = 25;
            this.btnSaveRecipe.Text = "Save Recipe";
            this.btnSaveRecipe.UseVisualStyleBackColor = false;
            this.btnSaveRecipe.Click += new System.EventHandler(this.btnSaveRecipe_Click);
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Location = new System.Drawing.Point(59, 318);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.RowTemplate.Height = 28;
            this.dgvIngredients.Size = new System.Drawing.Size(643, 72);
            this.dgvIngredients.TabIndex = 26;
            // 
            // FrmAddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1295, 1028);
            this.Controls.Add(this.dgvIngredients);
            this.Controls.Add(this.btnSaveRecipe);
            this.Controls.Add(this.richtxtDescription);
            this.Controls.Add(this.txtCalories);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblPreparation);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblIngredientName);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.cmbServing);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblServing);
            this.Controls.Add(this.txtRecipeTitle);
            this.Controls.Add(this.lblRecipeTitle);
            this.Controls.Add(this.lblAdd);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmAddRecipe";
            this.Text = "Add Your Own Recipe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddRecipe_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblRecipeTitle;
        private System.Windows.Forms.TextBox txtRecipeTitle;
        private System.Windows.Forms.Label lblServing;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbServing;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblIngredientName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Label lblPreparation;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.RichTextBox richtxtDescription;
        private System.Windows.Forms.Button btnSaveRecipe;
        private System.Windows.Forms.DataGridView dgvIngredients;
    }
}