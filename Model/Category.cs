using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopCase.Model
{
    public class Category
    {
        public int CategoryId {  get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public ICollection<Product> Products { get; set; }

        public Category() 
        { 
        
            Products = new List<Product>();
        }

        public Category(string CategoryName, string CategoryDescription)
        {
            this.CategoryName = CategoryName;
            this.CategoryDescription = CategoryDescription;
            Products = new List<Product>();


        }


    }
}
