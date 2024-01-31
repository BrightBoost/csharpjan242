using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.objectsMethodsOOP.InventoryManagement
{
    public class Inventory
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public bool RemoveProduct(string productName)
        {
            var product = products.FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            return false;
        }

        public Product FindProduct(string productName)
        {
            return products.FirstOrDefault(p => p.Name == productName);
        }
    }
}
