using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
   public class Ingredients

    {
       public string Name { get; set; }
       public string Quantity { get; set; }
       public string Unit { get; set; }
    


     public Ingredients(string name, string quantity, string unit) 
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Unit = unit;
        }

     public Ingredients()
     {    }
    }
}
