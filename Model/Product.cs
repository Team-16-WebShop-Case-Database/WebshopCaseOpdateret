using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopCase.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Stock { get; set; }

        public string ImageFilePath { get; set; }

        public Category Category { get; set; }

        public int CategoryID { get; set; }

       public Product(int productID, string productName, string description, decimal price, string stock, string imageFilePath, Category category)
       
         {
           ProductID = productID;
           ProductName = productName;
           Description = description;
           Price = price;
           Stock = stock;
           ImageFilePath = imageFilePath;      
           CategoryID = category.CategoryId;

         }



    }
}
