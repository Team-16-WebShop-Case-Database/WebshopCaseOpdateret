using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopCase.Model
{
    public class ProductCategory
    {
        public int ProductID { get; set; }  // Fremmednøgle (FK) til Product
        public int CategoryID { get; set; } // Fremmednøgle (FK) til Category

        // Navigations-egenskaber for relationerne
        public Product Product { get; set; }  // Refererer til Product-objektet
        public Category Category { get; set; } // Refererer til Category-objektet

        // Overload-konstruktør for at initialisere link-tabellen
        public ProductCategory(int productId, int categoryId)
        {
            ProductID = productId;
            CategoryID = categoryId;
        }

        // Standardkonstruktør
        public ProductCategory()
        {
        }
    }
}