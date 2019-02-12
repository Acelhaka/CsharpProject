using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    public class Recipe
    {
        public string Title { get; set;}
        public string Serving { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
        public string Cost { get; set; }
        public string Calories { get; set; }


        public List<Ingredients> Ingredients { get; set; }

        public Recipe(string title, string serving, string time, string description, 
            string cost, string calories )
        {
            this.Title = title;
            this.Serving = serving;
            this.Description = description;
            this.Cost = cost;
            this.Calories = calories;

            this.Ingredients = new List<Ingredients>();
        }

       

        public Recipe() { }


        
    }
}
    
    
    
    
    

